using System;

namespace PetsInterfaces
{
    class Animal : MakeNoise, GenerateHeat
    {
        public string Name { get; set; }
        public MakeNoise noiseMaker { get; set; }
        public GenerateHeat generator { get; set; }

        public Animal(string Name, MakeNoise noiseMaker, GenerateHeat generator)
        {
            this.Name = Name;
            this.noiseMaker = noiseMaker;
            this.generator = generator;
        }

        public void MakeNoise() { this.noiseMaker.MakeNoise(); }
        public void GenerateHeat() { this.generator.GenerateHeat(); }
    }
}