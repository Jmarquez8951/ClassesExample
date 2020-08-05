using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExample.Animals
{
    class Llama
    {
        //auto-property
        public int Age { get; set; }
        public string Color { get; set; }
        public bool Spits { get; set; }

        public Llama(int age, string color)
        {
            Age = age;
            Color = color;
        }

    }
}
