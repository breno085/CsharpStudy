- Stateless methods are called static methods
- Stateful methods are called instance methods
- The important thing to know is that, some methods like Random.Next() (stateful method) require you to create an instance of a class before you call them 
- other methods like Console.WriteLine() (stateless method) dont require it
How can you determine whether you need to create an instance of a class before calling its methods?
- One approach for determining whether a method is stateful or stateless is to consult the documentation
- The second approach is you can attempt to access the method directly from the class itself. If it works, you know that it's a stateless method. The worst that can happen is that you'll get a compilation error

Example of stateful (instance) method:
Random dice = new Random(); //Instance of a class (It is called object) (It created a new instance of Random() class)
int roll = dice.Next(1, 7);

Example of stateless (static) method:
Console.WriteLine(roll);

Previously codes that were used as test projects:

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

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

for (int i = 0; i < myStrings.Length; i++)
{   //this is another easier way to do it ()
    //string[] phrases = myStrings[i].Split(". ");
    //for (int j = 0; j < phrases.Length; j++)
    //   Console.WriteLine(phrases[j]);
    do
    {
        int periodLocation = myStrings[i].IndexOf(".");
        if (periodLocation > 0)
        {
            Console.WriteLine(myStrings[i].Substring(0, periodLocation));
            myStrings[i] = myStrings[i].Remove(0, periodLocation + 1).TrimStart(' ');
        } else
        {   Console.WriteLine(myStrings[i]);
            break;
        }
    } while (true);
}

//"Perform operations on arrays using helper methods in C#"
//Sort() e Reverse(), Clear() e Resize(), Split() e Join()
//(deixar anotado isso no README.MD)

//Sort() and Reverse()
// string[] pallets = { "B14", "A11", "B12", "A13" };

// Console.WriteLine("Sorted...");
// Array.Sort(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Console.WriteLine("Reversed...");
// Array.Reverse(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

//Clear() remove os valores dos elementos da array (os elementos continuam existindo mas são null)
//Resize() pode aumentar o numero de elementos (pro fim do array) ou remover elementos do array
// string[] pallets = { "B14", "A11", "B12", "A13" };
// Console.WriteLine("");

// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 6);
// Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

// pallets[4] = "C01";
// pallets[5] = "C02";

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 3);
// Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

//Slit() and Join()
// string value = "abc123";
// char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);
// // string result = new string(valueArray);
// string result = String.Join(",", valueArray);
// Console.WriteLine(result);

// string[] items = result.Split(',');
// foreach (string item in items)
// {
//     Console.WriteLine(item);
// }

//Exercise - Complete a challenge to reverse words in a sentence
// string pangram = "The quick brown fox jumps over the lazy dog";
// string[] pangramArray = pangram.Split(" ");
// string[] pangramReverse = new string[pangramArray.Length];
// int i = 0;

// foreach (var value in pangramArray)
// {
//     char[] valueArray = value.ToCharArray();
//     Array.Reverse(valueArray);
//     string valueReverse = new string(valueArray);
//     pangramReverse[i] = valueReverse;
//     i++;
// }
// string result = String.Join(" ", pangramReverse);
// Console.WriteLine(result);

// Exercise - Complete a challenge to parse a string of orders, sort the orders and tag possible errors
// string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
// string[] orderArray = orderStream.Split(",");
// Array.Sort(orderArray);

// foreach (string value in orderArray)
// {   
//     if (value.Length == 4)
//         Console.WriteLine(value);
//     else
//         Console.WriteLine($"{value}\t- Error");
// }

//Format Alphanumeric Data for Presentation in C#

// int invoiceNumber = 1201;
// decimal productShares = 25.4568m;
// decimal subtotal = 2750.00m;
// decimal taxPercentage = .15825m;
// decimal total = 3185.19m;

// Console.WriteLine($"Invoice Number: {invoiceNumber}");
// Console.WriteLine($"    Shares: {productShares:N3} Product");
// Console.WriteLine($"        Sub Total: {subtotal:C}");
// Console.WriteLine($"           Tax: {taxPercentage:P2}");
// Console.WriteLine($"     Total Billed: {total:C}");

// string input = "Pad this";
// Console.WriteLine(input.PadLeft(12, '-'));
// Console.WriteLine(input.PadRight(12, '-'));

// string paymentId = "769C";
// string payeeName = "Mr. Stephen Ortega";
// string paymentAmount = "$5,000.00";

// var formattedLine = paymentId.PadRight(6);
// formattedLine += payeeName.PadRight(24);
// formattedLine += paymentAmount.PadLeft(10);

