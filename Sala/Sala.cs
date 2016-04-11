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
        private Panel painelSalas;
        private static Label label1;
        public SortedDictionary<string, float> menuList;
        public SortedDictionary<int, string> mesasList;
        public int[] quantityList = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        public string tipoL;

        static void Main()
        {
            Application.Run(new Sala());
        }

        public Sala()
        {
            RemotingConfiguration.Configure("Sala.exe.config", false);
            listaPedidos = (IPedidos)RemoteNew.New(typeof(IPedidos));
            tipoL = "jose";

            inter = new EventIntermediate();
            //Inicializar Menu
            menuList = new SortedDictionary<string, float>();
            mesasList = new SortedDictionary<int, string>();
            populateComboMenus();

            InitializeComponent();
            comboBoxMenu.DataSource = new BindingSource(menuList, null);
            comboBoxMenu.DisplayMember = "Key";
            comboBoxMenu.ValueMember = "Value";
            comboBoxMesa.DataSource = new BindingSource(mesasList, null);
            comboBoxMesa.DisplayMember = "Value";
            comboBoxMesa.ValueMember = "Key";

            labelTipoMutavel.Text = "Teste";

            //Carregar Lista com Valores
            atualizaLista(listaPedidos.GetPedidos());

            foreach (int type in quantityList)
            {
                comboBoxQuantidade.Items.Add(type);
            }
        }

        private void buttonPedir_Click(object sender, EventArgs e)
        {
            try {
                string descricao = ((System.Collections.Generic.KeyValuePair<string, float>)comboBoxMenu.SelectedItem).Key;
                float preco = ((System.Collections.Generic.KeyValuePair<string, float>)comboBoxMenu.SelectedItem).Value;
                int quantidade = (int)comboBoxQuantidade.SelectedItem;
                int mesa = ((System.Collections.Generic.KeyValuePair<int, string>)comboBoxMesa.SelectedItem).Key;
                Pedido newPedido = new Pedido(listaPedidos.GetPedidos().Count + 1, descricao, quantidade, mesa, 1, preco);
                listaPedidos.adicionaPedido(newPedido);
                atualizaLista(listaPedidos.GetPedidos());
                MessageBox.Show("Pedido adicionado", "Alerta");
            }
            catch (Exception exception)
            {
                throw exception;
            }

        }


        public void populateComboMenus()
        {
            menuList.Add("Bacalhau com natas - 7.50", 7.50f);
            menuList.Add("Francesinha - 9.50", 9.50f);
            menuList.Add("Cocktail Mexicano - 3.50", 3.50f);
            menuList.Add("Caipirinha - 3.00", 3.00f);
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
                string[] temp = { ped.id.ToString(), ped.descricao, ped.mesa.ToString(), ped.tipo.ToString(), ped.estado };
                gridPedidos.Rows.Add(temp);
            }
        }

        private void comboBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelTipoMutavel.Text = "Texto diferente";

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

