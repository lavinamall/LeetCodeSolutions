public class IntegerToRoman
{
    public string IntToRoman_1(int num)
    {
        string[] M = new string[] { "", "M", "MM", "MMM" };
        string[] C = new string[] { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
        string[] X = new string[] { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
        string[] I = new string[] { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
        
        // System.Console.WriteLine($"{num}/1000 = {num/1000}");
        // System.Console.WriteLine($"{num}%1000 = {num % 1000} & /100 = {(num % 1000) / 100}");
        
        return M[num / 1000] + C[(num % 1000) / 100] + X[(num % 100) / 10] + I[num % 10];
    }

    public string IntToRoman_2(int num)
    {
        string[] roman = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
        int[] nums = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        string res = "";
        int i = 0;

        while (num > 0)
        {
            while (num >= nums[i])
            {
                res += roman[i];
                num -= nums[i];
            }
            i++;
        }

        return res;
    }

    public void Test_IntegerToRoman()
    {
        System.Console.WriteLine($"{IntToRoman_1(1)}");
        System.Console.WriteLine($"{IntToRoman_2(56)}");
        System.Console.WriteLine($"{IntToRoman_1(1994)}");
    }
}