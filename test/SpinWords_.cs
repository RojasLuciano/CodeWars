namespace Clases;
public static class PracticeClass
{
    public static string SpinWords(string sentence)
    {
        string[] arr = sentence.Split(" ");
        var output = new List<string>();
      
        foreach (var item in arr)
        {
            if (item.Length <= 4)
            {
                output.Add(item);
                continue;
            }
            var wordArray = item.ToCharArray();
            var current = string.Empty;
            for (int i = item.Length - 1; i >= 0; i--)
            {
                current += wordArray[i];
            }
            output.Add(current);
        }
        return string.Join(" ", output);
    }

}


