using System;

public class ReverseString
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a string: ");
        string input = Console.ReadLine();

        string reversed = ReverseStringInput(input);

        Console.WriteLine("Reversed string: " + reversed);
        
    } 

    public static string ReverseStringInput(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);

    }
} 
