namespace Modul3;

public class Functions
{
    // return true iff s is a palindrome
    public static bool IsPalindrome(string s)
    {
        int first = 0;
        int last = s.Length - 1;
        while (first < last) {
            if (s[first] != s[last])
                return false;
            first++;
            last--;
        }
        return true;
    }

    public static void TestPalindrome()
    {
        Console.WriteLine("Test af palindrome");

        string s = "mellem";
        bool res = IsPalindrome(s);
        if (res)
            Console.WriteLine($"{s} is a palindrome");
        else
            Console.WriteLine($"{s} is NOT a palindrome");
    
        s = "peter";
        res = IsPalindrome(s);
        if (res)
            Console.WriteLine($"{s} is a palindrome");
        else
            Console.WriteLine($"{s} is NOT a palindrome");
    }
}