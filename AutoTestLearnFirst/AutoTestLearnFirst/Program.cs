using System;

namespace AutoTestLearnFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleParser.ParseAndSum("1");
        }
    }


    class SimpleParserTests
    {
        public static void TestReturnsZeroWhenEmptyString()
        {
            try
            {
                SimpleParser p = new SimpleParser();
                int result = p.ParseAndSum(string.Empty);
                if (result !=0)
                {
                    Console.WriteLine(@”***SimpleParserTests.TestReturnsZeroWhenEmptyString:
-------
                }
            }
        }
    }

    public class SimpleParser
    {
        internal static void  ParseAndSum(string numbers)
        {
            if(numbers.Length==0)
            {
                Console.WriteLine(0);

            }
            if (!numbers.Contains(","))
            {

                Console.WriteLine(int.Parse(numbers));

            }
            else
            {
                throw new InvalidOperationException(
                    "Пока умею обрабатывать только 0 или 1"
                    );
             } 
        }
    }
}
