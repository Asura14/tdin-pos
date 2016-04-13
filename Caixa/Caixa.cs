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
        delegate void Dispatcher(List<Pedido> pedidos);

        public Caixa()
        {
            RemotingConfiguration.Configure("Caixa.exe.config", false);
            listaPedidos = (IPedidos)RemoteNew.New(typeof(IPedidos));
            inter = new EventIntermediate();

            inter.deleEvent += DoAlterations;
            listaPedidos.deleEvent += new EventDelegate(inter.Repeater);

            InitializeComponent();

            atualizaListaPagos(listaPedidos.GetPedidosPronto());
        }

        static void Main()
        {
            Application.Run(new Caixa());
        }

        private void buttonPago_Click(object sender, EventArgs e)
        {
            string selecionado = dataGridProntos.SelectedCells[0].Value.ToString();
            int id = Int32.Parse(selecionado);
            listaPedidos.SetPedidoPago(id);
            atualizaListaPagos(listaPedidos.GetPedidosPronto());

            printReceipt(listaPedidos.GetPedidosPagos()[listaPedidos.GetPedidosPagos().Count - 1]);
        }

        private void DoAlterations(Operation op, Pedido pedido)
        {
            if (this.dataGridProntos.InvokeRequired)
            {
                Dispatcher d = new Dispatcher(atualizaListaPagos);
                this.Invoke(d, new object[] { listaPedidos.GetPedidosPronto() });
            }
        }

        private void atualizaListaPagos(List<Pedido> lista)
        {
            dataGridProntos.Rows.Clear();
            foreach (Pedido ped in lista)
            {
                string[] temp = { ped.id.ToString(), ped.descricao, ped.estado };
                dataGridProntos.Rows.Add(temp);
            }
        }

        private void printReceipt(Pedido pedido)
        {
            Console.WriteLine("========== RECEIPT FOR ORDER: " + pedido.id + " ==========");
            Console.WriteLine("Table: " + pedido.mesa);
            Console.WriteLine(" Product: " + pedido.descricao + "EUR");
            Console.WriteLine(DateTime.Now);
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
