using System;
using System.Collections;
using System.Runtime.Remoting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Caixa
{
    static void Main()
    {
        RemotingConfiguration.Configure("Caixa.exe.config", false);
        IPedidos pedidos = (IPedidos)RemoteNew.New(typeof(IPedidos));

        EventIntermediate intEvent = new EventIntermediate();
        Pedido pedido = new Pedido(1, "ok", 3, 1, 1, 10);
        pedidos.adicionaPedido(pedido);
        foreach (Pedido ped in pedidos.GetPedidos())
        {
            Console.WriteLine("ID: " + ped.id + "\n" + "Desc: " + ped.descricao + "\n" + "Estado: " + ped.estado + "\n");
        }
        Console.ReadLine();

    }

}
