

Solution Solution = new Solution();
int[] değer = Solution.FibonacciBulanMetot(5);

public class Solution
{
    public int[] FibonacciBulanMetot(int n)
    {
        int[] FibonacciDizisi = new int[n];
        for (int i = 0; i < n; i++)
        {
            if (i == 0)
            {
                FibonacciDizisi[0] = 0;
            }
            else if (i == 1)
            {
                FibonacciDizisi[i] = FibonacciDizisi[0] + i;
            }
            else
            {
                FibonacciDizisi[i] = FibonacciDizisi[i - 1] + FibonacciDizisi[i - 2];
            }

        }
        return FibonacciDizisi;
    }

}