public class StringSwapAreAlmostEqual
{
    private bool AreAlmostEqual(string s1, string s2)
    {
        Dictionary<char, int> letters = new Dictionary<char, int>();
        int misMatchCount = 0;

        foreach (char item in s1)
        {
            if(!letters.ContainsKey(item))
                letters.Add(item,1);
            else
                letters[item] += 1;
        }

        for (int i = 0; i < s2.Length; i++)
        {
            if(letters.ContainsKey(s2[i]))
                letters[s2[i]]--;
            
            if(s1[i] != s2[i])
                misMatchCount++;
        }

        foreach (var item in letters)
            if (item.Value > 0 || item.Value < 0)
                return false;

        return (misMatchCount == 0 || misMatchCount == 2);
    }


    public void Test()
    {
        string s1 = "", s2 = "";

        s1 = "yy"; s2 = "yf";
        System.Console.WriteLine(AreAlmostEqual(s1, s2));

        s1 = "bank"; s2 = "abkn";
        System.Console.WriteLine(AreAlmostEqual(s1, s2));

        s1 = "bank"; s2 = "bakn";
        System.Console.WriteLine(AreAlmostEqual(s1, s2));
    }
}