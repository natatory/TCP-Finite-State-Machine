using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCP_Finite_State_Machine
{
    class SynRcvdState : ISimplisticTCPState
    {
        public string Name { get => "SYN_RCVD"; }
        private TCP tcpFSM;

        public SynRcvdState(TCP tcpFSM)
        {
            this.tcpFSM = tcpFSM;
        }

        public bool AppActiveOpen() => false;

        public bool AppClose()
        {
            tcpFSM.SetState(tcpFSM.finWait1State);
            return true;
        }

        public bool AppPassiveOpen() => false;

        public bool AppSend() => false;

        public bool AppTimeOut() => false;

        public bool RcvAck()
        {
            tcpFSM.SetState(tcpFSM.establishedState);
            return true;
        }

        public bool RcvFin() => false;

        public bool RcvFinAck() => false;

        public bool RcvSyn() => false;

        public bool RcvSynAck() => false;
    }
}
