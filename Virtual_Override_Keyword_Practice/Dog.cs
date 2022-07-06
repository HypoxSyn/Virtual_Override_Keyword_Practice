using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Override_Keyword_Practice
{
    class Dog: Animal
    {
        public bool IsHappy { get; set; }
        public Dog(string name, int age) : base(name,age)
        {
            IsHappy = true;
        }

        public virtual void Play()
        {
            Console.WriteLine($"{Name} is playing.");
        }



    }
}
