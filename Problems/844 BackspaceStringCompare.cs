using System.Text;

public class BackspaceCompare
{
    public void Test()
    {
        System.Console.WriteLine($"{Compare("ab#c", "ad#c")}\n");
        System.Console.WriteLine($"{Compare("ab##c", "ad#c")}");
    }

    private bool Compare(string s, string t)
    {
        return Backspace(s).Equals(Backspace(t));
    }

    private string Backspace(string exp)
    {
        StringBuilder sb = new StringBuilder();

        foreach(char ch in exp)
        {
            if(ch == '#') 
            {
                if(sb.Length > 0)
                    sb.Length--;
            }
            else
                sb.Append(ch);
        }
        System.Console.WriteLine($"String = {sb.ToString()}");
        return sb.ToString();
    }
}