// Console.WriteLine("1234567890123456789012345678901234567890");
// Console.WriteLine(formattedLine);

//Modify the content of strings using built-in string data type methods in C#
//Using the methods: IndexOf() and Substring(), IndexOfAny() and LastIndexOf(), Remove() and Replace()

// string message = "Find what is (inside the parentheses)";

// int openingPosition = message.IndexOf('(');
// int closingPosition = message.IndexOf(')');

// // Console.WriteLine(openingPosition);
// // Console.WriteLine(closingPosition);

// openingPosition += 1; // to not include opening '(' parentheses

// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

// string message = "What is the value <span>between the tags</span>?";

// const string openSpan = "<span>";
// const string closeSpan = "</span>";

// int openingPosition = message.IndexOf(openSpan);
// int closingPosition = message.IndexOf(closeSpan);

// openingPosition += openSpan.Length;
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

// string message = "(What if) I am (only interested) in the last (set of parentheses)?";
// int openingPosition = message.LastIndexOf('(');

// openingPosition += 1;
// int closingPosition = message.LastIndexOf(')');
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

//Retrieve all instances of substrings inside parentheses
// string message = "(What if) there are (more than) one (set of parentheses)?";
// while (true)
// {
//     int openingPosition = message.IndexOf('(');
//     if (openingPosition == -1) break;

//     openingPosition += 1;
//     int closingPosition = message.IndexOf(')');
//     int length = closingPosition - openingPosition;
//     Console.WriteLine(message.Substring(openingPosition, length));

//     // Note the overload of the Substring to return only the remaining 
//     // unprocessed message:
//     message = message.Substring(closingPosition + 1);
// }

// string message = "Help (find) the {opening symbols}";
// Console.WriteLine($"Searching THIS Message: {message}");
// char[] openSymbols = { '[', '{', '(' };
// int startPosition = 6;
// int openingPosition = message.IndexOfAny(openSymbols);
// Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

// openingPosition = message.IndexOfAny(openSymbols, startPosition);
// Console.WriteLine($"Found WITH using startPosition: {message.Substring(openingPosition)}");

// string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// // The IndexOfAny() helper method requires a char array of characters. 
// // You want to look for:

// char[] openSymbols = { '[', '{', '(' };

// // You'll use a slightly different technique for iterating through 
// // the characters in the string. This time, use the closing 
// // position of the previous iteration as the starting index for the 
// //next open symbol. So, you need to initialize the closingPosition 
// // variable to zero:

// int closingPosition = 0;

// while (true)
// {
//     int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

//     if (openingPosition == -1) break;

//     string currentSymbol = message.Substring(openingPosition, 1);

//     // Now  find the matching closing symbol
//     char matchingSymbol = ' ';

//     switch (currentSymbol)
//     {
//         case "[":
//             matchingSymbol = ']';
//             break;
//         case "{":
//             matchingSymbol = '}';
//             break;
//         case "(":
//             matchingSymbol = ')';
//             break;
//     }

//     // To find the closingPosition, use an overload of the IndexOf method to specify 
//     // that the search for the matchingSymbol should start at the openingPosition in the string. 

//     openingPosition += 1;
//     closingPosition = message.IndexOf(matchingSymbol, openingPosition);

//     // Finally, use the techniques you've already learned to display the sub-string:

//     int length = closingPosition - openingPosition;
//     Console.WriteLine(message.Substring(openingPosition, length));
// }

//Using the Remove() and Replace() methods
// string data = "12345John Smith          5000  3  ";
// string updatedData = data.Remove(5, 20);
// Console.WriteLine(updatedData);

// string message = "This--is--ex-amp-le--da-ta";
// message = message.Replace("--", " ");
// message = message.Replace("-", "");
// Console.WriteLine(message);

//Extract, replace, and remove data from an input string
// const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

// string quantity = "";
// string output = "";

// const string openSpan = "<span>";
// const string closeSpan = "</span>";
// const string openDiv = "<div>";
// const string closeDiv = "</div>";

// int openingPosition = input.IndexOf(openSpan);
// int closingPosition = input.IndexOf(closeSpan);
// openingPosition += openSpan.Length;
// quantity = input.Substring(openingPosition, closingPosition - openingPosition);

// output = input.Remove(0, openDiv.Length);
// int openLastDiv = output.LastIndexOf('<');
// output = output.Remove(openLastDiv, closeDiv.Length);

// output = output.Replace("&trade", "&reg");

// Console.WriteLine(quantity);
// Console.WriteLine(output);

