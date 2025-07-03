


public class Solution
{

    public bool PalindromKontrol(string metin)
    {
        char[] karakterler = metin.ToCharArray();
        int bas = 0;
        int son = karakterler.Length - 1;

        while (bas < son)
        {
            if (karakterler[bas] != karakterler[son])
                return false;
            bas++;
            son--;

        }
        return true;
    }

}