using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_1302210028
{
    internal class DoorMachine
    {
        public enum DoorState { Terbuka, Terkunci};
        public enum Trigger { BukaPintu, KunciPintu};

        class transition
        {
            public DoorState prevState;
            public DoorState nextState;
            public Trigger trigger; 

            public transition(DoorState prevState, DoorState nextState, Trigger trigger)
            {
                this.prevState = prevState;
                this.nextState = nextState;
                this.trigger = trigger;
            }
        }

        transition[] transitions =
        {
            new transition(DoorState.Terbuka, DoorState.Terbuka, Trigger.BukaPintu),
            new transition(DoorState.Terbuka, DoorState.Terkunci, Trigger.KunciPintu),
            new transition(DoorState.Terkunci, DoorState.Terkunci, Trigger.KunciPintu),
            new transition(DoorState.Terkunci, DoorState.Terbuka, Trigger.BukaPintu)
        };

        public DoorState currentState;

        public DoorState getNextState(DoorState prevState, Trigger trigger)
        {
            DoorState nextState = prevState;

            for (int i = 0; i < transitions.Length; i++)
            {
                if (transitions[i].prevState == prevState && transitions[i].trigger == trigger)
                {
                    nextState = transitions[i].nextState;
                }
            }
            return nextState;
        }

        public void activeTrigger(Trigger trigger)
        {
            DoorState nextState = getNextState(currentState, trigger);
            currentState = nextState;

        }
    }
}
