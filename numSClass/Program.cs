using System;

namespace numSuperClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("何か入力してください:");
            var input = Console.ReadLine();

            //userが数列か文字列か
            if (int.TryParse(input, out int inputNum))
            {
                NumberClass execNum = new NumberClass();
                execNum.RefNum(inputNum);
                execNum.LengthNum(inputNum);
            }
            else
            {
                StringClass execStr = new StringClass();
                execStr.LengthStr(input);
                execStr.DoStr(input);

            }
        }
    }

    internal class NumberClass : NumClass
    {
        public void RefNum(int num)
        {
            OddNum(num);
        }

        public void LengthNum(int num)
        {
            if (num < 10)
            {
                Console.WriteLine("この数は１桁です");
            }
            else if (num < 100)
            {
                Console.WriteLine("この数は２桁です");
            }
        }
    }

    internal class StringClass : StrClass
    {
        public void LengthStr(String str)
        {
            if (str.Length < 1000)
            {
                Console.WriteLine("短文です！");
            }
        }

        public void DoStr(String str)
        {
            HelloStr(str);
            ReStr(str);
        }
    }
}
