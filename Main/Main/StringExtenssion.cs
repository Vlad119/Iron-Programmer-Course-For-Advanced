public static class StringExtenssion
{
    public static int CharCount(this string str, char symbol)
    {
        int charCount = 0;
        foreach (char c in str)
        {
            if (c == symbol) charCount++;
        }
        return charCount;
    }
}