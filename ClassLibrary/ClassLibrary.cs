using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Delegates
public delegate void AddPedidoEventHandler();
public delegate void PrepPedidoEvenHandler();
public delegate void ProntoPedidoEventHandler();
public delegate void EntreguePedidoEnventHandler();
public delegate void PagoPedidoEventHandler();

[Serializable]
public class Pedido
{
    public int id;
    public string descricao;
    public int quantidade;
    public int mesa;
    public int tipo;
    public float preco;
    public string estado;

    public Pedido(int id, string descricao, int quantidade, int mesa, int tipo, float preco)
    {
        this.id = id;
        this.descricao = descricao;
        this.quantidade = quantidade;
        this.mesa = mesa;
        this.preco = preco;
        this.tipo = tipo;
        this.estado = "pedido";
    }
}

public class Cliente
{

}

public interface IPedidos
{
    event AddPedidoEventHandler addPedido;
    event PrepPedidoEvenHandler prepPedido;
    event ProntoPedidoEventHandler prontoPedido;
    event EntreguePedidoEnventHandler entreguePedido;
    event PagoPedidoEventHandler pagoPedido;

    List<Pedido> GetPedidos();
    List<Pedido> GetPedidosCozinha();
    List<Pedido> GetPedidosBar();
    List<Pedido> GetPedidosEmPreparacao();
    List<Pedido> GetPedidosPronto();
    List<Pedido> GetPedidosEntregues();
    List<Pedido> GetPedidosPagos();

    void adicionaPedido(Pedido pedido);
    void SetPedidoPreparacao(int idPedido);
    void SetPedidoPronto(int idPedido);
    void SetPedidoEntregue(int idPedido);
    void SetPedidoPago(int idPedido);

}

public class EventIntermediate: MarshalByRefObject
{
    public event AddPedidoEventHandler addPedido;
    public event PrepPedidoEvenHandler prepPedido;
    public event ProntoPedidoEventHandler prontoPedido;
    public event EntreguePedidoEnventHandler entreguePedido;
    public event PagoPedidoEventHandler pagoPedido;

    public void FireAddPedido()
    {
        addPedido();
    }

    public void FirePrepPedido()
    {
        prepPedido();
    }

    public void FireProntoPedido()
    {
        prontoPedido();
    }

    public void FireEntreguePedido()
    {
        entreguePedido();
    }

    public void FirePagoPedido()
    {
        pagoPedido();
    }

    public override object InitializeLifetimeService()
    {
        Console.WriteLine("[EventIntermediate]: InitializeLifeTimeService");
        return null;
    }
}
