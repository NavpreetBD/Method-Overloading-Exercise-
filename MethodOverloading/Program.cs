namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine(Add(2,2, true));

        }
        public static int Add(int number1, int number2)
        {
            int answer = number1 + number2;
            return answer;
        }
        public static decimal Add(decimal number1, decimal number2) 
        {
            decimal answer = number1 + number2;
            return answer;
        }
        public static string Add(int number1, int number2, bool isMoney)
        {
            int answer = number1 + number2;

            if (isMoney == true && answer > 1)
            {
                return $"{answer} dollars";
            }
            else
            {
                return $"{answer} dollar";
                // return answer.ToString(); // to convert ansewr to string
            }
        }
    }
}
