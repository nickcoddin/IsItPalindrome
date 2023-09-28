namespace IsPalindrome
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string textOne = "Atami itesa aseTi imata";
            string textTwo = "Nikoloz demetrashvili";

            Console.WriteLine(IsPalindrome(textOne));
            Console.WriteLine(IsPalindrome(textTwo));
        }

        public static bool IsPalindrome(string text)
        {
            char[] charArray = new char[text.Count()];
            int increment = 0;

            foreach (char letter in text.ToUpper())
            {
                if (char.IsLetterOrDigit(letter))
                {
                    Array.Resize(ref charArray, increment + 1);
                    charArray[increment] = letter;
                    increment++;
                }
            }
            return charArray.SequenceEqual(charArray.Reverse());
        }
    }
}