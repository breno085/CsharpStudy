// ?: is the condicional operator, also know as the ternary condicional operator
// <evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>

// int saleAmount = 1001;
// // int discount = saleAmount > 1000 ? 100 : 50;
// Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

// Random coin = new Random();
// int flip = coin.Next(1, 3);
// Console.WriteLine($"Result: {(flip > 1 ? "tails" : "heads")}");

// string permission = "Admin|Manager";
// int level = 55;

// if (permission.Contains("Admin"))
//     Console.WriteLine(level > 55 ? "Welcome, Super Admin user." : "Welcome, Admin user");
// else if (permission.Contains("Manager"))
//     Console.WriteLine(level >= 20 ? "Contact an Admin for access." : "You do not have sufficient privileges.");
// else
//     Console.WriteLine("You do not have sufficient privileges.");

// int heroHealth = 10;
// int monsterHealth = 10;
// int damage = 0;

// Random atack = new Random();

// while (true)
// {   
//     if (heroHealth > 0)
//     {   damage = atack.Next(1, 11);
//         monsterHealth -= damage;
//         Console.WriteLine($"Monster was damaged and lost {damage} health and now has {monsterHealth} health");
//     } else
//     {   Console.WriteLine("Monster Wins!");
//         break;
//     }
//     if (monsterHealth > 0)
//     {   damage = atack.Next(1, 11);
//         heroHealth -= damage;
//         Console.WriteLine($"Hero was damaged and lost {damage} health and now has {heroHealth} health");
//     } else
//     {   Console.WriteLine("Hero Wins!");
//         break;
//     }

// }

//Code project 1 - write code that validates integer input

// bool validEntry = false;
// string? answer;
// int userNumber = 0;

// Console.WriteLine("Enter a number between 5 and 10");

// while (validEntry == false)
// {
//     answer = Console.ReadLine();

//     if (int.TryParse(answer, out userNumber))
//     {   
//         if (!(userNumber > 5 && userNumber < 10))
//             Console.WriteLine($"You entered {userNumber}. Please enter a number between 5 and 10.");
//         else
//             validEntry = true;
//     } else
//         Console.WriteLine("Sorry, you entered a invalid number, please try again");
// } 
// Console.WriteLine($"You typed a valid ({userNumber}) integer.");

//Code project 2 - write code that validates string input

// bool validEntry = false;
// string answer = "";

// Console.WriteLine("Enter you role name (Administrator, Manager, or User)");

// while (validEntry == false)
// {
//     answer = Console.ReadLine().Trim().ToLower();

//     if (answer == "administrator" || answer == "manager" || answer == "user")
//     {
//         validEntry = true;
//     } else
//         Console.WriteLine($"Your answer is not valid, enter you role (Administrator, Manager, or User) ");
// }
// Console.WriteLine($"Your input ({answer}) has been accepted");

//Code project 3 - Write code that processes the contents of a string array


