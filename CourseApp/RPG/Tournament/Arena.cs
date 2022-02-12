namespace CourseApp
{
    using System;
    using System.Collections.Generic;

    public class Arena
    {
        private readonly Random random = new Random();
        private Logger logger = new Logger();
        private List<Player> soldiers = new List<Player>();
        private List<Player> winners = new List<Player>();
        private ListParticipants list = new ListParticipants();

        private int round = 1;

        private Fight fight = new Fight();

        public void Tournament(int tournamentParticipants)
        {
            soldiers = list.AddAtList(tournamentParticipants);

            Logger.LoggerOutput("Бойцы:");
            foreach (Player item in soldiers)
            {
                Logger.LoggerOutput($"Боец {item.Name} - {item.ClassPlayer}");
            }

            Logger.LoggerOutput("Турнир начинается!");
            Logger.LoggerOutput($"Раунд {round++}-й");
            while (soldiers.Count + winners.Count > 1)
            {
                if (soldiers.Count >= 2)
                {
                    int randomSoldierFirst = random.Next(0, soldiers.Count);
                    int randomSoldierSecond = random.Next(0, soldiers.Count);
                    while (randomSoldierFirst == randomSoldierSecond)
                    {
                        randomSoldierSecond = random.Next(0, soldiers.Count);
                    }

                    Player soldier = soldiers[randomSoldierFirst];
                    Player soldierRival = soldiers[randomSoldierSecond];
                    Logger.LoggerOutput($"Бой начинается: {soldier.ClassPlayer}  {soldier.Name} против {soldierRival.ClassPlayer}  {soldierRival.Name} \n");
                    fight.Zaruba(soldier, soldierRival);
                    Console.WriteLine("\n");
                    if (soldier.Health <= 0)
                    {
                        Logger.LoggerOutput($"{soldier.ClassPlayer} {soldier.Name} потерпел поражение и выбывает из турнира!");
                        soldierRival.ResetHealth();
                        soldiers.Remove(soldier);
                        soldiers.Remove(soldierRival);
                        winners.Add(soldierRival);
                    }
                    else
                    {
                        Logger.LoggerOutput($"{soldierRival.ClassPlayer} {soldierRival.Name} потерпел поражение и выбывает из турнира!");
                        soldier.ResetHealth();
                        soldiers.Remove(soldier);
                        soldiers.Remove(soldierRival);
                        winners.Add(soldier);
                    }
                }

                if ((winners.Count >= 2) && (soldiers.Count == 0))
                {
                    int randomSoldierFirst = random.Next(0, winners.Count);
                    int randomSoldierSecond = random.Next(0, winners.Count);
                    while (randomSoldierFirst == randomSoldierSecond)
                    {
                        randomSoldierSecond = random.Next(0, winners.Count);
                    }

                    Logger.LoggerOutput($"Тур {round++}-й");
                    Player soldier = winners[randomSoldierFirst];
                    Player soldierRival = winners[randomSoldierSecond];
                    Logger.LoggerOutput($"Бой начинается: {soldier.ClassPlayer}  {soldier.Name} против {soldierRival.ClassPlayer}  {soldierRival.Name} \n");
                    fight.Zaruba(soldier, soldierRival);
                    if (soldier.Health <= 0)
                    {
                        Logger.LoggerOutput($"{soldier.ClassPlayer} {soldier.Name} потерпел поражение и выбывает из турнира!");
                        soldierRival.ResetHealth();
                        winners.Remove(soldier);
                    }
                    else
                    {
                        Logger.LoggerOutput($"{soldierRival.ClassPlayer} {soldierRival.Name} потерпел поражение и выбывает из турнира!");
                        soldier.ResetHealth();
                        winners.Remove(soldierRival);
                    }
                }
            }

            Logger.LoggerOutput($"Победитель турнира - {winners[0].ClassPlayer} {winners[0].Name}!");
            Logger.LoggerOutput("Турнир окончен!");
        }
    }
}