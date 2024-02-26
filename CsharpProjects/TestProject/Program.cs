/*
if ipAddress consists of 4 numbers
and
if each ipAddress number has no leading zeroes
and
if each ipAddress number is in range 0 - 255

then ipAddress is valid

else ipAddress is invalid
*/

// string[] ipv4Input = {"107.31.1.5", "255.0.0.255", "555..0.555", "255...255"};
// string[] address;
// bool validLength = false;
// bool validZeroes = false;
// bool validRange = false;

// foreach (string ip in ipv4Input) 
// {   
//     address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

//     ValidateLength(); 
//     ValidateZeroes(); 
//     ValidateRange();

//     if (validLength && validZeroes && validRange) 
//     {
//         Console.WriteLine($"{ip} is a valid IPv4 address");
//     } 
//     else 
//     {
//         Console.WriteLine($"{ip} is an invalid IPv4 address");
//     }
// }

// void ValidateLength() 
// {
//     validLength = address.Length == 4;
// };

// void ValidateZeroes() 
// {
//     foreach (string number in address) 
//     {
//         if (number.Length > 1 && number.StartsWith("0")) 
//         {
//             validZeroes = false;
//             return;
//         }
//     }

//     validZeroes = true;
// }

// void ValidateRange() 
// {
//     foreach (string number in address) 
//     {
//         if (int.Parse(number) > 255) 
//         {
//             validRange = false;
//             return;
//         }
//     }
//     validRange = true;
// }

//Exercise - Methods with optional parameters
// string[] guestList = {"Rebecca", "Nadia", "Noor", "Jonte"};
// string[] rsvps = new string[10];
// int count = 0;

// RSVP("Rebecca");
// RSVP("Nadia", 2, "Nuts");
// RSVP(name: "Linh", partySize: 2, inviteOnly: false);
// RSVP("Tony", allergies: "Jackfruit", inviteOnly: true);
// RSVP("Noor", 4, inviteOnly: false);
// RSVP("Jonte", 2, "Stone fruit", false);
// ShowRSVPs();

// void RSVP(string name, int partySize = 1, string allergies = "none", bool inviteOnly = true)
// {
//     if (inviteOnly)
//     {
//         bool found = false;
//         foreach (string guest in guestList)
//         {
//             if (guest.Equals(name)) {
//                 found = true;
//                 break;
//             }
//         }
//         if (!found)
//         {
//             Console.WriteLine($"Sorry, {name} is not on the guest list");
//             return;
//         }
//     }

//     rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
//     count++;
// }

// void ShowRSVPs()
// {
//     Console.WriteLine("\nTotal RSVPs:");
//     for (int i = 0; i < count; i++)
//     {
//         Console.WriteLine(rsvps[i]);
//     }
// }
// int target = 30;
// int[] coins = new int[] {5, 5, 50, 25, 25, 10, 5};
// int[,] result = TwoCoins(coins, target);

// if (result.Length == 0) 
// {
//     Console.WriteLine("No two coins make change");
// } 
// else 
// {
//     Console.WriteLine("Change found at positions:");
//     for (int i = 0; i < result.GetLength(0); i++) 
//     {
//         if (result[i,0] == -1) 
//         {
//             break;
//         }
//         Console.WriteLine($"{result[i,0]},{result[i,1]}");
//     }
// }

// int[,] TwoCoins(int[] coins, int target) 
// {
//     int[,] result = {{-1,-1},{-1,-1},{-1,-1},{-1,-1},{-1,-1}};
//     int count = 0;

//         for (int curr = 0; curr < coins.Length; curr++) 
//     {
//         for (int next = curr + 1; next < coins.Length; next++) 
//         {
//             if (coins[curr] + coins[next] == target) 
//             {
//                 result[count, 0] = curr;
//                 result[count, 1] = next;
//                 count++;
//             }
//             if (count == result.GetLength(0)) 
//             {
//                 return result;
//             }
//         }
//     }
//     if (count == 0) 
//     {
//         return new int[0,0];
//     }
//     return result;
// }
// Random random = new Random();

// Console.WriteLine("Would you like to play? (Y/N)");
// if (ShouldPlay(Console.ReadLine()))
// {
//     PlayGame();
// }

// bool ShouldPlay(string answer)
// {
//     return answer.ToLower() == "y" ? true : false;
// }

// string WinOrLose(int target, int roll)
// {
//     return roll > target ? "You Win!" : "You Lost!";
// }

