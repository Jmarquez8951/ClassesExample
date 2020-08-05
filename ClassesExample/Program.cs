using ClassesExample.Animals;
using System;

namespace ClassesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var chicken = new Chicken("Liza");
            var bob = new Chicken("Bob");

            chicken.Peck("corn");
            chicken.Peck("corn");
            chicken.Peck("corn");
            chicken.Peck("corn");

            bob.Peck();

            Console.WriteLine($"{chicken.Name} and {bob.Name} are chickens....");

            var llama = new Llama(3, "blue");
            llama.Dye("teal");

            //object initializer
            var cat = new Cat()
            {
                IsFeral = true,
                Color = CatColor.Tabby,
                BestFriend = bob
            };
            
            cat.Color = CatColor.Tabby;
            cat.Dye(CatColor.White);
            cat.BestFriend = bob;
            cat.HaveASnack();


            Console.WriteLine($"The cat is {cat.Color}.");
        }
    }
}

