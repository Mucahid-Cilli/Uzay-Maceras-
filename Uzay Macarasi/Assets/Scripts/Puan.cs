using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puan : MonoBehaviour
{
    int puan;
    int altin;

    bool puanTopla = true;


    [SerializeField]
    Text puanText = default;

    [SerializeField]
    Text altinText = default;

    [SerializeField]
    Text oyunBittiAltinText = default;

    [SerializeField]
    Text oyunBittiPuanText = default;

    // Start is called before the first frame update
    void Start()
    {
        altinText.text = " X " + altin;
    }

    // Update is called once per frame
    void Update()
    {
        if(puanTopla)
        {
            puan = ((int)Camera.main.transform.position.y);
            puanText.text = "PUAN: " + puan;

        }
       
    }

    public void AltinKazan()
    {
        altin++;
        altinText.text = " X " + altin;
    }

    public void OyunBitti()
    {
        puanTopla = false;
        oyunBittiPuanText.text = "PUAN: " + puan;
        oyunBittiAltinText.text = " X " + altin;
    }
}
