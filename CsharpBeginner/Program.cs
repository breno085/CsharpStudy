//Compatible Type Conversion (You are ok and aware with data loss)
// int i = 1000;
// byte d = (byte)i; // or Convert.ToInt32(i);
// Console.WriteLine(d);

//Non compatible Type Conversion
// string a = "1";
// int b = int.Parse(a);
// Console.WriteLine(b);

//Getting inputs
// Console.WriteLine("Digit a number: ");
// int num = int.Parse(Console.ReadLine());
// Console.WriteLine(num*2);

//try catch to handle errors
// try
// {
//     var number = "1234";
//     byte b = Convert.ToByte(number);
//     Console.WriteLine(b);

//     // test 2
//     // string str = "true";
//     // bool c = Convert.ToBoolean(str);
//     // Console.WriteLine(c);
// }
// catch (Exception)
// {
//     Console.WriteLine("The number could not be converted to byte.");
// }

//Postfix Increment
// int a = 1;
// int b = a++; // b = 1 and a = 2
//Prefix Increment
// int a = 1;
// int b = ++a; // b = 2 and a = 2

//for each tem aplicaçao diferente de for e while, pois ela serve somente para percorrer 
//elementos numa coleçao (arrays, lists, dictionaries, custom collections) e performar uma
//operaçao especifica em cada elemento
// int[] numbers = {1, 2, 3, 4, 5};

//         foreach (int number in numbers)
//         {
//             Console.WriteLine(number);
//         }

//criando um programinha que diz o maior de 10 numeros, com o conhecimento que aprendi agora
// int proxNum = 0;
// int maiorNum = int.MinValue;;
// int i = 0;

// while (i < 10){
//     Console.WriteLine("Digite um numero inteiro:");
//     try
//     {
//         proxNum = Convert.ToInt32(Console.ReadLine());
//     }
//     catch (FormatException)
//     {
//         Console.WriteLine("Valor invalido.");
//         i--;
//     }
//     if  (proxNum > maiorNum){
//         maiorNum = proxNum;
//         //Console.WriteLine($"Maior numero atual: {maiorNum}");
//     } 
//     i++;
// }
// Console.WriteLine($"O maior numero é {maiorNum}");

//Outra forma mais eficiente de escrever o codigo acima
// int maiorNumero = int.MinValue; 
// int proximoNumero;
// int tentativasMaximas = 10;

// for (int i = 0; i < tentativasMaximas; i++)
// {
//     Console.WriteLine("Digite um número inteiro:");
//     if (int.TryParse(Console.ReadLine(), out proximoNumero))
//     {
//         if (proximoNumero > maiorNumero)
//         {
//             maiorNumero = proximoNumero;
//         }
//     }
//     else
//     {
//         Console.WriteLine("Valor inválido. Tente novamente.");
//         i--; // Reduza a contagem se uma entrada inválida for detectada
//     }
// }

// Console.WriteLine($"O maior número é {maiorNumero}");

//O codigo necessario para a prova de algo I
int proxNum;
int maiorNum = int.MinValue;
int i = 0;

while (i < 10){
    Console.WriteLine("Digite um numero inteiro:");
    proxNum = Convert.ToInt32(Console.ReadLine());
    if  (proxNum > maiorNum){
        maiorNum = proxNum;
        //Console.WriteLine($"Maior numero atual: {maiorNum}");
    } 
    i++;
}
Console.WriteLine($"O maior numero é {maiorNum}");



