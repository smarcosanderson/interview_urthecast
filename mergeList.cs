class MainProgram
{

    private static List<string> merge(List<string> source, List<string> toAdd, List<string> toDel)
    {
        Dictionary<string, int> dictHelper = new Dictionary<string, int>();
        List<string> result = new List<string>();

        //grabing all elements 
        List<string> allElements = new List<string>();
        allElements.AddRange(source);
        allElements.AddRange(toAdd);

        //sorting alphabetically and reversing it 
        allElements.Sort();
        allElements.Reverse();

        //using a Key,Value structure to get unique values
        //Notice that all the elements to be deleted will not be added in the Key,Value structure
        foreach (var item in allElements.FindAll(p => !toDel.Contains(p)))
        {
            if (!dictHelper.ContainsKey(item))
                dictHelper.Add(item, item.Length);
        }

        //Ordering by the character count
        //as the list is already reversed alphabetically, then if its a tie the correct order will be applied
        foreach (var item in dictHelper.OrderByDescending(p=> p.Value))
        {
            result.Add(item.Key);
        }

        return result;
    }

    static void Main(string[] args)
    {
        List<string> source = new List<string>() { "one", "two", "three" };
        List<string> toAdd = new List<string>() { "one", "two", "five", "six" };
        List<string> toDel = new List<string>() { "two", "five" };

        var mergedList = merge(source, toAdd, toDel );

        Console.Read();

    }
}
