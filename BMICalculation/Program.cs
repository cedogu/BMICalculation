using System;

namespace BMICalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            double height, weight, bmi;
            Console.WriteLine("Enter Your Weight (kg)");
            weight = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Enter Your Height (cm)");
            height = Convert.ToDouble(Console.ReadLine());


            bmi = weight / (height * height);

            if (bmi <= 18.4)
            {
                Console.WriteLine("Body Mass Index: {0} Category: Underweight", bmi);
            }
            else if (bmi <= 24.9)
            {
                Console.WriteLine("Body Mass Index: {0} Category: Normal", bmi);
            }
            else if (bmi <= 29.9)
            {
                Console.WriteLine("Body Mass Index: {0} Category: Owerweight", bmi);
            }
            else if (bmi <= 34.9)
            {
                Console.WriteLine("Body Mass Index: {0} Category: Obese", bmi);
            }
            else if (bmi <= 44.9)
            {
                Console.WriteLine("Body Mass Index: {0} Category: Second Obese", bmi);
            }

            else if (bmi > 44.9)
            {
                Console.WriteLine("Body Mass Index: {0} Category: Over Obese", bmi);
            }

            Console.ReadKey();
        }
    }
}
