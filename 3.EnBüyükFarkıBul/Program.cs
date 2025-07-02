

//Bir dizideki iki sayı arasındaki en büyük fark.


static void Main(string[] args)
{
    Solution solution = new Solution();
    solution.DizidekiEnBüyükFark(new int[] { 1, 2, 3, 4, 5 });
}
public class Solution
{
    public int[] Sıralama(int[] sayi)
    {
        int taşıyıcıDeğişken = 0;
        for (int i = 0; i < sayi.Length; i++)
        {
            for (int j = i + 1; j < sayi.Length; j++)
            {
                if (sayi[i] > sayi[j])
                {
                    taşıyıcıDeğişken = sayi[i];
                    sayi[i] = sayi[j];
                    sayi[j] = taşıyıcıDeğişken;
                }
            }
        }

        return sayi;
    }
    public int DizidekiEnBüyükFark(int[] sayi)
    {
        int[] sıralanmışDizi = Sıralama(sayi);
        int sum = 0;

        int enKucuk = sıralanmışDizi[0];
        int enBuyuk = sıralanmışDizi[sıralanmışDizi.Length - 1];

        sum = enBuyuk - enKucuk;
        return sum;
    }
}
