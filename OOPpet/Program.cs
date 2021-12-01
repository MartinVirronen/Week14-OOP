using System;

namespace ClassCat
{
    class Program
    {
        class Pet
        {
            string name;
            int age;
            double weight;

            public Pet(string _name) 
            {
                name = _name;
                age = 0;
                weight = 0.1;
                Console.WriteLine($"Congratz. You've adopted {name}!");
            }

            public double Weight
            {
                get
                { return weight; }
            }

            public void ShowPetInfo()
            {
                Console.WriteLine($"name:{name}");
                Console.WriteLine($"age:{age}");
                Console.WriteLine($"fatness:{weight}");
            }
           
            public void Eat()
            {
                weight += 0.2; 
                Console.WriteLine("amps-amps");
            }
            public void run()
            {
                weight -= 0.1;
                Console.WriteLine("huh-huh-huh");
            }

           
        }


        static void Main(string[] args)
        {
            Pet myPet = new Pet("Siim");
            myPet.ShowPetInfo();
            for (int i = 0; i < 10; i++)
            {
                myPet.Eat();
                Console.WriteLine($"current fatness : {myPet.Weight}");
                if (myPet.Weight >= 0.7)
                {

                    while (myPet.Weight > 0.7)
                    {
                        myPet.run();
                        Console.WriteLine($"fatness after workout : {myPet.Weight}");
                    }

                }

            }
        }
    }
}