namespace CourseApp
{
    using System;
    using System.Collections.Generic;

    public class ListParticipants
    {
        private readonly Random random = new Random();
        private readonly string[] arrayOfName = new string[10]
        {
            "Брон",
            "Дрэйкон",
            "Вистан",
            "Тазар",
            "Алкин",
            "Корбак",
            "Гервульф",
            "Бронхильд",
            "Мирланда",
            "Розик",
        };

        private List<Player> soldiers = new List<Player>();

        public List<Player> AddAtList(int tournamentParticipants)
        {
            while (soldiers.Count < tournamentParticipants)
            {
                switch (random.Next(0, 3))
                {
                    case 0:
                        soldiers.Add(new Archer(arrayOfName[random.Next(0, 10)], random.Next(100, 130), random.Next(10, 10)));
                        break;
                    case 1:
                        soldiers.Add(new Knight(arrayOfName[random.Next(0, 10)], random.Next(100, 130), random.Next(10, 10)));
                        break;
                    case 2:
                        soldiers.Add(new Mage(arrayOfName[random.Next(0, 10)], random.Next(100, 130), random.Next(10, 10)));
                        break;
                }
            }

            return soldiers;
        }
    }
}