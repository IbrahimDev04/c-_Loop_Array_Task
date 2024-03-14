//Verilmish arrayda hem tek eded olan hemde 3-e bolunen ededlerin sayini cixaran algorithm

int[] nums = { 54, 23, 57, 43, 89, 2, 34, 5, 4, 6, 9 };
int count = 0;

for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] % 2 == 0 && nums[i] % 3 == 0) 
    {  
        count++;
    }

}
Console.WriteLine(count);
