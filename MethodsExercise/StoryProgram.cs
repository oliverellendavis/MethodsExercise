namespace MethodsExercise;

public class StoryProgram
{
    static void Main()
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        
        Console.WriteLine("What is your favourite colour?");
        string colour = Console.ReadLine();
        
        Console.WriteLine("What is your favourite animal?");
        string animal = Console.ReadLine();
        
        Console.WriteLine("What is your favourite band?");
        string band = Console.ReadLine();

        string story = $@"
        My cat's name is {name} and her fur is {colour}.
        Her best friend is a {animal} and they like to listen to music together.
        The band they like to listen to the most is {band}.
        ";
        
        Console.WriteLine(story);
    }
}