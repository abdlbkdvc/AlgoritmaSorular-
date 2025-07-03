


Solution solution = new Solution();
solution.İkiDizidekiOrtakElemanlarıBulanMetot([3, 4, 5], [3, 4, 5]);
public class Solution()
{

    public int[] İkiDizidekiOrtakElemanlarıBulanMetot(int[] dizi1, int[] dizi2)
    {

        int[] OrtakElemanBulanDizi = new int[dizi1.Length];
        int diziIndexDeğeri = 0;
        for (int i = 0; i < dizi1.Length; i++)
        {
            for (int j = 0; j < dizi2.Length; j++)
            {
                if (dizi1[i] == dizi2[j])
                {
                    OrtakElemanBulanDizi[diziIndexDeğeri++] = dizi1[i];
                }
            }
        }
        return OrtakElemanBulanDizi;
    }
}