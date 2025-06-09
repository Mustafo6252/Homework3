
//                                  Task 1
/*

using System;

class Program
{
    static void NaturalNambers(int number1)
    {
        
        if (number1 == 0)
        {
            return;
        } 
        NaturalNambers(number1 - 1);
        Console.Write(number1+"  ");
    }

    static void Main(string[] args)
    {
        Console.Write("Qaysi raqamgacha natural sonlarni kiritmoqchisiz: ");
        int number1= int.Parse(Console.ReadLine());
        NaturalNambers(number1); 
    }
}

*/ 

//                                     Task 2
/*
                                   
using System;

class Program
{
    static void FromUpToDown(int number2,int x)
    {
        if (x == number2+1)
        {
            return;
        }
        FromUpToDown(number2, x+1);
        Console.Write(x + "  ");
    }

    static void Main(string[] args)
    {
        Console.Write("Qaysi raqamgacha natural sonlarni kiritmoqchisiz: ");
        int number2= int.Parse(Console.ReadLine());
        int x = 1;
        FromUpToDown(number2,x);
    }
}

*/
 
//                              Task 3
/*       

using System;

class Program
{
    static int Sum(int number3)
    {

        if (number3 == 0)
        {
            return 0;
        }

        return number3 + Sum(number3 - 1);
    }

    static void Main(string[] args)
    {
        Console.Write("Qaysi raqamgacha natural sonlarni yig'indisini topmoqchisiz: ");
        int number3= int.Parse(Console.ReadLine());
        int sum = 0;
        Console.WriteLine($"The sum is : {Sum(number3)}");
    }
}       

*/

//                           Task 4

/*
    
using System;

class Program
{
    static void DisplayDigits(int number4)
    {
        if (number4 == 0)
        {
            return;
        }
        DisplayDigits(number4/10);
        Console.Write(number4%10+ "   ,   ");
    }

    static void Main(string[] args)
    {
        Console.Write("Sonni kiriting: ");
        int number4= int.Parse(Console.ReadLine());
        DisplayDigits(number4); 
    }
}       

*/

//                               Task 5

/*

using System;

class Program
{
    static int NumberOfDigits(int number5)
    {
        int count=1;
        if (number5 == 0)
        {
            return 0;
        }
        return count + NumberOfDigits(number5/10);
    }
    static void Main(string[] args)
    {
        Console.Write("Sonni kiriting: ");
        int number5= int.Parse(Console.ReadLine());
        Console.WriteLine("The number of digits: " +NumberOfDigits(number5)); 
    }
}    

*/

//                                  Task 6

/*

using System;

class Program
{
    static void Even(int start, int end)
    {
        if (start == end+1)
        {
            return;
        }

        if (start % 2 == 0)
        {
            Console.Write(start+ "  ");
        }
        Even(start + 1, end);
    }
    static void Odd(int start, int end)
    {
        if (start == end+1)
        {
            return;
        }

        if (start % 2 == 1)
        {
            Console.Write(start+ "  ");
        }
        Odd(start + 1, end);
    }

    static void Main(string[] args)
    {
        int start, end;
        Console.Write("Boshlang'ich sonni kiriting: ");
        start = Convert.ToInt32(Console.ReadLine());
        Console.Write("oxirgi sonni kiriting: ");
        end = Convert.ToInt32(Console.ReadLine());
        Console.Write("Juft sonlar: ");
        Even(start, end);
        Console.WriteLine();
        Console.Write("Toq sonlar: ");
        Odd(start, end);
    }
}          

*/

//                                   Task 7
                                                                                   