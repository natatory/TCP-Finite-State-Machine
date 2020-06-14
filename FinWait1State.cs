using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCP_Finite_State_Machine
{
    class FinWait1State : ISimplisticTCPState
    {
        public string Name { get => "FIN_WAIT_1"; }
        private TCP tcpFSM;

        public FinWait1State(TCP tcpFSM)
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
            tcpFSM.SetState(tcpFSM.finWait2State);
            return true;
        }

        public bool RcvFin()
        {
            tcpFSM.SetState(tcpFSM.closingState);
            return true;
        }

        public bool RcvFinAck()
        {
            tcpFSM.SetState(tcpFSM.timeWaitState);
            return true;
        }

        public bool RcvSyn() => false;

        public bool RcvSynAck() => false;
    }
}
