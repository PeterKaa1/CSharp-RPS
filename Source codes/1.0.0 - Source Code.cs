using System;

namespace RockPaperScissors {
  class Program {
    static void Main(string[] args) {
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
        } else if (userChoice == "scissors") {
          Console.WriteLine("The computer chose rock. You lose!");
        } else {
          Console.WriteLine("Invalid choice. Please try again.");
        }
        break;
      case 2:
        if (userChoice == "rock") {
          Console.WriteLine("The computer chose paper. You lose!");
        } else if (userChoice == "paper") {
          Console.WriteLine("The computer chose paper. It's a tie!");
        } else if (userChoice == "scissors") {
          Console.WriteLine("The computer chose paper. You win!");
        } else {
          Console.WriteLine("Invalid choice. Please try again.");
        }
        break;
      case 3:
        if (userChoice == "rock") {
          Console.WriteLine("The computer chose scissors. You win!");
        } else if (userChoice == "paper") {
          Console.WriteLine("The computer chose scissors. You lose!");
        } else if (userChoice == "scissors") {
          Console.WriteLine("The computer chose scissors. It's a tie!");
        } else {
          Console.WriteLine("Invalid choice. Please try again.");
        }
        break;
      }

      Console.WriteLine("Thanks for playing!");
      Console.ReadLine();
    }
  }
}