namespace LeetCodeSolutions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(ToLOwerCase("Hello world!"));
            Console.WriteLine(ReverseWords("Hello world!"));
        }
        public static string ToLOwerCase(string s)
        {
            char[] chars = s.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] >= 'A' && chars[i] <= 'Z')
                {
                    chars[i] = (char)(chars[i] + 32);
                }
            }
            return new string(chars);
        }
        public static string ReverseWords(string s)
        {
            string reverseWords = "";
            string[] newStr = s.Split(' ');
            foreach (string str in newStr)
            {
                string reverseString = "";
                char[] chars = str.ToCharArray();

                for (int i = str.Length - 1; i >= 0; i--)
                {
                    reverseString += chars[i];
                }
                reverseWords += reverseString +" ";
            }
            reverseWords = reverseWords.TrimEnd(); // Remove the trailing space
            return reverseWords;
        }
    }
}
