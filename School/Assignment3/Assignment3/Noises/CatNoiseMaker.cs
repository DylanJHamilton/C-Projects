using System;

namespace PetsInterfaces
{
   public class CatNoiseMaker : MakeNoise
    {
        public void MakeNoise()
        {
            Console.WriteLine("Meow.");
        }
    }
}