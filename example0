using System;

class AnomalyExample
{
    static void Main(string[] args)
    {
        // Type 1: Defined and then defined again
        int x = 5;
        int x = 10; // Error: 'x' is already defined in this scope
        Console.WriteLine(x);

        // Type 2: Undefined but referenced
        Console.WriteLine(y); // Error: 'y' is used before it's declared
        int z = y + 5; // This line won't execute due to the error
        int y = 3;

        // Type 3: Defined but not referenced
        int a = 10;
        // 'a' is defined but never used
    }
}
