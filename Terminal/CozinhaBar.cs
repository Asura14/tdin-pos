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

namespace Terminal
{
    public partial class CozinhaBar : Form
    {

        IPedidos listaPedidos;
        EventIntermediate inter;
        int tipo;
        delegate void Dispatcher(List<Pedido> pedidos);

        public CozinhaBar(int tipo)
        {
            this.tipo = tipo;
            RemotingConfiguration.Configure("Terminal.exe.config", false);
            listaPedidos = (IPedidos)RemoteNew.New(typeof(IPedidos));
            inter = new EventIntermediate();

            inter.deleEvent += DoAlterations;
            listaPedidos.deleEvent += new EventDelegate(inter.Repeater);

            InitializeComponent();

            if (this.tipo == 0) //Cozinha
            {
                atualizaListaPedidos(listaPedidos.GetPedidosCozinha());
                atualizaListaPreparacao(listaPedidos.GetPedidosEmPreparacaoCozinha());
            }
            else //Bar
            {
                atualizaListaPedidos(listaPedidos.GetPedidosBar());
                atualizaListaPreparacao(listaPedidos.GetPedidosEmPreparacaoBar());
            }
        }

        private void DoAlterations(Operation op, Pedido pedido)
        {
            if(this.dataGridPedidos.InvokeRequired)
            {
                if (this.tipo == 0)
                {

                    Dispatcher d = new Dispatcher(atualizaListaPedidos);
                    this.Invoke(d, new object[] { listaPedidos.GetPedidosCozinha() });
                    Dispatcher e = new Dispatcher(atualizaListaPreparacao);
                    this.Invoke(e, new object[] { listaPedidos.GetPedidosEmPreparacaoCozinha() });

                    Console.WriteLine("DoAlterations COZINHA THREAD");
                }
                else
                {


                    Dispatcher d = new Dispatcher(atualizaListaPedidos);
                    this.Invoke(d, new object[] { listaPedidos.GetPedidosBar() });
                    Dispatcher e = new Dispatcher(atualizaListaPreparacao);
                    this.Invoke(e, new object[] { listaPedidos.GetPedidosEmPreparacaoBar() });

                    Console.WriteLine("DoAlterations BAR THREAD");
                }
            }
            else
            {
                if (this.tipo == 0) //Cozinha
                {
                    atualizaListaPedidos(listaPedidos.GetPedidosCozinha());
                    atualizaListaPreparacao(listaPedidos.GetPedidosEmPreparacaoCozinha());
                }
                else //Bar
                {
                    atualizaListaPedidos(listaPedidos.GetPedidosBar());
                    atualizaListaPreparacao(listaPedidos.GetPedidosEmPreparacaoBar());
                }

            }
        }

        private void buttonPreparacao_Click(object sender, EventArgs e)
        {
            try
            {

                string selecionado = dataGridPedidos.SelectedCells[0].Value.ToString();
                int id = Int32.Parse(selecionado);
                listaPedidos.SetPedidoPreparacao(id);
                if (this.tipo == 0) //Cozinha
                {
                    atualizaListaPedidos(listaPedidos.GetPedidosCozinha());
                    atualizaListaPreparacao(listaPedidos.GetPedidosEmPreparacaoCozinha());
                }
                else //Bar
                {
                    atualizaListaPedidos(listaPedidos.GetPedidosBar());
                    atualizaListaPreparacao(listaPedidos.GetPedidosEmPreparacaoBar());
                }
            }catch (Exception exc)
            {
                Console.WriteLine("Exception: " + exc.Message);
            }
        }

        private void buttonPronto_Click(object sender, EventArgs e)
        {
            try {
                string selecionado = dataGridPreparacao.SelectedCells[0].Value.ToString();
                int id = Int32.Parse(selecionado);
                listaPedidos.SetPedidoPronto(id);
                if (this.tipo == 0) //Cozinha
                {
                    atualizaListaPedidos(listaPedidos.GetPedidosCozinha());
                    atualizaListaPreparacao(listaPedidos.GetPedidosEmPreparacaoCozinha());
                }
                else //Bar
                {
                    atualizaListaPedidos(listaPedidos.GetPedidosBar());
                    atualizaListaPreparacao(listaPedidos.GetPedidosEmPreparacaoBar());
                }
            }catch (Exception exc)
            {
                Console.WriteLine("Exception: " + exc.Message);
            }
        }

        private void atualizaListaPedidos(List<Pedido> lista)
        {
            try
            {
                dataGridPedidos.Rows.Clear();
                foreach (Pedido ped in lista)
                {
                    string[] temp = { ped.id.ToString(), ped.descricao, ped.estado };
                    dataGridPedidos.Rows.Add(temp);
                }
            } catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        private void atualizaListaPreparacao(List<Pedido> lista)
        {
            try {
                dataGridPreparacao.Rows.Clear();
                foreach (Pedido ped in lista)
                {
                    string[] temp = { ped.id.ToString(), ped.descricao, ped.estado };
                    dataGridPreparacao.Rows.Add(temp);
                }
            } catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
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
