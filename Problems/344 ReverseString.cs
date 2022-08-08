using System.Text;

public class ReverseString{
    public void Test()
    {
        char[] s = new char[] { 'l', 'e', 'e', 't', 'c', 'o', 'd', 'e' };
        ReverseUsingStack(s);
    }

    private void Reverse(char[] s)
    {

    }

    private void ReverseUsingStack(char[] s)
    {
        Stack<char> st = new Stack<char>();
        int index = 0;

        foreach(char ch in s)
            st.Push(ch);

        while(st.Count > 0)
            s[index++] = st.Pop();

        foreach (char ch in s)
            System.Console.Write($"{ch} ");

    }
}