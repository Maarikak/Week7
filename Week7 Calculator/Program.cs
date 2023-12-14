

int a = 5;
int b = 6;

Add(b, a);
Add(10, 100);
Add(637, 6278);
static void Add(int x, int y)
{
    Console.WriteLine($"{x} + {y} = {x + y}");
}

multiply(b, a);
multiply(10, 100);
multiply(637, 6278);
static void multiply(int x, int y)
{
    Console.WriteLine($"{x} * {y} = {x * y}");
}

substract(b, a);
substract(100, 10);
substract(55, 11);


static void substract(int x, int y)
{
    Console.WriteLine($"{x} - {y} = {x - y}");
}

divide(b, a);
divide(100, 10);
divide(55, 11);
static void divide(int x, int y)
{
    Console.WriteLine($"{x} / {y} = {x / y}");
}