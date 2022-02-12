namespace CourseApp
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            int tournamentParticipants = 0;
            Game start = new Game();
            tournamentParticipants = start.StartTournament(tournamentParticipants);
            Arena arena = new Arena();
            arena.Tournament(tournamentParticipants);
            Console.ReadLine();
        }
    }
}