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

namespace Caixa
{
    public partial class Caixa : Form
    {

        IPedidos listaPedidos;
        EventIntermediate inter;
        delegate void Dispatcher(List<List<Pedido>> pedidos);

        public Caixa()
        {
            RemotingConfiguration.Configure("Caixa.exe.config", false);
            listaPedidos = (IPedidos)RemoteNew.New(typeof(IPedidos));
            inter = new EventIntermediate();

            inter.deleEvent += DoAlterations;
            listaPedidos.deleEvent += new EventDelegate(inter.Repeater);

            InitializeComponent();
            atualizaListaPagos(listaPedidos.GetPedidosPorMesa());
        }

        static void Main()
        {
            Application.Run(new Caixa());
        }

        private void buttonPago_Click(object sender, EventArgs e)
        {
            try
            {
                string selecionado = dataGridProntos.SelectedCells[0].Value.ToString();
                int id = Int32.Parse(selecionado);
                listaPedidos.PagarMesa(id);
                atualizaListaPagos(listaPedidos.GetPedidosPorMesa());

                printReceipt(id);
            } catch (Exception exception)
            {
                Console.WriteLine("Exception: " + exception.Message);
                MessageBox.Show("Nenhum Item selecionado", "Alerta");
            }
        }

        private void DoAlterations(Operation op, Pedido pedido)
        {
            if (this.dataGridProntos.InvokeRequired)
            {
                Dispatcher d = new Dispatcher(atualizaListaPagos);
                this.Invoke(d, new object[] { listaPedidos.GetPedidosPorMesa() });
            }
        }

        private void atualizaListaPagos(List<List<Pedido>> lista)
        {
            dataGridProntos.Rows.Clear();
            foreach (List<Pedido> listaMesa in lista)
            {
                if (listaMesa.Any())
                {
                    string[] temp = { listaMesa[0].mesa.ToString(), calculaPrecoMesa(listaMesa).ToString() };
                    dataGridProntos.Rows.Add(temp);
                }
            }
        }

        private void printReceipt(int mesa)
        {
            List<Pedido> pedidosMesa = listaPedidos.GetPedidoMesaPago(mesa);

            Console.WriteLine("========== RECEIPT FOR TABLE: " + mesa + " ==========");
            float totalPrice = 0;
            foreach (var pedido in pedidosMesa)
            {
                Console.WriteLine(" Product: " + pedido.descricao + " EUR");
                Console.WriteLine(" Quantity: " + pedido.quantidade.ToString() + " UN");
                totalPrice += pedido.preco;
            }
            Console.WriteLine("Total Price: " + totalPrice.ToString() + " EUR");
            Console.WriteLine(DateTime.Now);
        }

        private float calculaPrecoMesa(List<Pedido> pedidosMesa)
        {
            return pedidosMesa.Sum(x => x.preco);
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
