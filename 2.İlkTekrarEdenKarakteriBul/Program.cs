

Solution solution = new Solution();
char value = solution.İlkTekrarEdenKarakteriBulanMetot("sabda");
public class Solution
{
    public char İlkTekrarEdenKarakteriBulanMetot(string input)
    {
        char[] inputChars = input.ToCharArray();
        for (int i = 0; i < inputChars.Length; i++)
        {
            for (int j = i + 1; j < inputChars.Length; j++)
            {
                if (inputChars[i] == inputChars[j])
                {
                    return inputChars[i];
                }
            }
        }
        return '-';
    }
}