using System;

namespace RockPaperScissors {
  class Program {
    static void Main(string[] args) {
      int wins = 0;
      int losses = 0;
      int gamesPlayed = 0;

      while (true) {
        string userChoice;
        int computerChoice;

        Console.WriteLine("Rock, Paper, Scissors!");
        Console.WriteLine("Enter your choice (rock, paper, or scissors): ");
        userChoice = Console.ReadLine().ToLower();

        Random rnd = new Random();
        computerChoice = rnd.Next(1, 4);

        switch (computerChoice) {
        case 1:
          if (userChoice == "rock") {
            Console.WriteLine("The computer chose rock. It's a tie!");
          } else if (userChoice == "paper") {
            Console.WriteLine("The computer chose rock. You win!");
            wins++;
          } else if (userChoice == "scissors") {
            Console.WriteLine("The computer chose rock. You lose!");
            losses++;
          } else {
            Console.WriteLine("Invalid choice. Please try again.");
          }
          break;
        case 2:
          if (userChoice == "rock") {
            Console.WriteLine("The computer chose paper. You lose!");
            losses++;
          } else if (userChoice == "paper") {
            Console.WriteLine("The computer chose paper. It's a tie!");
          } else if (userChoice == "scissors") {
            Console.WriteLine("The computer chose paper. You win!");
            wins++;
          } else {
            Console.WriteLine("Invalid choice. Please try again.");
          }
          break;
        case 3:
          if (userChoice == "rock") {
            Console.WriteLine("The computer chose scissors. You win!");
            wins++;
          } else if (userChoice == "paper") {
            Console.WriteLine("The computer chose scissors. You lose!");
            losses++;
          } else if (userChoice == "scissors") {
            Console.WriteLine("The computer chose scissors. It's a tie!");
          } else {
            Console.WriteLine("Invalid choice. Please try again.");
          }
          break;
        }
        gamesPlayed++;

        Console.WriteLine("Games Played: {2}   Wins: {0}   Losses: {1}", wins, losses, gamesPlayed);
        Console.WriteLine("Thanks for playing! Press 'r' to restart or any other key to exit");
        string restart = Console.ReadLine().ToLower();
        if (restart != "r") {
          break;
        }
        Console.Clear();
      }
    }
  }
}
