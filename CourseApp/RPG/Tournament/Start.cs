namespace CourseApp
{
    using System;

    public class Start
    {
        public int StartTheTournament(int tournamentParticipants)
        {
            Console.WriteLine("Введите количество участников турнира: ");
            tournamentParticipants = Convert.ToInt32(Console.ReadLine());
            while ((tournamentParticipants % 2 != 0) || (tournamentParticipants < 0))
            {
                Console.WriteLine("Введите корректное количество участников турнира(кратное двум и больше нуля!): ");
                tournamentParticipants = Convert.ToInt32(Console.ReadLine());
            }

            return tournamentParticipants;
        }
    }
}