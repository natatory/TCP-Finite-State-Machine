using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCP_Finite_State_Machine
{
    class CloseWaitState : ISimplisticTCPState
    {
        public string Name { get => "CLOSE_WAIT"; }
        private TCP tcpFSM;

        public CloseWaitState(TCP tcpFSM)
        {
            this.tcpFSM = tcpFSM;
        }

        public bool AppClose()
        {
            tcpFSM.SetState(tcpFSM.lastAckState);
            return true;
        }

        public bool AppActiveOpen() => false;

        public bool AppPassiveOpen() => false;

        public bool AppSend() => false;

        public bool AppTimeOut() => false;

        public bool RcvAck() => false;

        public bool RcvFin() => false;

        public bool RcvFinAck() => false;

        public bool RcvSyn() => false;

        public bool RcvSynAck() => false;
    }
}
