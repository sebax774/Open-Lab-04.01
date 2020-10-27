using System;

namespace Open_Lab_04._01
{
    public class Checker
    {
        public bool DoubleLetters(string str)
        {
            int lenght = str.Length;
            for (int i = 0; i < lenght - 1; i++)
            {
                if (str[i] == str[i + 1])
                    return true;
            }
            return false;
        }
    }
}