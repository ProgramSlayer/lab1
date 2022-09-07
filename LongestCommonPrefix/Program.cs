using System.Text;

public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        StringBuilder sb = new();
        // Отсортировать массив в алфавитном порядке.
        Array.Sort(strs, (x, y) => string.Compare(x, y));
        // После сортировки определить общий префикс можно будет
        // по первой и последней строке массива.
        string first = strs.First();
        string last = strs.Last();
        for (int i = 0; i < first.Length && i < last.Length; i++)
        {
            if (first[i] == last[i])
            {
                sb.Append(first[i]);
            }
            else
            {
                break;
            }
        }
        return sb.ToString();
    }

    public static void Main(){
        string[] strs = {"andrey", "andy", "andrew", "andrei", "andre"};
        string common = new Solution().LongestCommonPrefix(strs);
        System.Console.WriteLine(common);
        foreach (var name in strs)
        {
            System.Console.WriteLine(name);
        }
    }
}