using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCP_Finite_State_Machine
{
    interface ISimplisticTCPState
    {
        string Name { get; }
        bool AppPassiveOpen();
        bool AppActiveOpen();
        bool AppSend();
        bool AppClose();
        bool AppTimeOut();
        bool RcvSyn();
        bool RcvAck();
        bool RcvSynAck();
        bool RcvFin();
        bool RcvFinAck();
    }
}
