using System.Collections;

namespace DP07;

public class PurchaseList : IEnumerable<Purchase>
{ 
    private Purchase[] purchases;

    public PurchaseList(Purchase[] purchases)
    {
        this.purchases = purchases;
    }
    


    public IEnumerator<Purchase> GetEnumerator()
    {
        foreach(var purchase in purchases)
        {
            yield return purchase;
        }
    }

    IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }

}
