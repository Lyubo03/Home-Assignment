namespace LiveCode.Animals
{
    using System.Collections.Generic;

    public class Monkey : Animal
    {
        private const int caloriesToBurnWhilePlaying = 25;

        public Monkey(string name, List<string> diet)
            : base(name, diet)
        {
        }

        public override void Play()
        {
            this.HitPoints -= caloriesToBurnWhilePlaying;
        }
    }
}
