

string hello = "Hello, world!";
string panic = "Don´t panic";

PrintStringFiveTimes(panic);
PrintStringFiveTimes(hello);
PrintStringFiveTimes("Maarika");

//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine(hello);
//}

//for (int i = 0;i < 5; i++)
//{
//    Console.WriteLine(panic);
//}

static void PrintStringFiveTimes(string someString)
{
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine(someString);
    }
}
