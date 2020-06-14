using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCP_Finite_State_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TCP.TraverseStates(
                new[] { "APP_ACTIVE_OPEN", "RCV_SYN_ACK", "APP_CLOSE", "RCV_FIN_ACK", "RCV_ACK" }));
            Console.ReadLine();
        }
    }
}
