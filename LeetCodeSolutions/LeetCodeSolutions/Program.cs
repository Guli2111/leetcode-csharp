namespace LeetCodeSolutions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(ToLOwerCase("Hello world!"));
            ReverseString(['h', 'e','l','l','o']);
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
        public static void ReverseString(char[] s)
        {
            char[] reverseChar = new char[s.Length];
            int index = 0;
            for(int i = s.Length-1; i >= 0; i--)
            {
                reverseChar[index] += s[i];
                index++;
            }
            for(int i = 0; i < s.Length; i++)
            {
                Console.Write(reverseChar[i] + " ");
            }
            //return true;
        }
    }
}
