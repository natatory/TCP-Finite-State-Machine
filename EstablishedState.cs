using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCP_Finite_State_Machine
{
    class EstablishedState : ISimplisticTCPState
    {
        public string Name { get => "ESTABLISHED"; }
        private TCP tcpFSM;

        public EstablishedState(TCP tcpFSM)
        {
            this.tcpFSM = tcpFSM;
        }

        public bool AppClose()
        {
            tcpFSM.SetState(tcpFSM.finWait1State);
            return true;
        }

        public bool RcvFin()
        {
            tcpFSM.SetState(tcpFSM.closeWaitState);
            return true;
        }

        public bool AppActiveOpen() => false;

        public bool AppPassiveOpen() => false;

        public bool AppSend() => false;

        public bool AppTimeOut() => false;

        public bool RcvAck() => false;

        public bool RcvFinAck() => false;

        public bool RcvSyn() => false;

        public bool RcvSynAck() => false;
    }
}
