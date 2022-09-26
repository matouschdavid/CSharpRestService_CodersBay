using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntro
{
    public class Pet
    {
        //Thats a property
        public string Name { get; set; }

        //Methods we want to override must be virtual
        public virtual void PetMe()
        {
            Console.WriteLine($"{Name} likes that");
        }
    }

    //: means extends or implements based on the context
    public class Dog : Pet
    {
        //override a method with the keyword override
        public override void PetMe()
        {
            //string interpolation
            Console.WriteLine($"{Name} likes that very much!");
        }
    }
}
