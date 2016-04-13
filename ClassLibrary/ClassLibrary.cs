using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;

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



public interface IPedidos
{
    event EventDelegate deleEvent;

    List<Pedido> GetPedidos();
    List<Pedido> GetPedidosCozinha();
    List<Pedido> GetPedidosBar();
    List<Pedido> GetPedidosEmPreparacaoBar();
    List<Pedido> GetPedidosEmPreparacaoCozinha();
    List<Pedido> GetPedidosPronto();
    List<Pedido> GetPedidosPagos();
    List<List<Pedido>> GetPedidosPorMesa();

    void adicionaPedido(Pedido pedido);
    void SetPedidoPreparacao(int idPedido);
    void SetPedidoPronto(int idPedido);
    void SetPedidoPago(int idPedido);
    void PagarMesa(int mesa);
}

public enum Operation { Adicionado, Preparado, Pronto, Pago}
public delegate void EventDelegate(Operation op, Pedido pedido);

public class EventIntermediate: MarshalByRefObject
{
    public event EventDelegate deleEvent;


    public override object InitializeLifetimeService()
    {
        Console.WriteLine("[EventIntermediate]: InitializeLifeTimeService");
        return null;
    }

    public void Repeater(Operation op, Pedido pedido)
    {
        if (deleEvent != null)
        {
            deleEvent(op, pedido);
        }
    }
}
