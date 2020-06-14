using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCP_Finite_State_Machine
{
    class SynSentState : ISimplisticTCPState
    {
        public string Name { get => "SYN_SENT"; }
        private TCP tcpFSM;

        public SynSentState(TCP tcpFSM)
        {
            this.tcpFSM = tcpFSM;
        }

        public bool AppActiveOpen() => false;

        public bool AppClose()
        {
            tcpFSM.SetState(tcpFSM.closedState);
            return true;
        }

        public bool AppPassiveOpen() => false;

        public bool AppSend() => false;

        public bool AppTimeOut() => false;

        public bool RcvAck() => false;

        public bool RcvFin() => false;

        public bool RcvFinAck() => false;

        public bool RcvSyn()
        {
            tcpFSM.SetState(tcpFSM.synRcvdState);
            return true;
        }

        public bool RcvSynAck()
        {
            tcpFSM.SetState(tcpFSM.establishedState);
            return true;
        }
    }
}
