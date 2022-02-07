namespace CourseApp
{
    using System;
    using System.Collections.Generic;

    public class Fight
    {
        private readonly Random random = new Random();
        private int counterOne = 0;
        private int counterTwo = 0;

        public Tuple<Player, Player> Zaruba(Player warrior, Player warriorRival)
        {
            while ((warrior.Health > 0) && (warriorRival.Health > 0))
            {
                if ((random.Next(1, 5) == 1) && (warrior.Effect == false) && (counterOne != 1))
                {
                    counterOne = 1;
                    warrior.Effect = true;
                }

                if ((random.Next(1, 5) == 2) && (warriorRival.Effect == false) && (counterTwo != 2))
                {
                    counterTwo = 2;
                    warriorRival.Effect = true;
                }

                if ((warrior.Afk > 0) && (warrior.Health > 0))
                {
                    Logger.LoggerOutput($"{warrior.Name} не в состоянии нанести удар и пропускает ход!");
                    warrior.Afk--;
                }
                else if (warrior.Health > 0)
                {
                    warriorRival.GetDamage(warrior.AtTheAttackWarrior(warrior, warriorRival));
                    Logger.LoggerOutput($"{warriorRival.Name} теряет {warrior.DamageInfo} хп от удара {warrior.Name}!");
                }

                if ((warriorRival.Afk > 0) && (warriorRival.Health > 0))
                {
                    Logger.LoggerOutput($"{warriorRival.Name} не в состоянии нанести удар и пропускает ход!");
                    warriorRival.Afk--;
                }
                else if (warriorRival.Health > 0)
                {
                    warrior.GetDamage(warriorRival.AtTheAttackWarriorRival(warrior, warriorRival));
                    Logger.LoggerOutput($"{warrior.Name} теряет {warriorRival.DamageInfo} хп от удара {warriorRival.Name}!");
                }
            }

            counterOne = 0;
            counterTwo = 0;
            return new Tuple<Player, Player>(warrior, warriorRival);
        }
    }
}