// void PlayGame() 
// {
//     var play = true;

//     while (play) 
//     {
//         var target = random.Next(1, 6);
//         var roll = random.Next(1, 7);

//         Console.WriteLine($"Roll a number greater than {target} to win!");
//         Console.WriteLine($"You rolled a {roll}");
//         Console.WriteLine(WinOrLose(target, roll));
//         Console.WriteLine("\nPlay again? (Y/N)");

//         play = ShouldPlay(Console.ReadLine());
//     }
// }

//Create a math game using the four operations
//It must show a menu asking the user to choose an operation
//The results from division should result in INTERGERS ONLY, and dividends should go from 0 to 100
//Example: Your app shouldn't present the division 7/2 to the user, since it doesn't result in an integer.
//A random operation is showed to the user and he has to type an answer
//Record previous games in a list and have an option to visualize the history of previous games on the menu

//Challenges to do:
//Add dates and time
//Add a timer to track how long the user takes to finish the game.
//Add a function that let's the user pick the number of questions.
//Create a 'Random Game' option where the players will be presented with questions from random operations.
//Try to implement levels of difficulty. (Maybe)

// string menuSelection;
// string readAnswer;
// int userAnswer;
// List<string> answerList = new List<string>();
// int x;
// int y;
// int result;
// int scoreRight = 0;
// int totalScore = 0;
// string question;

// Random random = new Random();

// do
// {
//     Console.WriteLine("""
//     Math Game
//     Choose from the options below:
//     1 - Sum
//     2 - Subtraction
//     3 - Multiplication
//     4 - Division
//     5 - Visualise your previous games
//     exit to end the game
//     """);

//     menuSelection = Console.ReadLine();

//     switch (menuSelection)
//     {
//         case "1":
//         PlayGame("+", Sum);
//         break;
//         case "2":
//         PlayGame("-", Subtraction);
//         break;
//         case "3":
//         PlayGame("*", Multiplication);
//         break;
//         case "4":
//         PlayGame("/", Division);
//         break;
//         case "5":
//         VisualizePreviousGames();
//         Console.WriteLine($"\nYou final score is {scoreRight}/{totalScore}");
//         Console.WriteLine("\nPress Enter to continue...");
//         Console.ReadLine();
//         break;
//     }
            
// } while (menuSelection.ToLower() != "exit");

// int Sum(int x, int y)
// {   
//     return x + y;
// }
// int Subtraction(int x, int y)
// {   
//     return x - y;
// }
// int Multiplication(int x, int y)
// {   
//     return x * y;
// }

// int Division(int x, int y)
// {   
//     return x / y;
// }

// void VisualizePreviousGames()
// {
//     Console.WriteLine();
//     foreach (string item in answerList)
//     {
//         Console.WriteLine($"{item} ");
//     }
// }

// //The Func<int, int, int> delegate type indicates a method that takes two int parameters and returns an int.
// //The first 'int' is the return type, the second and third int are the first and second parameter

// void PlayGame(string operatorName, Func<int, int, int> operationFunction)
// {
//     do
//     {   

//         Console.WriteLine("Type 'b' to go back to the menu");

//         x = random.Next(0, 101);

//         if (operationFunction == Division)
//         {
//             do
//             {
//                 y = random.Next(1, 101);
//             } while (x % y != 0);
//         } else
//         {
//             y = random.Next(0, 101);
//         }

//         result = operationFunction(x, y);
//         question = $"{x} {operatorName} {y} = ?";
//         Console.WriteLine(question);
//         readAnswer = Console.ReadLine();

//         while (readAnswer.ToLower() != "b" && !int.TryParse(readAnswer, out userAnswer))
//         {
//             Console.WriteLine("Type a valid integer or 'b' to go back to the menu");
//             readAnswer = Console.ReadLine();
//         }
        
//         if (readAnswer.ToLower() != "b")
//         {
//             answerList.Add(HistoryOfGames(question, int.Parse(readAnswer), result));
//         }

//     } while (readAnswer.ToLower() != "b");
// }

// string HistoryOfGames(string question, int answer, int result)
// {   
//     string historyOfGames = question;
//     if (answer == result)
//     {
//         historyOfGames += $"\n{result} is the answer. You got it right!";
//         scoreRight++;
//         totalScore++;
//     } else
//     {
//         historyOfGames += $"\n{result} is the correct answer. You wrote {answer}.";
//         totalScore++;
//     }
//     return historyOfGames;
// }

