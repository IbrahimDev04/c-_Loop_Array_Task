//Verilmish ededin 2 quvveti olub olmadigini tapan alqoritm Misal: input 8 output 2-in quvvetidir ve ya input 9 2-in quvveti deyil

int num = Convert.ToInt32(Console.ReadLine());


while (num % 2 == 0)
{
    if (num == 0)
    {
        Console.WriteLine("Bu hal nezere alinmir");
        break;
    }
    num /= 2;
}

if (num == 1)
{
    Console.WriteLine("quvvetidir");

}
else if (num > 1)
{
    Console.WriteLine("deyil");
}


