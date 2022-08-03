using System;

namespace _02UnderstandingTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine($"sbyte: Bytes {sizeof(sbyte)}, Maximum {sbyte.MaxValue}, Minimum {sbyte.MinValue}");
            //Console.WriteLine($"byte: Bytes {sizeof(byte)}, Maximum {byte.MaxValue}, Minimum {byte.MinValue}");
            //Console.WriteLine($"short: Bytes {sizeof(short)}, Maximum {short.MaxValue}, Minimum {short.MinValue}");
            //Console.WriteLine($"ushort: Bytes {sizeof(ushort)}, Maximum {ushort.MaxValue}, Minimum {ushort.MinValue}");
            //Console.WriteLine($"int: Bytes {sizeof(int)}, Maximum {int.MaxValue}, Minimum {int.MinValue}");
            //Console.WriteLine($"uint: Bytes {sizeof(uint)}, Maximum {uint.MaxValue}, Minimum {uint.MinValue}");
            //Console.WriteLine($"long: Bytes {sizeof(long)}, Maximum {long.MaxValue}, Minimum {long.MinValue}");
            //Console.WriteLine($"ulong: Bytes {sizeof(ulong)}, Maximum {ulong.MaxValue}, Minimum {ulong.MinValue}");
            //Console.WriteLine($"float: Bytes {sizeof(float)}, Maximum {float.MaxValue}, Minimum {float.MinValue}");
            //Console.WriteLine($"double: Bytes {sizeof(double)}, Maximum {double.MaxValue}, Minimum {double.MinValue}");
            //Console.WriteLine($"decimal: Bytes {sizeof(decimal)}, Maximum {decimal.MaxValue}, Minimum {decimal.MinValue}");


            //int century = (int)Convert.ToInt64(Console.ReadLine());
            // convertCenturies temp = new convertCenturies();
            // temp.convert_centuries(century);


            // 1.What happens when you divide an int variable by 0 ?
            // int a = 5;
            // Console.WriteLine($"{a / 0}");
            // We get error message.

            // 2.What happens when you divide a double variable by 0 ?
            // double b = 0.24;
            // Console.WriteLine($"{b / 0}");
            // We get infinity as result.

            // 3.What happens when you overflow an int variable, that is, set it to a value beyond its range?
            // int d = 10000000000000000;
            // Console.WriteLine($"{d}");
            // We get error message.


            // 4.What is the difference between x = y++; and x = ++y;?
            // int a = 5;
            // int b = a++;
            // Console.WriteLine($"{a}");
            // int c = ++a;
            // Console.WriteLine($"{a}");
            // Console.WriteLine($"{b}");
            // Console.WriteLine($"{c}");
            // The first statement first assigns the value of y to x then increases the value of y by 1.
            // The second statement reverses the order.


            // 5.What is the difference between break, continue, and return when used inside a loop
            // statement ?
            // Break will terminate the current loop. Continue skips current iteration and stays in the loop
            // Return is used for functions to return a value (or NULL).



            //6.What are the three parts of a for statement and which of them are required ?
            // initialization; condition; iterator
            // None of those is required if generating a inifinte for loop is fine.


            // 7.What is the difference between the = and == operators ?
            // = is the assignment operator, which assigns value to a variable
            // == is a logical operator which returns true if two sides are equal.

            // 8.Does the following statement compile ? for (; true;) ;
            // yes


            // 9.What does the underscore _ represent in a switch expression ?
            // Else/Default


            // 10.What interface must an object implement to be enumerated over by using the foreach statement
            //

        }
    }

}


