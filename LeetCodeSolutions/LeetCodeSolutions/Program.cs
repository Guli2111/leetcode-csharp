namespace LeetCodeSolutions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ToLOwerCase("Hello world!"));
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
    }
}
