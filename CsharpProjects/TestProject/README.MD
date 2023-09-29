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