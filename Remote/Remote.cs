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
            return allOrders.FindAll(x => x.tipo == 1 && x.estado.Equals("pedido"));
        } catch(Exception e)
        {
            throw e;
        }
    }

    public List<Pedido> GetPedidosCozinha()
    {
        try
        {
            return allOrders.FindAll(x => x.tipo == 0 && x.estado.Equals("pedido"));
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

    public void SetPedidoEntregue(int idPedido)
    {
        try
        {
            Pedido pedido = allOrders.Find(x => x.id == idPedido);
            pedido.estado = "entregue";
            //entreguePedido();
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
            Pedido pedido = allOrders.Find(x => x.id == idPedido);
            pedido.estado = "pago";
            //pagoPedido();
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
            Pedido pedido = allOrders.Find(x => x.id == idPedido);
            pedido.estado = "preparacao";
            //prepPedido();
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
            Pedido pedido = allOrders.Find(x => x.id == idPedido);
            pedido.estado = "pronto";
            //prontoPedido();
        }
        catch (Exception e)
        {
            throw e;
        }
    }

    public List<Pedido> GetPedidosEmPreparacaoBar()
    {
        try
        {
            return allOrders.FindAll(x => x.estado.Equals("preparacao") && x.tipo == 1);
        }
        catch (Exception e)
        {
            throw e;
        }
    }

    public List<Pedido> GetPedidosEmPreparacaoCozinha()
    {
        try
        {
            return allOrders.FindAll(x => x.estado.Equals("preparacao") && x.tipo == 0);
        }
        catch (Exception e)
        {
            throw e;
        }
    }

    public List<Pedido> GetPedidosProntoCozinha()
    {
        try
        {
            return allOrders.FindAll(x => x.estado.Equals("pronto") && x.tipo == 0);
        }
        catch (Exception e)
        {
            throw e;
        }
    }

    public List<Pedido> GetPedidosProntoBar()
    {
        try
        {
            return allOrders.FindAll(x => x.estado.Equals("pronto") && x.tipo == 1);
        }
        catch (Exception e)
        {
            throw e;
        }
    }
}
