using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCP_Finite_State_Machine
{
    class ClosingState : ISimplisticTCPState
    {
        public string Name { get => "CLOSING"; }
        private TCP tcpFSM;

        public ClosingState(TCP tcpFSM)
        {
            this.tcpFSM = tcpFSM;
        }

        public bool RcvAck()
        {
            tcpFSM.SetState(tcpFSM.timeWaitState);
            return true;
        }

        public bool AppActiveOpen() => false;

        public bool AppClose() => false;

        public bool AppPassiveOpen() => false;

        public bool AppSend() => false;

        public bool AppTimeOut() => false;

        public bool RcvFin() => false;

        public bool RcvFinAck() => false;

        public bool RcvSyn() => false;

        public bool RcvSynAck() => false;
    }
}
