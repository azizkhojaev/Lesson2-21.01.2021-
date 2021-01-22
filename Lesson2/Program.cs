using System;

namespace Lesson2
{
    public class Homework1
    {
        public void Task1()
        {
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            if (a != b)
            {
                a = Math.Max(a, b);
                b = a;
            }
            else
                a = b = 0;
            Console.WriteLine(a+" "+b);
        }
        public void Task2()
        {
            Console.Write("Enter first number ");
            var operand1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number ");
            var operand2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Choose your sign (+, - , * , /) ");
            var a = Console.ReadLine();
            switch(a)
            {
                case "+":
                    {
                        var ans = operand1 + operand2; 
                        Console.WriteLine(operand1 + " + " + operand2 + " = " + ans);
                    }
                    break;
                case "-":
                    {
                        var ans = operand1 - operand2;
                        Console.WriteLine(operand1 + " - " + operand2 + " = " + ans);
                    }  
                    break;
                case "*":
                    {
                        var ans = operand1 * operand2;
                        Console.WriteLine(operand1 + " * " + operand2 + " = " + ans);
                    }
                    break;
                case "/":
                    {
                        if (operand2 == 0)
                            Console.WriteLine("We can't divide a number by zero ");
                        else
                        {
                            float x = operand1, y=operand2;

                            var ans = x / y;
                            Console.WriteLine(operand1 + " / " + operand2 + " = " + ans);
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Your sign is invalid ");
                    break; 


            }
        }
        public void Task3()
        {
            var n = Convert.ToInt32(Console.ReadLine()); 
            if (n>=0 && n<=14 )
                Console.WriteLine(n +" is among 1 to 14 ");
            else if (n>=15 && n <=35)
                Console.WriteLine(n +" is among 15 to 35");
            else if (n>=36 && n<=49)
                Console.WriteLine(n +"is among 36 to 49");
            else if (n>=50 && n<=100)
                Console.WriteLine(n +" is amont 50 to 100");
            else
                Console.WriteLine("Your number is not in range of 1 to 100");
        }
    }
    public class Homework2
    {
        public void Task1()
        {
            var n = Convert.ToDouble(Console.ReadLine());
            double sale = 0, x;
            if (n >= 500)
            {

                sale = (n * 5) / 100;
                x = 5;
            }
            else
            {
                sale = (n * 3) / 100;
                x = 3; 
            }
            n -= sale;
            Console.WriteLine("You have "+x+" % sale and it will be "+sale+"$");
            Console.WriteLine("you have to pay "+n +"$");
        }
        public void Task2()
        {
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());
            var d = Convert.ToInt32(Console.ReadLine());

            if (a<=b && b<=c && c<=d && a!=d)
                Console.WriteLine("Numbers are arranged in ascending order.");
            else if (a==b && b==c && c==d)
                Console.WriteLine(Math.Pow(a,4));
            else
                Console.WriteLine(Math.Min(Math.Min(a,b),Math.Min(a,d)));

        }
        public void Task3()
        {
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());
            int  max=0, min=0, temp= a+b+c;

            max = (a + b) + Math.Abs(a - b);
            max /= 2;

            max = (max + c) + Math.Abs(max - c);
            max /= 2;

            min = (a + b) - Math.Abs(a - b);
            min /= 2;

            min = (min + c) - Math.Abs(min - c);
            min /= 2;

            Console.WriteLine("Min = "+min);
            temp -= min+max;
            Console.WriteLine("Average = " +temp);
            Console.WriteLine("Max = "+max);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var HM1 = new Homework1();// урок 2 домашнее задание # 1
            var HM2 = new Homework2();// урок 2 домашнее задание # 2

            //HM1.Task1();
            HM2.Task3(); //вызываемый метод будет показан в консоли

        }
    }
}
