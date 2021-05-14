using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AyarlarKontrol : MonoBehaviour
{
    public Button KolayButon, NormalButon, ZorButon;


    // Start is called before the first frame update
    void Start()
    {
        if(Scenekler.KolayDegerOku() == 1)
        {
            KolayButon.interactable = false;
            NormalButon.interactable = true;
            ZorButon.interactable = true;
        }
         if(Scenekler.NormalDegerOku() == 1)
        {
            KolayButon.interactable = true;
            NormalButon.interactable = false;
            ZorButon.interactable = true;
        }
         if(Scenekler.ZorDegerOku() == 1)
        {
            KolayButon.interactable = true;
            NormalButon.interactable = true;
            ZorButon.interactable = false;
        }
    }

    

    public void SecenekSecildi(string seviye)
    {
        switch (seviye)
        {
            case "Kolay":
                Scenekler.KolayDegerAta(1);
                Scenekler.NormalDegerAta(0);
                Scenekler.ZorDegerAta(0);
                 KolayButon.interactable = false;
                 NormalButon.interactable = true;
                 ZorButon.interactable = true;
            break;
                 case "Normal":
                 Scenekler.KolayDegerAta(0);
                Scenekler.NormalDegerAta(1);
                Scenekler.ZorDegerAta(0);
                 KolayButon.interactable = true;
                 NormalButon.interactable = false;
                 ZorButon.interactable = true;
            break;
                 case "Zor":
                 Scenekler.KolayDegerAta(0);
                Scenekler.NormalDegerAta(0);
                Scenekler.ZorDegerAta(1);
                 KolayButon.interactable = true;
                 NormalButon.interactable = true;
                 ZorButon.interactable = false;
            break;
            default:
                break;
        }

    }

    public void AnaMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
