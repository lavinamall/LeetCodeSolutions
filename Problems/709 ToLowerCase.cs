using System.Text;

public class LowerCase{
    public void ToLowerCase(string s){
        System.Console.WriteLine(Approach_1(s));
        System.Console.WriteLine(Approach_2(s));
        System.Console.WriteLine(Approach_3(s));
    }

    private string Approach_1(string s)
    {
        System.Console.WriteLine("Approach_1");
        char[] ans = new char[s.Length];
        for (int i = 0; i < s.Length; i++)
        {
            if(s[i] > 'A' && s[i] < 'Z')
                ans[i] = (char)((int)s[i] + 32);
            else
                ans[i] = s[i];
        }
        return new string(ans);
    }

    private string Approach_2(string s)
    {
        System.Console.WriteLine("Approach_2");
        StringBuilder ans = new StringBuilder();
        foreach (char ch in s)
        {
            if (Char.IsUpper(ch))
                ans.Append((char)((int)ch + 32));
            else
                ans.Append(ch);
        }
        return ans.ToString();
    }

    private string Approach_3(string s)
    {
        System.Console.WriteLine("Approach_3");
        StringBuilder ans = new StringBuilder();
        foreach (char ch in s)
        {
            if (Char.IsUpper(ch))
                ans.Append((char)(ch | 32));
            else
                ans.Append(ch);
        }
        return ans.ToString();
    }

}