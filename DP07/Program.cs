using static System.Console;
namespace DP07;

public class Program
{
    static void Main(string[] args)
    {
        var purchaseList = new PurchaseList(new Purchase[] { new Purchase("Тетрадь"), new Purchase("Ручка"), new Purchase("Карандаш")});
        foreach (var purchase in purchaseList)
        {
            WriteLine(purchase);
        }
    }
}
