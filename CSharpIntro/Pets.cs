using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntro
{
    public class Pet
    {
        public string Name { get; set; }
        public virtual void PetMe()
        {
            Console.WriteLine($"{Name} likes that");
        }
    }

    public class Dog : Pet
    {
        public override void PetMe()
        {
            Console.WriteLine($"{Name} likes that very much!");
        }
    }
}
