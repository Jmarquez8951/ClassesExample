using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace ClassesExample.Animals
{
    class Llama
    {
        //auto-property
        public int Age { get; set; }
        //readonly property -- set only in constructor
        //public string Color { get; }

        //public property with a private setter -- can be set whenever, but only by the class that owns the property
        public string Color { get; private set; }
        public bool Spits { get; set; }

        public Llama(int age, string color)
        {
            Age = age;
            Color = color;
        }

        public void Dye(string color)
        {
            if (Age > 3)
            {
                Color = color;
            } else
            {
                DressUp("pajamas", "leopard");
            }
        }

        private void DressUp(string clothing, string style)
        {
            Console.WriteLine($"The {Color} llama is wearing {style} {clothing}");
        }

    }
}
