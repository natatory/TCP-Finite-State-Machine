using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCP_Finite_State_Machine
{
    class FinWait2State : ISimplisticTCPState
    {
        public string Name { get => "FIN_WAIT_2"; }
        private TCP tcpFSM;

        public FinWait2State(TCP tcpFSM)
        {
            this.tcpFSM = tcpFSM;
        }

        public bool AppActiveOpen() => false;

        public bool AppClose() => false;

        public bool AppPassiveOpen() => false;

        public bool AppSend() => false;

        public bool AppTimeOut() => false;

        public bool RcvAck() => false;

        public bool RcvFin()
        {
            tcpFSM.SetState(tcpFSM.timeWaitState);
            return true;
        }

        public bool RcvFinAck() => false;

        public bool RcvSyn() => false;

        public bool RcvSynAck() => false;
    }
}
