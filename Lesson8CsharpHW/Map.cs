class Map
{
    public Pair[] Dictionary { get; set; }

    public Map(Pair[] dictionary)
    {
        Dictionary = dictionary;
    }

    public string this[string? keyOrValue]
    {
        get
        {
            bool check = false;
            foreach (var item in Dictionary)
            {
                if (item.Key == keyOrValue)
                {
                    check = true;
                    return item.Value;
                }
                else if (item.Value == keyOrValue)
                {
                    check = true;
                    return item.Key;
                }
            }
            if (!check)
                throw new ArgumentException("This Word is Not Exist", nameof(keyOrValue));
            return "";
        }
    }
}