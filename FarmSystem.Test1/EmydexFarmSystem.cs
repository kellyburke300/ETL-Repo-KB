using System;
using System.Collections.Generic;
using FarmSystem.Test1.Model;

namespace FarmSystem.Test1
{
    public class EmydexFarmSystem
    {
        public event EventHandler FarmEmpty;

        public Queue<Animal> animals = new Queue<Animal>();

        //TEST 1
        public void Enter(Animal animal)
        {
            animals.Enqueue(animal);
            Console.WriteLine(animal.GetType().Name + " has entered the Emydex farm");
        }
     
        //TEST 2
        public void MakeNoise()
        {
            foreach(Animal animal in animals)
            {
                Console.WriteLine(animal.Talk());
            }
        }

        //TEST 3
        public void MilkAnimals()
        {
            foreach (Animal animal in animals)
            {
                if (animal is IMilkableAnimal)
                {
                    Console.WriteLine((animal as IMilkableAnimal).ProduceMilk());
                }
            }
        }

        //TEST 4
        public void ReleaseAllAnimals()
        {
            while (animals.Count > 0)
            {
                Animal animal = animals.Dequeue();
                Console.WriteLine(animal.GetType().Name + " has exited the Emydex farm");
            }

            FarmEmpty?.Invoke(this, EventArgs.Empty);
        }
        
    }
}