namespace CourseApp
{
    using System;
    using System.Collections.Generic;

    public class Arena
    {
        private readonly Random random = new Random();
        private Logger logger = new Logger();
        private List<Player> warriors = new List<Player>();
        private List<Player> winners = new List<Player>();
        private ListParticipants list = new ListParticipants();

        private int round = 1;

        private Fight fight = new Fight();

        public void Tournament(int tournamentParticipants)
        {
            warriors = list.AddAtList(tournamentParticipants);

            Logger.LoggerOutput("Бойцы предстоящего турнира прямо перед нами!");
            foreach (Player item in warriors)
            {
                Logger.LoggerOutput($"Боец {item.Name}, {item.ClassPlayer}");
            }

            Logger.LoggerOutput("Наш турнир «Боевая единица» начинается!");
            Logger.LoggerOutput($"Тур {round++}-й");
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
                    Logger.LoggerOutput($"И тааак бой! {warrior.ClassPlayer}  {warrior.Name} Протиив {warriorRival.ClassPlayer}  {warriorRival.Name} \n");
                    fight.Zaruba(warrior, warriorRival);
                    Console.WriteLine("\n");
                    if (warrior.Health <= 0)
                    {
                        Logger.LoggerOutput($"{warrior.ClassPlayer} {warrior.Name} потерпел(а) поражение и отправляется наблюдать за продолжением турнира :(");
                        warriorRival.ResetHealth();
                        warriors.Remove(warrior);
                        warriors.Remove(warriorRival);
                        winners.Add(warriorRival);
                    }
                    else
                    {
                        Logger.LoggerOutput($"{warriorRival.ClassPlayer} {warriorRival.Name} потерпел(а) поражение и отправляется наблюдать за продолжением турнира :(");
                        warrior.ResetHealth();
                        warriors.Remove(warrior);
                        warriors.Remove(warriorRival);
                        winners.Add(warrior);
                    }
                }

                if ((winners.Count >= 2) && (warriors.Count == 0))
                {
                    int randomWarriorFirst = random.Next(0, winners.Count);
                    int randomWarriorSecond = random.Next(0, winners.Count);
                    while (randomWarriorFirst == randomWarriorSecond)
                    {
                        randomWarriorSecond = random.Next(0, winners.Count);
                    }

                    Logger.LoggerOutput($"Тур {round++}-й");
                    Player warrior = winners[randomWarriorFirst];
                    Player warriorRival = winners[randomWarriorSecond];
                    Logger.LoggerOutput($"И тааак бой! {warrior.ClassPlayer}  {warrior.Name} Протиив {warriorRival.ClassPlayer}  {warriorRival.Name} \n");
                    fight.Zaruba(warrior, warriorRival);
                    if (warrior.Health <= 0)
                    {
                        Logger.LoggerOutput($"{warrior.ClassPlayer} {warrior.Name} потерпел(а) поражение и отправляется наблюдать за продолжением турнира :(");
                        warriorRival.ResetHealth();
                        winners.Remove(warrior);
                    }
                    else
                    {
                        Logger.LoggerOutput($"{warriorRival.ClassPlayer} {warriorRival.Name} потерпел(а) поражение и отправляется наблюдать за продолжением турнира :(");
                        warrior.ResetHealth();
                        winners.Remove(warriorRival);
                    }
                }
            }

            Logger.LoggerOutput($"И таак, вот он наш победитель! Победитель турнира - {winners[0].ClassPlayer} {winners[0].Name}!");
            Logger.LoggerOutput("Дамы и господа турнир окончен, всем спасибо!");
        }
    }
}
