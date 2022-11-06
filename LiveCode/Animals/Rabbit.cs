namespace LiveCode.Animals
{
    using System.Collections.Generic;

    public class Rabbit : Animal
    {
        private const int caloriesToBurnWhilePlaying = 6;

        public Rabbit(string name, List<string> diet)
            : base(name, diet)
        {
        }

        public override void Play()
        {
            this.HitPoints -= caloriesToBurnWhilePlaying;
        }
    }
}
