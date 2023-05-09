using System;
using System.Linq;

public static class Isogramma
{
    public static bool Verifica(string word)
    {

        word = word.ToLower();

        for (int i = 0; i < word.Length; i++)
            for (int j = i+1; j < word.Length; j++)
                if( (word[i] == word[j] ) && ( word[i] != ' ' ) && ( word[i] != '-' ))
                    return false;

        return true;
    }

}
