public class SumOfAllOddSubarrays
{
    public int SumOddLengthSubarrays(int[] arr)
    {
        if (arr == null || arr.Length == 0)
            return 0;

        Dictionary<int, int> dic = new Dictionary<int, int>();
        dic.Add(-1, 0);

        int sum = 0, prefixSum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            prefixSum += arr[i];
            foreach (var item in dic)
            {
                if ((i - item.Key) % 2 != 0)
                    sum += prefixSum - dic[item.Key];
            }

            dic.Add(i, prefixSum);
        }
        System.Console.WriteLine(sum);
        return sum;
    }
}