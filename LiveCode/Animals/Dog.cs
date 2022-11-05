namespace LiveCode.Animals
{
    using System.Collections.Generic;

    internal class Dog : Animal
    {
        private const int points = 10;

        public Dog() : base(points)
        {

        }

        protected override void Diet()
        {
            Foods.AddRange(new List<string>()
            {
                "Meat",
                "Bones"
            });
        }
    }
}
