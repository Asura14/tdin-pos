using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sala
{
    public partial class Sala : Form
    {
        private IPedidos listaPedidos;
        private EventIntermediate inter;
        delegate void Dispatcher(List<Pedido> pedidos);
        public Dictionary<string, float> menuList;
        public SortedDictionary<int, string> mesasList;
        public int[] quantityList = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        [STAThread]
        static void Main()
        {
            Application.Run(new Sala());
        }

        public Sala()
        {
            RemotingConfiguration.Configure("Sala.exe.config", false);
            listaPedidos = (IPedidos)RemoteNew.New(typeof(IPedidos));

            inter = new EventIntermediate();
            inter.deleEvent += DoAlterations;
            listaPedidos.deleEvent += new EventDelegate(inter.Repeater);
            //Inicializar Menu
            menuList = new Dictionary<string, float>();
            mesasList = new SortedDictionary<int, string>();
            populateComboMenus();

            InitializeComponent();
            comboBoxMenu.DataSource = new BindingSource(menuList, null);
            comboBoxMenu.DisplayMember = "Key";
            comboBoxMenu.ValueMember = "Value";
            comboBoxMesa.DataSource = new BindingSource(mesasList, null);
            comboBoxMesa.DisplayMember = "Value";
            comboBoxMesa.ValueMember = "Key";

            //Carregar Lista com Valores
            atualizaLista(listaPedidos.GetPedidos());

            foreach (int type in quantityList)
            {
                comboBoxQuantidade.Items.Add(type);
            }
            comboBoxQuantidade.SelectedIndex = 0;
            devolveTipo();
        }

        public void DoAlterations(Operation op, Pedido pedido)
        {
            if (this.gridPedidos.InvokeRequired)
            {
                Dispatcher d = new Dispatcher(atualizaLista);
                this.Invoke(d, new object[] { listaPedidos.GetPedidos() });
                Console.WriteLine("Got in here BRO THREAD");
            }
            else
            {
                atualizaLista(listaPedidos.GetPedidos());
                Console.WriteLine("Got in here BRO");
            }
        }

        private void buttonPedir_Click(object sender, EventArgs e)
        {
            int tipoPedido;
            try {
                if (comboBoxMenu.SelectedIndex >= 5)
                {
                    tipoPedido = 1; //Bar
                } else
                {
                    tipoPedido = 0; //Cozinha
                }
                    string descricao = ((System.Collections.Generic.KeyValuePair<string, float>)comboBoxMenu.SelectedItem).Key;
                float preco = ((System.Collections.Generic.KeyValuePair<string, float>)comboBoxMenu.SelectedItem).Value;
                int quantidade = (int)comboBoxQuantidade.SelectedItem;
                int mesa = ((System.Collections.Generic.KeyValuePair<int, string>)comboBoxMesa.SelectedItem).Key;
                Pedido newPedido = new Pedido(listaPedidos.GetPedidos().Count + 1, descricao, quantidade, mesa, tipoPedido, preco*quantidade);
                listaPedidos.adicionaPedido(newPedido);
                atualizaLista(listaPedidos.GetPedidos());
            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception: " + exception.Message);
                MessageBox.Show("Nenhum Item selecionado", "Alerta");
            }

        }


        public void populateComboMenus()
        {
            menuList.Add("Bacalhau com natas - 7.50", 7.50f);
            menuList.Add("Francesinha - 9.50", 9.50f);
            menuList.Add("Espetada de vaca - 6.50", 6.50f);
            menuList.Add("Picanha - 7.00", 7.00f);
            menuList.Add("Sopa do dia - 4.50", 4.50f);
            menuList.Add("Cocktail Mexicano - 3.50", 3.50f);
            menuList.Add("Caipirinha - 3.00", 3.00f);
            menuList.Add("Martini - 2.50", 2.50f);
            mesasList.Add(1, "Mesa 1");
            mesasList.Add(2, "Mesa 2");
            mesasList.Add(3, "Mesa 3");
            mesasList.Add(4, "Mesa 4");

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void atualizaLista(List<Pedido> lista)
        { 

            gridPedidos.Rows.Clear();

            foreach (Pedido ped in lista)
            {
                string tipoTmp;
                if(ped.tipo == 0)
                {
                    tipoTmp = "Cozinha";                }
                else
                {
                    tipoTmp = "Bar";
                }
                string[] temp = { ped.id.ToString(), ped.descricao, ped.mesa.ToString(), tipoTmp, ped.estado };
                gridPedidos.Rows.Add(temp);
            }
        }

        private void comboBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            devolveTipo();
        }

        private void devolveTipo()
        {
            if (comboBoxMenu.SelectedIndex >= 5)
            {
                labelTipoMutavel.Text = "Bar";
            }
            else if (comboBoxMenu.SelectedIndex >= 0 && comboBoxMenu.SelectedIndex < 5)
            {
                labelTipoMutavel.Text = "Cozinha";
            }
        }
    }

    class RemoteNew
    {
        private static Hashtable types = null;

        private static void InitTypeTable()
        {
            types = new Hashtable();
            foreach (WellKnownClientTypeEntry entry in RemotingConfiguration.GetRegisteredWellKnownClientTypes())
                types.Add(entry.ObjectType, entry);
        }

        public static object New(Type type)
        {
            if (types == null)
                InitTypeTable();
            WellKnownClientTypeEntry entry = (WellKnownClientTypeEntry)types[type];
            if (entry == null)
                throw new RemotingException("Type not found!");
            return RemotingServices.Connect(type, entry.ObjectUrl);
        }
    }
}

