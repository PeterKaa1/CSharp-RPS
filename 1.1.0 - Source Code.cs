using System;

namespace RockPaperScissors {
  class Program {
    static void Main(string[] args) {
      int wins = 0;
      int losses = 0;
      int gamesPlayed = 0;
      int round = 1;
      int hearts = 3;

      while (true) {
        Console.WriteLine("Round {0} of Rock, Paper, Scissors!", round);
        Console.WriteLine("Hearts: {0}", new string('❤', hearts));

        for (int i = 0; i < 5; i++) {
          string userChoice;
          int computerChoice;

          Console.WriteLine("Enter your choice (rock, paper, scissors, or exit): ");
          userChoice = Console.ReadLine().ToLower();

          if (userChoice == "exit") {
            Console.WriteLine("Thanks for playing Rock, Paper, Scissors! Goodbye!");
            return;
          }

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
              hearts--;
            } else {
              Console.WriteLine("Invalid choice. Please try again.");
            }
            break;
          case 2:
            if (userChoice == "rock") {
              Console.WriteLine("The computer chose paper. You lose!");
              losses++;
              hearts--;
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
              hearts--;
            } else if (userChoice == "scissors") {
              Console.WriteLine("The computer chose scissors. It's a tie!");
            } else {
              Console.WriteLine("Invalid choice. Please try again.");
            }
            break;
          }
          gamesPlayed++;

          if (hearts == 0) {
            Console.WriteLine("You have lost all your hearts, better luck next time!");
            return;
          }
        }

        Console.WriteLine("Games Played: {2}   Wins: {0}   Losses: {1}", wins, losses, gamesPlayed);
        Console.WriteLine("Thanks for playing round {0}! Press 'r' to restart and play the next round or any other key to exit.", round);
        string restart = Console.ReadLine().ToLower();
        if (restart != "r") {
          break;
        }
        Console.Clear();
        round++;
      }
    }
  }
}