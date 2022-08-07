using System;

namespace vowelLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Console.WriteLine(VowelLetter(text));
        }
        static int VowelLetter(string text)
        {
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i]=='a'||text[i]=='A'||text[i]=='e'||text[i]=='E'||text[i]=='i'||text[i]=='I'||text[i]=='o'||text[i]=='O'||text[i]=='u'||text[i]=='U')
                    count++;
            }
            return count;
            
        }
    }
}
