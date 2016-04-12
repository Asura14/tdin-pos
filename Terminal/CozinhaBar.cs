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

        public CozinhaBar(int tipo)
        {
            this.tipo = tipo;
            RemotingConfiguration.Configure("Terminal.exe.config", false);
            listaPedidos = (IPedidos)RemoteNew.New(typeof(IPedidos));
            inter = new EventIntermediate();

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

        private void buttonPreparacao_Click(object sender, EventArgs e)
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
        }

        private void buttonPronto_Click(object sender, EventArgs e)
        {
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
        }

        private void atualizaListaPedidos(List<Pedido> lista)
        {
            dataGridPedidos.Rows.Clear();
            foreach (Pedido ped in lista)
            {
                string[] temp = { ped.id.ToString(), ped.descricao, ped.estado };
                dataGridPedidos.Rows.Add(temp);
            }
        }

        private void atualizaListaPreparacao(List<Pedido> lista)
        {

            dataGridPreparacao.Rows.Clear();
            foreach (Pedido ped in lista)
            {
                string[] temp = { ped.id.ToString(), ped.descricao, ped.estado };
                dataGridPreparacao.Rows.Add(temp);
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
