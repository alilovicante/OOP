using System;
using System.Collections.Generic;
using System.Text;

namespace lv5
{
    class Class1
    {
        static public void RunSimpleDemo()
        {
            int height = 0, weight = 0;
            try
            {
            Console.WriteLine("Please, enter your height [cm]:");
            height = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter your weight [kg]:");
            weight = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
            Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine($"H: {height}, W: {weight}");
                }
            Console.WriteLine("Thank you for using HealthApp.");
        }
    }
}
