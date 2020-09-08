using System;
using System.Collections.Generic;
using System.Text;

namespace Don_Emilio_Chicken
{
    class Order
    {
        public string client { get; set; }
        public int combo { get; set; }
        public void setClient(string name)
        {
            client = name;
        }
        public void setCombo(int combon)
        {
            combo = combon;
        }
    }
}
