using System;

namespace PetsInterfaces
{
    public class DogNoiseMaker : MakeNoise
    {
        public void MakeNoise()
        {
            Console.WriteLine("Woof! Woof!");
        }
    }
}