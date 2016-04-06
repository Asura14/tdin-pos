using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Pedidos : MarshalByRefObject, IPedidos
{
    List<Pedido> allOrders;

    public event AddPedidoEventHandler addPedido;
    public event EntreguePedidoEnventHandler entreguePedido;
    public event PagoPedidoEventHandler pagoPedido;
    public event PrepPedidoEvenHandler prepPedido;
    public event ProntoPedidoEventHandler prontoPedido;


    public Pedidos()
    {
        allOrders = new List<Pedido>();
        Console.WriteLine("Lista de Pedidos inicializada!");
    }

    public void adicionaPedido(Pedido pedido)
    {
        try {
            allOrders.Add(pedido);
            addPedido();
        }
        catch (Exception e)
        {

        }
    }

    public List<Pedido> GetPedidos()
    {
        try
        {
            return allOrders;
        } catch(Exception e)
        {
            throw e;
        }
    }

    public List<Pedido> GetPedidosBar()
    {
        try
        {
            return allOrders.FindAll(x => x.tipo.Equals("bar"));
        } catch(Exception e)
        {
            throw e;
        }
    }

    public List<Pedido> GetPedidosCozinha()
    {
        try
        {
            return allOrders.FindAll(x => x.tipo.Equals("cozinha"));
        }
        catch (Exception e)
        {
            throw e;
        }
    }

    public List<Pedido> GetPedidosEmPreparacao()
    {
        try
        {
            return allOrders.FindAll(x => x.estado.Equals("prep"));
        }
        catch (Exception e)
        {
            throw e;
        }
    }

    public List<Pedido> GetPedidosEntregues()
    {
        try
        {
            return allOrders.FindAll(x => x.estado.Equals("entregue"));
        }
        catch (Exception e)
        {
            throw e;
        }
    }

    public List<Pedido> GetPedidosPagos()
    {
        try
        {
            return allOrders.FindAll(x => x.estado.Equals("pago"));
        }
        catch (Exception e)
        {
            throw e;
        }
    }

    public List<Pedido> GetPedidosPronto()
    {
        try
        {
            return allOrders.FindAll(x => x.estado.Equals("pronto"));
        }
        catch (Exception e)
        {
            throw e;
        }
    }

    public void SetPedidoEntregue(int idPedido)
    {
        try
        {
            allOrders.Find(x => x.id == idPedido);
            entreguePedido();
        }
        catch (Exception e)
        {
            throw e;
        }
    }

    public void SetPedidoPago(int idPedido)
    {
        try
        {
            allOrders.Find(x => x.id == idPedido);
            pagoPedido();
        }
        catch (Exception e)
        {
            throw e;
        }
    }

    public void SetPedidoPreparacao(int idPedido)
    {
        try
        {
            allOrders.Find(x => x.id == idPedido);
            prepPedido();
        }
        catch (Exception e)
        {
            throw e;
        }
    }

    public void SetPedidoPronto(int idPedido)
    {
        try
        {
            allOrders.Find(x => x.id == idPedido);
            prontoPedido();
        }
        catch (Exception e)
        {
            throw e;
        }
    }

}
