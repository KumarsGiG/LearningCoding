public class StringPalindromeCheck
{
    public static void CheckPalindrome()
    {
        // Declaration
        string? inputString = "";
        Dictionary<char,int> keyValuePairs = new Dictionary<char,int>();
        Dictionary<char, int> palindromeKeys = new Dictionary<char, int>();

        // Prompt
        Console.Write("Enter a mixed case string :-");
        
        // Input
        inputString = Console.ReadLine();
        
        // Setup
        foreach (char item in inputString.ToCharArray())
        {
            if (keyValuePairs.ContainsKey(item))
            {
                keyValuePairs[item]++;
            }
            else
            {
                keyValuePairs.Add(item, 1);
            }
        }

        // Char having even count
        foreach (var item in keyValuePairs.Where(x => (x.Value %2) == 0))
        {
            palindromeKeys.Add(item.Key, item.Value);
        }

        // Char having odd count
        KeyValuePair<char, int> keyValue = new KeyValuePair<char, int>();
        if (keyValuePairs.Where(x => (x.Value > 2) && ((x.Value % 2) != 0)).Count() > 0)
        {
            // Char having more then 1 occurance
            keyValue = keyValuePairs.Where(x => (x.Value > 2) && ((x.Value % 2) != 0)).FirstOrDefault();
            palindromeKeys.Add(keyValue.Key, keyValue.Value);
        }
        else
        {
            // Char having 1 occurance
            keyValue = keyValuePairs.Where(x => x.Value == 1).FirstOrDefault();
            palindromeKeys.Add(keyValue.Key, keyValue.Value);
        }

        // Result
        Console.WriteLine("The longest palindrome can be of " + palindromeKeys.Sum(x => x.Value) + " letters. Having");
        foreach (var item in palindromeKeys)
        {
            for (int i = 1; i <= item.Value; i++)
            {
                Console.Write(item.Key);
            }
            Console.Write(", ");
        }
    }
}
