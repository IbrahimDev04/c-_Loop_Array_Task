//Verilmish ededin mertebelerinin en boyuyunu tapan alqoritm Misal: input 7481, output 8
int num = Convert.ToInt32(Console.ReadLine());
int endNum = 0;
int max = 0;

while (num % 10 != 0)
{
    endNum = num % 10;

    if (max < endNum)
    {
        max = endNum;
    }
    num /= 10;  
}

Console.WriteLine(max);