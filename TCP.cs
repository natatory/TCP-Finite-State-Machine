using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCP_Finite_State_Machine
{
    class TCP
    {
        private static ISimplisticTCPState currentState;
        public ISimplisticTCPState closedState { get; private set; }
        public ISimplisticTCPState closeWaitState { get; private set; }
        public ISimplisticTCPState closingState { get; private set; }
        public ISimplisticTCPState establishedState { get; private set; }
        public ISimplisticTCPState finWait1State { get; private set; }
        public ISimplisticTCPState finWait2State { get; private set; }
        public ISimplisticTCPState lastAckState { get; private set; }
        public ISimplisticTCPState listenState { get; private set; }
        public ISimplisticTCPState synRcvdState { get; private set; }
        public ISimplisticTCPState synSenState { get; private set; }
        public ISimplisticTCPState timeWaitState { get; private set; }

        public TCP()
        {
            closedState = new ClosedState(this);
            closeWaitState = new CloseWaitState(this);
            closingState = new ClosingState(this);
            establishedState = new EstablishedState(this);
            finWait1State = new FinWait1State(this);
            finWait2State = new FinWait2State(this);
            lastAckState = new LastAckState(this);
            listenState = new ListenState(this);
            synRcvdState = new SynRcvdState(this);
            synSenState = new SynSentState(this);
            timeWaitState = new TimeWaitState(this);
            currentState = closedState;
        }
        public void SetState(ISimplisticTCPState state)
        {
            currentState = state;
        }
        public static string TraverseStates(string[] events)
        {
            TCP myTCP = new TCP();
            foreach (string myEvent in events)
            {
                switch (myEvent)
                {
                    case "APP_PASSIVE_OPEN":
                        if (!currentState.AppPassiveOpen()) return "ERROR";
                        break;
                    case "APP_ACTIVE_OPEN":
                        if (!currentState.AppActiveOpen()) return "ERROR";
                        break;
                    case "APP_SEND":
                        if (!currentState.AppSend()) return "ERROR";
                        break;
                    case "APP_CLOSE":
                        if (!currentState.AppClose()) return "ERROR";
                        break;
                    case "APP_TIMEOUT":
                        if (!currentState.AppTimeOut()) return "ERROR";
                        break;
                    case "RCV_SYN":
                        if (!currentState.RcvSyn()) return "ERROR";
                        break;
                    case "RCV_ACK":
                        if (!currentState.RcvAck()) return "ERROR";
                        break;
                    case "RCV_SYN_ACK":
                        if (!currentState.RcvSynAck()) return "ERROR";
                        break;
                    case "RCV_FIN":
                        if (!currentState.RcvFin()) return "ERROR";
                        break;
                    case "RCV_FIN_ACK":
                        if (!currentState.RcvFinAck()) return "ERROR";
                        break;
                    default: return "ERROR";
                }
            }
            return currentState.Name;
        }

    }
}
