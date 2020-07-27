using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace test
{
    class Operations
    {
        double num1;
        double num2;
        double res;
        public double Num1
        {
            get
            {
                return num1;
            }
            set
            {
                num1 = value;
            }
        }
        public double Num2
        {
            get
            {
                return num2;
            }
            set
            {
                num2 = value;
            }
        }
        public Operations() { }
        public Operations(double _num1, double _num2)
        {
            Num1 = _num1;
            Num2 = _num2;
        }
        public double Add()
        {
            return Num1 + Num2;
        }




    }

    class Expression
    {
        public string expression;
        public Expression(string expression)
        {
            this.expression = expression;
        }

    }

    




    class Program
    {
        public static List<string> GetWithIn(string str)
        {
            List<string> rez = new List<string>();
            Regex pattern = new Regex(@"\((?<val>.*?)\)", RegexOptions.Compiled | RegexOptions.Singleline);
            foreach (Match m in pattern.Matches(str)) if (m.Success) rez.Add(m.Groups["val"].Value);
            return rez;
        }


        static void Main(string[] args)
        {
            Title = "Test";
            Operations calc = new Operations(10,12);
            WriteLine(calc.Add());
            Expression exp1 = new Expression("12*(2.5+5)+(6-5)/4");
            WriteLine(exp1.expression);
            List<string> lists = GetWithIn(exp1.expression);
            //Regex pattern = new Regex(@"\((?<val>.*?)\)", RegexOptions.Compiled | RegexOptions.Singleline);
            //foreach (Match m in pattern.Matches(exp1.expression))
            //    if (m.Success) lists.Add(m.Groups["val"].Value);
            foreach (string item in lists) WriteLine(item);



            //string str = @"Обычная (случайная) строка (последовательность символов).И еще просто набор цифр - (как число)";
            //public List<string> GetWithIn(string str)
            //{
            //    List<string> rez = new List<string>();
            //    Regex pattern =
            //        new Regex(@"\((?<val>.*?)\)",
            //            RegexOptions.Compiled |
            //            RegexOptions.Singleline);
            //    foreach (Match m in pattern.Matches(str))
            //        if (m.Success)
            //            //меж скобок ( )  
            //            rez.Add(m.Groups["val"].Value);
            //    return rez;
            //}


            //public List<string> GetWithIn(string str)
            //{
            //    List<string> rez = new List<string>();
            //    Regex pattern = new Regex(@"(?<=\().*?(?=\))");
            //    foreach (Match m in pattern.Matches(str))
            //        if (m.Success)
            //            //меж скобок ( )  
            //            rez.Add(m.Groups["val"].Value);
            //    return rez;
            //}




            ReadKey();
        }


        


    }
}
