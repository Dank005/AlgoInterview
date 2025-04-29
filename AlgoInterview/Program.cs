public class Program
{
    public static void Main()
    {
        Console.WriteLine(ContainsDuplicate217([1, 2, 3, 4]));
        Console.WriteLine(ContainsDuplicate217([1, 2, 3, 1]));
        
        Console.WriteLine(IsAnagram242("anagram", "nagaram"));
        Console.WriteLine(IsAnagram242("rat", "car"));
        
    }

    private static bool ContainsDuplicate217(int[] nums)
    {
        var hashSet = new HashSet<int>();

        foreach (var num in nums)
        {
            if (hashSet.Contains(num))
                return true;
            
            hashSet.Add(num);
        }
        
        return false;
        
        //OR return nums.Length != nums.Distinct().Count();
    }
    
    private static bool IsAnagram242(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        var dictS = new Dictionary<char, int>();
        var dictT = new Dictionary<char, int>();
        
        for (var i = 0; i < s.Length; i++)
        {
            if(dictS.ContainsKey(s[i]))
                dictS[s[i]]++;
            else
                dictS.Add(s[i], 1);
            
            if(dictT.ContainsKey(t[i]))
                dictT[t[i]]++;
            else
                dictT.Add(t[i], 1);
        }

        foreach (var d in dictS)
        {
            if(!dictT.ContainsKey(d.Key) || dictT[d.Key] != d.Value)
                return false;
        }
        
        return true;
    }
}
