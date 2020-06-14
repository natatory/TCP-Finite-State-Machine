using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCP_Finite_State_Machine
{
    class ClosedState : ISimplisticTCPState
    {
        public string Name { get => "CLOSED"; }
        private TCP tcpFSM;

        public ClosedState(TCP tcpFSM)
        {
            this.tcpFSM = tcpFSM;
        }

        public bool AppActiveOpen()
        {
            tcpFSM.SetState(tcpFSM.synSenState);
            return true;
        }

        public bool AppPassiveOpen()
        {
            tcpFSM.SetState(tcpFSM.listenState);
            return true;
        }

        public bool AppClose() => false;

        public bool AppSend() => false;

        public bool AppTimeOut() => false;

        public bool RcvAck() => false;

        public bool RcvFin() => false;

        public bool RcvFinAck() => false;

        public bool RcvSyn() => false;

        public bool RcvSynAck() => false;
    }
}
