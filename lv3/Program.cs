using System;

namespace lv3
{
    class Program
    {
        static void Main(string[] args) { RunExercise1(); }
        static void RunExercise1()
        {
            ScoreCalculator kalkuliraj = new ScoreCalculator(0);
            CharScoreCalculator kalkulirajRijec = new CharScoreCalculator(0, 0);
            string rijec;
            int i,suma=0;
            for (i = 0; i < 3; i++)
            {
                do
                {
                    rijec = Console.ReadLine();
                    if (rijec.Length > 2)
                    {
                        suma += kalkuliraj.LenScore(rijec) + kalkulirajRijec.LenScore(rijec);
                    }
                } while (rijec.Length <= 2);
            }
            Console.WriteLine(suma);
        }
        static void RunExercise2()
        {
            Item[] items = {new Sword("Longsword", 10, 150, 50), new Sword("Dagger", 10, 143, 50), new Shield("Wood Shield", 10, 543, 50), new Shield("Iron Shield", 10, 653, 50), new Shield("Roman Shield", 10, 765, 50)};
            Console.WriteLine(Item.AvgValue(items));
            int i;
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine(items[i].ToString());
            }
        }
    }
}
