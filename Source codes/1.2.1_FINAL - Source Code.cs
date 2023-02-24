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
                        const int LowPitchedWinFrequency = 500;
                        const int LowPitchedLoseFrequency = 500;
                        const int LowPitchedTieFrequency = 500;
                        const int LowPitchedExitFrequency = 500;
                        const int LowPitchedInvalidChoiceFrequency = 500;
                        const int LowPitchedInvalidDifficultyChoiceFrequency = 500;
                        const int LowPitchedLostAllHeartsFrequency = 500;
                        const int LowPitchedPurchasedExtraHeartFrequency = 500;
                        const int LowPitchedNotEnoughCoinsFrequency = 500;
                        const int LowPitchedRestartFrequency = 500;
                        const int LowPitchedRoundEndFrequency = 500;
                        const int LowPitchedWouldYouLikeToBuyExtraHeartFrequency = 500;
                        const int LowPitchedHeartsCoinsInfoFrequency = 500;
                        const int LowPitchedRoundInfoFrequency = 500;

                        Console.WriteLine("Select a difficulty level. (type the number.): ");
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
                                Console.Beep(LowPitchedInvalidDifficultyChoiceFrequency, 500);
                                Vibration.Vibrate();
                                break;
                        }

                        while (true) {
                                Console.WriteLine("Round {0} of Rock, Paper, Scissors! (Difficulty: {1}.)", round, difficultyLevel);
                                Console.Beep(LowPitchedRoundInfoFrequency, 500);
                                Vibration.Vibrate();
                                Console.WriteLine("Hearts: {0}   Coins: {1}", new string('❤', hearts), coins);
                                Console.Beep(LowPitchedHeartsCoinsInfoFrequency, 500);
                                Vibration.Vibrate();
                                for (int i = 0; i < gamesPerRound; i++) {
                                        string userChoice;
                                        int computerChoice;

                                        Console.WriteLine("Enter your choice (rock, paper, scissors, or exit.): ");
                                        userChoice = Console.ReadLine().ToLower();

                                        if (userChoice == "exit") {
                                                Console.WriteLine("Thanks for playing Rock, Paper, Scissors! Goodbye!");
                                                Console.Beep(LowPitchedExitFrequency, 500);
                                                Vibration.Vibrate();
                                                return;
                                        }

                                        Random rnd = new Random();
                                        computerChoice = rnd.Next(1, 4);

                                        switch (computerChoice) {
                                        case 1:
                                                if (userChoice == "rock") {
                                                        Console.WriteLine("The computer chose rock. It's a tie!");
                                                        Console.Beep(LowPitchedTieFrequency, 500);
                                                        Vibration.Vibrate();
                                                } else if (userChoice == "paper") {
                                                        Console.WriteLine("The computer chose rock. You win!");
                                                        wins++;
                                                        coins += rnd.Next(1, 3);
                                                        Console.Beep(LowPitchedWinFrequency, 500);
                                                        Vibration.Vibrate();
                                                } else if (userChoice == "scissors") {
                                                        Console.WriteLine("The computer chose rock. You lose!");
                                                        losses++;
                                                        hearts--;
                                                        Console.Beep(LowPitchedLoseFrequency, 500);
                                                        Vibration.Vibrate();
                                                } else {
                                                        Console.WriteLine("Invalid choice. Please try again.");
                                                        Console.Beep(LowPitchedInvalidChoiceFrequency, 500);
                                                        Vibration.Vibrate();
                                                }
                                                break;
                                        case 2:
                                                if (userChoice == "rock") {
                                                        Console.WriteLine("The computer chose paper. You lose!");
                                                        losses++;
                                                        hearts--;
                                                        Console.Beep(LowPitchedLoseFrequency, 500);
                                                        Vibration.Vibrate();
                                                } else if (userChoice == "paper") {
                                                        Console.WriteLine("The computer chose paper. It's a tie!");
                                                        Console.Beep(LowPitchedTieFrequency, 500);
                                                        Vibration.Vibrate();
                                                } else if (userChoice == "scissors") {
                                                        Console.WriteLine("The computer chose paper. You win!");
                                                        wins++;
                                                        coins += rnd.Next(1, 3);
                                                        Console.Beep(LowPitchedWinFrequency, 500);
                                                        Vibration.Vibrate();
                                                } else {
                                                        Console.WriteLine("Invalid choice. Please try again.");
                                                        Console.Beep(LowPitchedInvalidChoiceFrequency, 500);
                                                        Vibration.Vibrate();
                                                }
                                                break;
                                        case 3:
                                                if (userChoice == "rock") {
                                                        Console.WriteLine("The computer chose scissors. You win!");
                                                        wins++;
                                                        coins += rnd.Next(1, 3);
                                                        Console.Beep(LowPitchedWinFrequency, 500);
                                                        Vibration.Vibrate();
                                                } else if (userChoice == "paper") {
                                                        Console.WriteLine("The computer chose scissors. You lose!");
                                                        losses++;
                                                        hearts--;
                                                        Console.Beep(LowPitchedLoseFrequency, 500);
                                                        Vibration.Vibrate();
                                                } else if (userChoice == "scissors") {
                                                        Console.WriteLine("The computer chose scissors. It's a tie!");
                                                        Console.Beep(LowPitchedTieFrequency, 500);
                                                        Vibration.Vibrate();
                                                } else {
                                                        Console.WriteLine("Invalid choice. Please try again.");
                                                        Console.Beep(LowPitchedInvalidChoiceFrequency, 500);
                                                        Vibration.Vibrate();
                                                }
                                                break;
                                        }
                                        gamesPlayed++;

                                        if (hearts == 0) {
                                                Console.WriteLine("You have lost all your hearts, better luck next time!");
                                                Console.Beep(LowPitchedLostAllHeartsFrequency, 500);
                                                Vibration.Vibrate();
                                                return;
                                        }
                                        Console.WriteLine("Would you like to buy an extra heart for 1 coin? (y/n).");
                                        Console.Beep(LowPitchedWouldYouLikeToBuyExtraHeartFrequency, 500);
                                        Vibration.Vibrate();
                                        string buyHeart = Console.ReadLine().ToLower();

                                        if (buyHeart == "y" && coins >= 2) {
                                                coins -= 2;
                                                hearts++;
                                                Console.WriteLine("You have purchased an extra heart! Hearts: {0}   Coins: {1}", new string('❤', hearts), coins);
                                                Console.Beep(LowPitchedPurchasedExtraHeartFrequency, 500);
                                                Vibration.Vibrate();
                                        } else if (buyHeart == "y" && coins < 10) {
                                                Console.WriteLine("You don't have enough coins to buy an extra heart. Hearts: {0}   Coins: {1}", new string('❤', hearts), coins);
                                                Console.Beep(LowPitchedNotEnoughCoinsFrequency, 500);
                                                Vibration.Vibrate();
                                        } else {
                                                Console.WriteLine("Hearts: {0}   Coins: {1}", new string('❤', hearts), coins);
                                                Console.Beep(LowPitchedHeartsCoinsInfoFrequency, 500);
                                                Vibration.Vibrate();
                                        }
                                }

                                Console.WriteLine("Games Played: {2}   Wins: {0}   Losses: {1}", wins, losses, gamesPlayed);
                                Console.WriteLine("Thanks for playing round {0}! Press 'r' to restart and play the next round or any other key to exit.", round);
                                Console.Beep(LowPitchedRoundEndFrequency, 500);
                                Vibration.Vibrate();
                                string restart = Console.ReadLine().ToLower();
                                if (restart != "r") {
                                        Console.Beep(LowPitchedRoundEndFrequency, 500);
                                        Vibration.Vibrate();
                                        break;
                                }
                                Console.Beep(LowPitchedRestartFrequency, 500);
                                Vibration.Vibrate();
                                Console.Clear();
                                round++;
                        }
                }
        }
}