using System.Collections;

namespace BalancedParantheses
{
    internal class Program
    {
        public static ArrayList paranthesesList = new ArrayList();
        static void Main(string[] args)
        {
            Program obj = new Program();
            Console.Write("Enter Number: ");
            int inputNumber = Convert.ToInt32(Console.ReadLine());

            obj.paranthesesGenerate(inputNumber);

            foreach(var paranthese in paranthesesList)
            {
                Console.Write($"{paranthese} ");
            }
        }
        public ArrayList paranthesesGenerate(int input)
        {
            generateParantheses(paranthesesList, 0, 0, input, "");
            return paranthesesList;
        }
        public void generateParantheses(ArrayList paranthesesList, int open, int close, int input, string str)
        {

            if (open == input && close == input)
            {
                paranthesesList.Add(str);
                return;
            }
            if (open < input)
            {
                generateParantheses(paranthesesList, open + 1, close, input, str + "(");
            }
            if (close < open)
            {
                generateParantheses(paranthesesList, open, close + 1, input, str + ")");

            }
        }
    }
}