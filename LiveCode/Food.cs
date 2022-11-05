namespace LiveCode
{
    using System;

    public class Food
    {
        private string name;
        private int calories;

        public Food(string name, int calories)
        {
            Name = name;
            Calories = calories;
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name cannot be null or empty!");
                }

                name = value;
            }
        }

        public int Calories
        { 
            get => calories;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Calories cannot be negative number!");
                }

                calories = value;
            }
        }
    }
}
