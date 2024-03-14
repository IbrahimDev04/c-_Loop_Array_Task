//Verilmish arrayda en kicik ve en boyuk ededlerin cemini cixaran alogirthm

int[] nums = {23,25,53,12,56,87,3,45};
int max = nums[0];
int min = nums[0];

for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] > max)
    {
        max = nums[i];
    }
    if (nums[i] < min)
    {
        min = nums[i];
    }
}
Console.WriteLine(min+max);