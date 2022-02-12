namespace CourseApp
{
    using System;
    using System.Collections.Generic;

    public class Fight
    {
        private readonly Random random = new Random();
        private int counterOne = 0;
        private int counterTwo = 0;

        public Tuple<Player, Player> Zaruba(Player soldier, Player soldierRival)
        {
            while ((soldier.Health > 0) && (soldierRival.Health > 0))
            {
                if ((random.Next(1, 5) == 1) && (soldier.Effect == false) && (counterOne != 1))
                {
                    counterOne = 1;
                    soldier.Effect = true;
                }

                if ((random.Next(1, 5) == 2) && (soldierRival.Effect == false) && (counterTwo != 2))
                {
                    counterTwo = 2;
                    soldierRival.Effect = true;
                }

                if ((soldier.Afk > 0) && (soldier.Health > 0))
                {
                    Logger.LoggerOutput($"{soldier.Name} пропускает свой ход.");
                    soldier.Afk--;
                }
                else if (soldier.Health > 0)
                {
                    soldierRival.Damage(soldier.Attack(soldier, soldierRival));
                    Logger.LoggerOutput($"{soldierRival.Name} теряет {soldier.InfoAboutDamage} здоровье от удара {soldier.Name}!");
                }

                if ((soldierRival.Afk > 0) && (soldierRival.Health > 0))
                {
                    Logger.LoggerOutput($"{soldierRival.Name} пропускает свой ход.");
                    soldierRival.Afk--;
                }
                else if (soldierRival.Health > 0)
                {
                    soldier.Damage(soldierRival.AttackAntagonist(soldier, soldierRival));
                    Logger.LoggerOutput($"{soldier.Name} теряет {soldierRival.InfoAboutDamage} здоровье от удара {soldierRival.Name}!");
                }
            }

            counterOne = 0;
            counterTwo = 0;
            return new Tuple<Player, Player>(soldier, soldierRival);
        }
    }
}