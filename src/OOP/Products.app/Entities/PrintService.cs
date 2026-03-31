public struct PrintService{


    public void AddValue(int value, List<int> n)
    {
        n.Add(value);
    }

    public int First(List<int> n)
    {
        int first = n[0];
        return first;
    }
    public string Print(List<int> n)
    {
        int b = 0;
        foreach(int numbers in n)
        {
            b += numbers;
        }
        return b.ToString("[,]");
    }
}