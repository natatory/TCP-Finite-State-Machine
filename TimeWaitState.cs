using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCP_Finite_State_Machine
{
    class TimeWaitState : ISimplisticTCPState
    {
        public string Name { get => "TIME_WAIT"; }
        private TCP tcpFSM;

        public TimeWaitState(TCP tcpFSM)
        {
            this.tcpFSM = tcpFSM;
        }

        public bool AppActiveOpen() => false;

        public bool AppClose() => false;

        public bool AppPassiveOpen() => false;

        public bool AppSend() => false;

        public bool AppTimeOut()
        {
            tcpFSM.SetState(tcpFSM.closedState);
            return true;
        }

        public bool RcvAck() => false;

        public bool RcvFin() => false;

        public bool RcvFinAck() => false;

        public bool RcvSyn() => false;

        public bool RcvSynAck() => false;
    }
}
