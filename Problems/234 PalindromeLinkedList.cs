public class Palindrome
{
    public void Test()
    {
        int[] values = new int[] { 1, 2, 2, 1 };
        LinkedList<int> ll = new LinkedList<int>(values);
        System.Console.WriteLine(IsPanlindrome(ll.First));
    }

    private bool IsPanlindrome(LinkedListNode<int>? head)
    {
        var dummy = head;
        int count = 0;
        Stack<int> isPal = new Stack<int>();

        while (dummy != null)
        {
            isPal.Push(dummy.Value);
            dummy = dummy.Next;
        }

        dummy = head;
        while (count < isPal.Count && dummy != null)
        {
            if (dummy.Value == isPal.Peek())
            {
                isPal.Pop();
            }
            dummy = dummy.Next;
        }

        return isPal.Count > 0 ? false : true;
    }
}