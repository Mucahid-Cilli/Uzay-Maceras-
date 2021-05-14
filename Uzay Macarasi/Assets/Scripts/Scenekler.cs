using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Scenekler 
{
    public static string Kolay = "Kolay";
    public static string Normal = "Normal";
    public static string Zor = "Zor";

    public static void KolayDegerAta(int Kolay)
    {
        PlayerPrefs.SetInt(Scenekler.Kolay, Kolay);
    }

    public static int KolayDegerOku()
    {
        return PlayerPrefs.GetInt(Scenekler.Kolay);
    }

    public static void NormalDegerAta(int Normal)
    {
        PlayerPrefs.SetInt(Scenekler.Normal, Normal);
    }

     public static int NormalDegerOku()
    {
        return PlayerPrefs.GetInt(Scenekler.Normal);
    }

    public static void ZorDegerAta(int Zor)
    {
        PlayerPrefs.SetInt(Scenekler.Zor, Zor);
    }

     public static int ZorDegerOku()
    {
        return PlayerPrefs.GetInt(Scenekler.Zor);
    }

    public static bool KayitVarmi()
    {
        if(PlayerPrefs.HasKey(Scenekler.Kolay) || 
        PlayerPrefs.HasKey(Scenekler.Normal) || 
        PlayerPrefs.HasKey(Scenekler.Zor))
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}
