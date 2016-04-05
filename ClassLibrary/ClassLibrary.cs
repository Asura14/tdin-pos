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

public class Pedido
{

}

public class Cliente
{

}

public interface IPedidos
{

}

public class EventIntermediate: MarshalByRefObject
{
    public event AddPedidoEventHandler addPedido;
    public event PrepPedidoEvenHandler prepPedido;
    public event ProntoPedidoEventHandler prontoPedido;
    public event EntreguePedidoEnventHandler entreguePedido;
    public event PagoPedidoEventHandler pagoPedido;
}