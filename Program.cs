for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(i);
    }
}

//int a = 0, b = 0;
//for (int i = 1; i <= 100; i++)
//{
//    a++;
//    b++;

//    if (a == 3 && b == 5)
//    {
//        console.writeline("fizzbuzz");
//        a = 0;
//        b = 0;
//    }
//    else if (a == 3)
//    {
//        console.writeline("fizz");
//        a = 0;
//    }
//    else if (b == 5)
//    {
//        console.writeline("buzz");
//        b = 0;
//    }
//    else
//    {
//        console.writeline(i);
//    }
//}