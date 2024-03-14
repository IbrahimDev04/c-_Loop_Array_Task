//Verilmish arrayda murekkeb ededlerin sayini cixaran algorithm misal:input {5,9,12,11} output 2

int[] nums = { 43, 23, 56, 79, 53, 73, 4, 12, 21 };
int count = 0;

for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] > 3)
    {
        for (int j = 2; j < nums[i]; j++)
        {
            if (nums[i] % j == 0)
            {
                count++;
                break;
            }
        }
    }
}

Console.WriteLine(count);
