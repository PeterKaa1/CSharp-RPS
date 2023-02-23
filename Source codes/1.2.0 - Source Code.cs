using System;
using Xamarin.Essentials;

namespace RockPaperScissors {
  class Program {
    static void Main(string[] args) {
      int wins = 0;
      int losses = 0;
      int round = 1;
      int gamesPlayed = 0;
      int gamesPerRound = 10;
      int hearts = 3;
      int coins = 0;
      const int HighPitchWinFrequency = 1000;
      const int LowPitchLoseFrequency = 300;
      const int LowPitchTieFrequency = 600;

      Console.WriteLine("Select a difficulty level: ");
      Console.WriteLine("1) Easy");
      Console.WriteLine("2) Normal");
      Console.WriteLine("3) Hard");

      int difficultyLevel = int.Parse(Console.ReadLine());

      switch (difficultyLevel) {
      case 1:
        gamesPerRound = 5;
        hearts = 3;
        break;
      case 2:
        gamesPerRound = 10;
        hearts = 2;
        break;
      case 3:
        gamesPerRound = 15;
        hearts = 1;
        break;
      default:
        Console.WriteLine("Invalid difficulty level selected. Defaulting to Normal.");
        break;
      }

      while (true) {
        Console.WriteLine("Round {0} of Rock, Paper, Scissors! (Difficulty: {1})", round, difficultyLevel);
        Console.WriteLine("Hearts: {0}   Coins: {1}", new string('❤', hearts), coins);

        for (int i = 0; i < gamesPerRound; i++) {
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
              Console.Beep(LowPitchTieFrequency, 500);
              Vibration.Vibrate();
            } else if (userChoice == "paper") {
              Console.WriteLine("The computer chose rock. You win!");
              wins++;
              coins += rnd.Next(1, 3);
              Console.Beep(HighPitchWinFrequency, 500);
              Vibration.Vibrate();
            } else if (userChoice == "scissors") {
              Console.WriteLine("The computer chose rock. You lose!");
              losses++;
              hearts--;
              Console.Beep(LowPitchLoseFrequency, 500);
              Vibration.Vibrate();
            } else {
              Console.WriteLine("Invalid choice. Please try again.");
            }
            break;
          case 2:
            if (userChoice == "rock") {
              Console.WriteLine("The computer chose paper. You lose!");
              losses++;
              hearts--;
              Console.Beep(LowPitchLoseFrequency, 500);
              Vibration.Vibrate();
            } else if (userChoice == "paper") {
              Console.WriteLine("The computer chose paper. It's a tie!");
              Console.Beep(LowPitchTieFrequency, 500);
              Vibration.Vibrate();
            } else if (userChoice == "scissors") {
              Console.WriteLine("The computer chose paper. You win!");
              wins++;
              coins += rnd.Next(1, 3);
              Console.Beep(HighPitchWinFrequency, 500);
              Vibration.Vibrate();
            } else {
              Console.WriteLine("Invalid choice. Please try again.");
            }
            break;
          case 3:
            if (userChoice == "rock") {
              Console.WriteLine("The computer chose scissors. You win!");
              wins++;
              coins += rnd.Next(1, 3);
              Console.Beep(HighPitchWinFrequency, 500);
              Vibration.Vibrate();
            } else if (userChoice == "paper") {
              Console.WriteLine("The computer chose scissors. You lose!");
              losses++;
              hearts--;
              Console.Beep(LowPitchLoseFrequency, 500);
              Vibration.Vibrate();
            } else if (userChoice == "scissors") {
              Console.WriteLine("The computer chose scissors. It's a tie!");
              Console.Beep(LowPitchTieFrequency, 500);
              Vibration.Vibrate();
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
          Console.WriteLine("Would you like to buy an extra heart for 1 coin? (y/n)");
          string buyHeart = Console.ReadLine().ToLower();

          if (buyHeart == "y" && coins >= 2) {
            coins -= 2;
            hearts++;
            Console.WriteLine("You have purchased an extra heart! Hearts: {0}   Coins: {1}", new string('❤', hearts), coins);
          } else if (buyHeart == "y" && coins < 10) {
            Console.WriteLine("You don't have enough coins to buy an extra heart. Hearts: {0}   Coins: {1}", new string('❤', hearts), coins);
          } else {
            Console.WriteLine("Hearts: {0}   Coins: {1}", new string('❤', hearts), coins);
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