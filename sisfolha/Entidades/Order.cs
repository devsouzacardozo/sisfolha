using System;
using sisfolha.Entidades.enums;

namespace sisfolha.Entidades {
    class Order {
        public int Id {
            get; set;
        }
        public DateTime Moment {
            get; set;
        }
        public OrdemStatus Status {
            get; set;
        }

        public override string ToString() {
            return Id 
                +", "
                + Moment
                +" , "
                + Status;
        }
    }
}
