using System;
using System.Collections.Generic;
using System.Text;

namespace sisfolha.Entidades {
    class OutsourceEmploee : Employee{
        public double AdditionalCharge {
            get; set;
        }

        public OutsourceEmploee() {
        
        }

        public OutsourceEmploee(string name, int hours, int valuePerHour, double additionalCharge) 
            :base(name, hours, valuePerHour) {

            AdditionalCharge = additionalCharge;
        }

        public override double Payment() {
            return base.Payment() + 1.1 * AdditionalCharge; 
        }

    }
}
