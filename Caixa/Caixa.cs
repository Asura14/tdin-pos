using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;

class Caixa
{
    static void Main()
    {
        RemotingConfiguration.Configure("Caixa.exe.config", false);
        EventIntermediate intEvent = new EventIntermediate();
        IPedidos pedidos = (IPedidos)Activator.GetObject(typeof(IPedidos), "tcp://localhost:9000/Server/OrdersServer");
        Pedido pedido = new Pedido(1, "ok", 3, 1, 1, 10);
        pedidos.adicionaPedido(pedido);


    }

}
