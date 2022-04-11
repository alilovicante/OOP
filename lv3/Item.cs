using System;
using System.Collections.Generic;
using System.Text;

namespace lv3
{
    public class Item
    {
        private string name;
        private double weight;
        private double worth;

        public Item(string name, double weight, double worth)
        {
            this.name = name;
            this.weight = weight;
            this.worth = worth;
        }
        public string Name{ get { return this.name; } private set { this.name = value; } }
        public double Weight { get { return this.weight; } private set { this.weight = value; } }
        public double Worth { get { return this.worth; } private set { this.worth = value; } }

        public override string ToString()
        {
            return  name + weight + worth;
        }
        public static double AvgValue(Item[] items)
        {
            double sum = 0;
            int counter = 0;
            for(int i = 0; i < items.Length; i++)
            {
                sum += items[i].worth;
                counter++;
            }
            return sum / counter;
        }
    }
    public class Sword : Item
    {
        public double strenght;
        public Sword(string name,double weight,double worth,double strenght) : base(name, weight, worth)
        {
            this.strenght = strenght;
        }
        public double Strenght { get { return strenght; } private set { this.strenght = value; } }
        public override string ToString()
        {
            return "Sword " + Name+ " " + Weight +" "+ Worth+" "+Strenght; 
        }

    }
    public class Shield : Item
    {
        public double armour;
        public Shield(string name, double weight, double worth, double armour) : base(name, weight, worth)
        {
            this.armour = armour;
        }
        public double Armour { get { return armour; } private set { this.armour = value; } }
        public override string ToString()
        {
            return "Shield " + Name + " " + Weight + " " + Worth+" "+Armour;
        }
        
    }
}
