namespace MethodsForTest;

public class PriceCalculator
{
    public int GetCorrectPrice(int price, int foiz)
    {
        int foizi = price * foiz / 100;
        return price - foizi;
    }
}