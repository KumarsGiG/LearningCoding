using System.Text;

namespace Find_Length_Of_Longest_Possible_Palindrome
{
    internal static class Palindrome
    {
        public static readonly StringBuilder Output = new();

        private static readonly Dictionary<char, int> Directory = new();

        public static void Input(string words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                int count = 0;
                var word = words[i];
                if (Directory.ContainsKey(word))
                {
                    var present = Directory.First(x => x.Key == word);
                    Directory[word] = present.Value + 1;
                }
                else
                {
                    count++;
                    Directory.Add(word, count);
                }
            }

            CreatingPalindrome();
        }

        private static void CreatingPalindrome()
        {
            // if there is any odd value append it to the result
            var oddsDirectory = Directory.Where(x => x.Value % 2 != 0).ToList();
            if (oddsDirectory.Any())
            {
                Output.Append(oddsDirectory.First().Key.ToString());
            }

            var evensDirectory = Directory.Where(x => x.Value % 2 == 0)
                .OrderByDescending(x => x.Value).ToList();

            // to build the rest result
            foreach (var item in evensDirectory)
            {
                for (int i = 0; i < item.Value; i++)
                {
                    _ = i % 2 == 0 ? Output.Append(item.Key) : Output.Insert(0, item.Key);
                }
            }
        }
    }
}
