

namespace DP07;

public class Purchase
{
    public Purchase(string name)
    {
        Name = name;
    }

    public string Name { get; set; }

    public override string ToString() => Name;
}
