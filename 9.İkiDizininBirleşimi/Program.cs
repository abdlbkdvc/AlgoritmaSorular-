

Solution solution = new Solution();
solution.İkiDiziBirleşimi(new int[] { 3, 5, 7 }, new int[] { 1, 2, 4, 6 });
public class Solution
{
    public int[] İkiDiziBirleşimi(int[] dizi1, int[] dizi2)
    {
        int[] DizilerinBirleşimi = new int[dizi1.Length + dizi2.Length];
        int indexCount = 0;
        for (int i = 0; i < dizi1.Length; i++)
        {
            DizilerinBirleşimi[indexCount++] = dizi1[i];
        }
        for (int j = 0; j < dizi2.Length; j++)
        {
            DizilerinBirleşimi[indexCount++] = dizi2[j];
        }
        return DizilerinBirleşimi;
    }
}