namespace MethodsExercise;

public class MathOperationsMethods
{
    public void MathOperations()
    {
        Console.WriteLine(Add(3, 6)); // Output: 9
        Console.WriteLine(Multiply(3, 6)); //Output: 18
        Console.WriteLine(Subtract(6, 3)); //Output: 3
        Console.WriteLine(Divide(6, 3)); //Output: 2
    }

    static int Add(int x, int y)
    {
        return x + y;
    }

    static int Multiply(int x, int y)
    {
        return x * y;
    }

    static int Subtract(int x, int y)
    {
        return x - y;
    }

    static int Divide(int x, int y)
    {
        return x / y;
    }
}
    