using System;

namespace BMIcalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name;");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age");
            int age = Int32.Parse(Console.ReadLine());
            if (age <= 20)
            {
                Console.WriteLine("You are too young");

            }
            else if (age >= 60)
            {
                Console.WriteLine("You are too old");
            }
            else
            {
                double height;
                Console.WriteLine("Enter your height in meters;");
                height = Double.Parse(Console.ReadLine());
                Console.WriteLine($"Your height is {height} meters");

                double weight;
                Console.WriteLine("Enter your weight");
                weight = Double.Parse(Console.ReadLine());
                Console.WriteLine($"Your weight is {weight} kg");

                double heights2 = height * height;
                double BMI = weight / heights2;
                Console.WriteLine(BMI);
                if (BMI <= 19)
                {
                    Console.WriteLine("you're skinny");
                }
                else if (BMI >= 25 && BMI <= 19)
                {
                    Console.WriteLine("You're healthy");
                }
                else if (BMI >= 30 && BMI <= 25)
                {
                    Console.WriteLine("You're overweight");
                }
                else if (BMI >= 30) 
                {
                    Console.WriteLine("You're obese");
                }





            }
            

            
               
            
            

        }
    }

}
            


        
    

