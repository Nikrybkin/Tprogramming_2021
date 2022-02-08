namespace CourseApp
{
    using System;
    using System.Collections.Generic;

    public class ListParticipants
    {
        private readonly Random random = new Random();
        private readonly string[] arrayOfName = new string[20]
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

        private List<Player> warriors = new List<Player>();

        public List<Player> AddAtList(int tournamentParticipants)
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

            return warriors;
        }
    }
}