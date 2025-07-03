

Solution solution = new Solution();
solution.İkiDiziBirleşimi([ 3, 5, 7], [2, 4, 6, 8]);
public class Solution
{
    public int[] İkiDiziBirleşimi(int[] dizi1, int[] dizi2)
    {
        int[] DizilerinBirleşimi = new int[dizi1.Length + dizi2.Length];
        int indexCount = 0;
        for (int i = 0; i < dizi1.Length; i++)
        {
            for (int j = 0; j < dizi2.Length; j++)
            {
                if (dizi1[i] != dizi2[j])
                {
                    DizilerinBirleşimi[indexCount++] = dizi1[i];
                }
            }
        }
        return DizilerinBirleşimi;
    }
}