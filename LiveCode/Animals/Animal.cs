namespace LiveCode.Animals
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public abstract class Animal
    {
        private string name;
        private int hitPoints;
        private const int maxHealth = 100;
        private List<string> diet;
        private const int caloriesToHealth = 10;

        public Animal(string name, List<string> diet)
        {
            Name = name;
            HitPoints = maxHealth;
            Diet = diet;
        }

        public string Name
        { 
            get => name;
            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name cannot be null or empty!");
                }
                this.name = value;
            }
        }

        public List<string> Diet
        {
            get => diet;
            private set
            {
                if (!value.Any())
                {
                    throw new ArgumentException("There should be at least somthing edible!");
                }
                diet = value;
            }
        }
        public int HitPoints
        {
            get => hitPoints;
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Health should be greater than zero!");
                }
                hitPoints = value;
            }
        }

        public void Feed(Food food)
        {
            if (hitPoints == maxHealth)
            {
                Console.WriteLine("I am not hungry at this moment");
                return;
            }
            else if (food == null)
            {
                throw new ArgumentException("I cannot eat nothing!");
            }
            else if (diet.Contains(food.Name))
            {
                hitPoints += food.Calories / caloriesToHealth;
                Console.WriteLine("Mmm.. Delicous!!!");
            }
            else
            {
                hitPoints -= food.Calories / caloriesToHealth;
                Console.WriteLine("This food is poisonous!");
            }
        }

        public abstract void Play();

        public override string ToString()
             => $"Name: {this.Name}{Environment.NewLine}Hit Points: {HitPoints}{Environment.NewLine}";
    }
}
