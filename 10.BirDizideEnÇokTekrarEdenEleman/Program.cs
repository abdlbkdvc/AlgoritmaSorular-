

Solution solution = new Solution();
solution.BirDizideEnÇokTekrarEdenEleman(new int[] { 3, 3, 2, 1 });

public class Solution
{
    public int BirDizideEnÇokTekrarEdenEleman(int[] sayilar)
    {
        int sayac = 0;
        int geciciSayac;
        int enCokTekrarEdenEleman = 0;
        for (int i = 0; i < sayilar.Length; i++)
        {
            geciciSayac = 1;
            for (int j = i + 1; j < sayilar.Length; j++)
            {
                if (sayilar[i] == sayilar[j])
                {
                    geciciSayac++;
                }
            }
            if (geciciSayac > sayac)
            {
                sayac = geciciSayac;
                enCokTekrarEdenEleman = sayilar[i];
            }
        }
        return enCokTekrarEdenEleman;

    }
}
// 3, 3, 2, 1