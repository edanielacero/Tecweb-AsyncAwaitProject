using System;
using System.Collections.Generic;
using System.Text;

namespace Don_Emilio_Chicken
{
    public class Combo<T>
    {
        public T ID { get; set; }
        public Chicken chicken { get; set; }
        public Drink drink { get; set; }
    }
}
