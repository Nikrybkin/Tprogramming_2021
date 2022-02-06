namespace CourseApp
{
    using System;
    using System.Collections.Generic;

    public class Arena
    {
        private readonly Random random = new Random();
        private string[] arrayOfName = new string[20]
        {
            "Мерлин",
            "Геральт",
            "Эльдайн",
            "Кейра",
            "Мортра",
            "Виллентретенмерт",
            "Алёшка",
            "Шон",
            "Рикки",
            "Кирито",
            "Иоверт",
            "Ширру",
            "Керис",
            "Хьялмар",
            "Имлерих",
            "Эредин",
            "Кольгрим",
            "Весемир",
            "Лидия",
            "Фукусья",
        };

        private Logger logger = new Logger();
        private List<Player> warriors = new List<Player>();
        private List<Player> winners = new List<Player>();

        public void Tournament(int tournamentParticipants)
        {
            while (warriors.Count < tournamentParticipants)
            {
                switch (random.Next(0, 3))
                {
                    case 0:
                        warriors.Add(new Archer(arrayOfName[random.Next(0, 20)], random.Next(100, 130), random.Next(10, 20)));
                        break;
                    case 1:
                        warriors.Add(new Knight(arrayOfName[random.Next(0, 20)], random.Next(100, 130), random.Next(10, 20)));
                        break;
                    case 2:
                        warriors.Add(new Mage(arrayOfName[random.Next(0, 20)], random.Next(100, 130), random.Next(10, 20)));
                        break;
                }
            }

            Logger.LoggerOutput("Бойцы предстоящего турнира прямо перед нами!");
            foreach (Player item in warriors)
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

                    Player warrior = warriors[randomWarriorFirst];
                    Player warriorRival = warriors[randomWarriorSecond];
                }
            }
        }
    }
}