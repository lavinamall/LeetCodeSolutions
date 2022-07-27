public class HappyNumber
{
    private int getSum(int n)
    {
        int sum = 0;
        while (n > 0)
        {
            int digit = n % 10;
            sum += (digit * digit);
            n /= 10;
        }
        return sum;
    }
    public bool IsHappy(int n)
    {
        HashSet<int> numbers = new HashSet<int>();
        while (n != 1 && !numbers.Contains(n))
        {
            numbers.Add(n);
            n = getSum(n);
        }
        foreach(var v in numbers)
            Console.Write($"{v}, ");
        return n == 1;
    }
}