

//En Küçük Pozitif Olmayan Sayıı Bulma
Solution solution = new Solution();
solution.EnKüçükPozitifOlmayanSayıyıBulma([-1, 5, -3, -6, 5]);
public class Solution
{
    public int EnKüçükPozitifOlmayanSayıyıBulma(int[] sayilar)
    {
        int taşıyıcıVeGeçiciDeğişken = 0;


        for (int i = 0; i < sayilar.Length; i++)
        {
            for (int j = i + 1; j < sayilar.Length; j++)
            {
                if (sayilar[i] > sayilar[j])
                {
                    taşıyıcıVeGeçiciDeğişken = sayilar[i];
                    sayilar[i] = sayilar[j];
                    sayilar[j] = taşıyıcıVeGeçiciDeğişken;
                }


            }
        }
        return sayilar[0];
    }
}