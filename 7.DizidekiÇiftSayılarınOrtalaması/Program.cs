


//7.Dizideki çift sayıların ortalaması.
Solution solution = new Solution();
int ortalamnınDeğeri = solution.ÇiftSayılarıBulanMetot([15, 24, 16, 33]);

public class Solution
{
    public int ÇiftSayılarıBulanMetot(int[] sayilar)
    {
        int çiftSayılarınToplamı = 0;
        int ortalama = 0;
        int çiftSayıSayısı = 0;
        for (int i = 0; i < sayilar.Length; i++)
        {
            if (sayilar[i] % 2 == 0)
            {
                çiftSayıSayısı++;
                çiftSayılarınToplamı += sayilar[i];
            }
            else
            {
                return -1;
            }
        }
        ortalama = çiftSayılarınToplamı / çiftSayıSayısı;
        return ortalama;
    }
}