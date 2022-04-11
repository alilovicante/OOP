using System;
using System.Collections.Generic;

namespace lv4
{
    class Program
    {
        static void Main(string[] args) { RunExercise2(); }
        static void RunExercise1()
        {
            double area=0, circumference=0;
            IShape[] shapes = new IShape[] { new Circle(4), new Circle(3), new Triangle(1, 2, 3), new Triangle(1, 4, 3) };
            for(int i = 0; i < 4; i++)
            {
                area += shapes[i].CalculateArea();
                circumference += shapes[i].CalculateCircumference();
            }
            Console.WriteLine($"Ukupna površina: {area}");
            Console.WriteLine($"Ukupan opseg: {circumference}");
        }
        static void RunExercise2()
        {
            List<int> numbers = new List<int>();
            Random generator = new Random();
            for(int i = 0; i <= 100; i++)
            {
                numbers.Add(generator.Next(-500, 501));
            }
            PrimeFilter primeFilter = new PrimeFilter();
            PerfectFilter perfectFilter = new PerfectFilter();
            List<int> primeNumbers = FilterNumbers(numbers, primeFilter);
            Console.WriteLine(primeNumbers.Count);
            List<int> perfectNumbers = FilterNumbers(numbers, perfectFilter);
            Console.WriteLine(perfectNumbers.Count);
        }
        static List<int> FilterNumbers(List<int> numbers, IIntegerFilter filter)
        {
            List<int> filteredNumbers = new List<int>();
            foreach(int number in numbers)
            {
                if(filter.IsValid(number)) { filteredNumbers.Add(number); Console.WriteLine(number); }
            }
            return filteredNumbers;
        }
        
    }
}
