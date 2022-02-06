namespace CourseApp
{
    using System;
    using System.Collections.Generic;

    public class Arena
    {
        private readonly Random random = new Random();

        private Logger logger = new Logger();
        private List<Factory> warriors = new List<Factory>();
        private List<Player> winners = new List<Player>();

        public void Tournament(int tournamentParticipants)
        {
            while (warriors.Count < tournamentParticipants)
            {
                switch (random.Next(0, 3))
                {
                    case 0:
                        warriors.Add(new ArcherFactory());
                        break;
                    case 1:
                        warriors.Add(new KnightFactory());
                        break;
                    case 2:
                        warriors.Add(new MageFactory());
                        break;
                }
            }

            Logger.LoggerOutput("Бойцы предстоящего турнира прямо перед нами!");
            foreach (Factory item in warriors)
            {
                Console.WriteLine(item);
            }

            Logger.LoggerOutput("Наш турнир «Боевая единица» начинается!");
            Logger.LoggerOutput("Тур 1-й");
            while (warriors.Count + winners.Count > 1)
            {
                if (warriors.Count >= 2)
                {
                    int randomWarriorFirst = random.Next(0, warriors.Count);
                    int randomWarriorSecond = random.Next(0, warriors.Count);
                    while (randomWarriorFirst == randomWarriorSecond)
                    {
                        randomWarriorSecond = random.Next(0, warriors.Count);
                    }

                    Factory warrior = warriors[randomWarriorFirst];
                    Factory warriorRival = warriors[randomWarriorSecond];
                }
            }
        }
    }
}