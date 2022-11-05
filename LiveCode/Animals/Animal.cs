namespace LiveCode.Animals
{
    using System.Collections.Generic;

    internal abstract class Animal
    {
        private int hitPoints;
        private List<Food> foods;

        public Animal(int hitPoints)
        {
            this.hitPoints = hitPoints;
            foods = new List<Food>();
        }

        public List<Food> Foods
        {
            get => foods;
            set
            {
                foods = value;
            }
        }
        protected int HitPoints
        {
            get => HitPoints;
            set
            {
                hitPoints = value;
            }
        }

        public void Feed(Food food)
        {
            if (foods.Contains(food))
            {
                hitPoints += 1;
            }
            else
            {
                hitPoints -= 1;
            }
        }
        protected abstract void Diet();
    }
}
