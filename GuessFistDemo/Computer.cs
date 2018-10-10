using System;

namespace GuessFistDemo
{
    public class Computer
    {
        public Random _random = new Random();

        public Computer()
        {
        }

        public Computer(Random random)
        {
            _random = random;
        }

        public int Computer_choice(int seeds)
        {
            return _random.Next(seeds);
        }

    }
}