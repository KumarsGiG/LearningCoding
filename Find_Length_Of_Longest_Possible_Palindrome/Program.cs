namespace Find_Length_Of_Longest_Possible_Palindrome
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Palindrome.Input("abccccdd");
            Console.WriteLine($"The longest palindrome string that can be built is: { Palindrome.Output }, has length: { Palindrome.Output.Length }.");
        }
    }
}
