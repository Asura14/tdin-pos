using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

public class Pedidos : MarshalByRefObject, IPedidos
{
    List<Pedido> allOrders;

    public event EventDelegate deleEvent;


    public Pedidos()
    {
        allOrders = new List<Pedido>();
        Console.WriteLine("Lista de Pedidos inicializada!");
    }

    public void adicionaPedido(Pedido pedido)
    {
        try {
            allOrders.Add(pedido);
            NotifyClient(Operation.Adicionado, pedido);
        }
        catch (Exception e)
        {
            throw e;
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

    public void SetPedidoPago(int idPedido)
    {
        try
        {
            Pedido pedido = allOrders.Find(x => x.id == idPedido);
            pedido.estado = "pago";
            NotifyClient(Operation.Pago, pedido);
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
            NotifyClient(Operation.Preparado, pedido);
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
            NotifyClient(Operation.Pronto, pedido);
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

    public List<List<Pedido>> GetPedidosPorMesa()
    {
        try
        {
            List<List<Pedido>> pedidosPorMesa = new List<List<Pedido>>();
            for (int i=1; i <= 4; i++)
            {
                List<Pedido> pedidosMesa = new List<Pedido>();
                List<Pedido> pedidosProntoMesa = new List<Pedido>();
                pedidosMesa = allOrders.FindAll(x => x.mesa == i);
                pedidosProntoMesa = allOrders.FindAll(x => x.mesa == i && x.estado.Equals("pronto"));

                if(pedidosMesa.Count != pedidosProntoMesa.Count)
                {
                    pedidosPorMesa.Add(new List<Pedido>());
                } else
                {
                    pedidosPorMesa.Add(pedidosProntoMesa);
                }
            }
            return pedidosPorMesa;
        }
        catch (Exception e)
        {
            throw e;
        }
    }

    public List<Pedido> GetPedidoMesaPago(int mesa)
    {
        return allOrders.FindAll(x => x.mesa == mesa && x.estado.Equals("pago"));
    }

    public void PagarMesa(int mesa)
    {
        try
        {
            foreach(Pedido pedido in allOrders)
            {
                if(pedido.mesa == mesa)
                {
                    pedido.estado = "pago";
                }
            }
        }
        catch (Exception e)
        {
            throw e;
        }
    }

    void NotifyClient(Operation op, Pedido pedido)
    {
        if (deleEvent != null)
        {
            Delegate[] invkList = deleEvent.GetInvocationList();

            foreach (EventDelegate handler in invkList)
            {
                new Thread(() =>
                {
                    try
                    {
                        handler(op, pedido);
                        Console.WriteLine("Invoking Event Handler:" + op.ToString() + " " + pedido.descricao);
                    } catch (Exception e)
                    {
                        deleEvent -= handler;
                        Console.WriteLine("Exception: " + e.Message);
                    }
                }).Start();
            }
        }
    }
}
