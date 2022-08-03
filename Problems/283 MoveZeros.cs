public class MoveZeros
{
    public void MoveZeroes(int[] nums)
    {
        int index = 0, pointer = 0;
        while(index < nums.Length)
        {
            if(nums[index] != 0)
            {
                nums[pointer] = nums[index];
                pointer++;
            }
            index++;
        }

        while(pointer < nums.Length)
        {
            nums[pointer] = 0;
            pointer++;
        }

        foreach (var item in nums)
            System.Console.WriteLine(item);
    }
}