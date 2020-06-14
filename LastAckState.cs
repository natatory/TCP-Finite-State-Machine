using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCP_Finite_State_Machine
{
    class LastAckState : ISimplisticTCPState
    {
        public string Name { get => "LAST_ACK"; }
        private TCP tcpFSM;

        public LastAckState(TCP tcpFSM)
        {
            this.tcpFSM = tcpFSM;
        }

        public bool AppActiveOpen() => false;

        public bool AppClose() => false;

        public bool AppPassiveOpen() => false;

        public bool AppSend() => false;

        public bool AppTimeOut() => false;

        public bool RcvAck()
        {
            tcpFSM.SetState(tcpFSM.closedState);
            return true;
        }

        public bool RcvFin() => false;

        public bool RcvFinAck() => false;

        public bool RcvSyn() => false;

        public bool RcvSynAck() => false;
    }
}
