namespace CourseApp
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            int tournamentParticipants = 0;
            Start start = new Start();
            tournamentParticipants = start.StartTheTournament(tournamentParticipants);
        }
    }
}
