using System;
using System.Collections.Generic;
using System.Text;

namespace Don_Emilio_Chicken
{
    class Cashier
    {
        public string client { get; set; }
        public int combo { get; set; }
        public void setClient(string name)
        {
            client = name;
        }
        public void setCombo(int combon)
        {
            combo=combon;
        }
        public void cleanTable(int tablenumber)
        {
            Console.WriteLine($"Limpiando mesa #{tablenumber}");
        }
    }
}
