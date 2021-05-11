using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuKontrol : MonoBehaviour
{
    [SerializeField]
    Sprite[] muzikIkonlar = default;

    [SerializeField]
    Button muzikButon = default;

    bool muzikAcik = true;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OyunuBaslat()
    {
        SceneManager.LoadScene("Oyun");

    }

     public void EnYuksekPuan()
    {
        SceneManager.LoadScene("Puan");

    }

     public void Ayarlar()
    {
        SceneManager.LoadScene("Ayarlar");

    }

    public void Muzik()
    {
        if(muzikAcik)
        {
            muzikAcik = false;
            muzikButon.image.sprite = muzikIkonlar[0];
        }
        else
        {
            muzikAcik = true;
            muzikButon.image.sprite = muzikIkonlar[1];

        }
    }
}
