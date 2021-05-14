using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OyunKontrol : MonoBehaviour
{
    public GameObject oyunBittiPanel;
    public GameObject joystick;
    public GameObject zıplamaButonu;
    public GameObject tabela;
    public GameObject menuButonu;
    public GameObject slider;

    // Start is called before the first frame update
    void Start()
    {
        oyunBittiPanel.SetActive(false);
        UIAc();
    }

    
    public void OyunuBitir()
    {
        oyunBittiPanel.SetActive(true);
        FindObjectOfType<Puan>().OyunBitti();
        UIKapat();

    }

    public void AnaMenuyeDon()
    {
        SceneManager.LoadScene("Menu");
    }

    public void TekrarOyna()
    {
        SceneManager.LoadScene("Oyun");
    }

    void UIAc()
    {
        joystick.SetActive(true);
        zıplamaButonu.SetActive(true);
        tabela.SetActive(true);
        menuButonu.SetActive(true);
        slider.SetActive(true);


    }

    void UIKapat()
    {
         joystick.SetActive(false);
        zıplamaButonu.SetActive(false);
        tabela.SetActive(false);
        menuButonu.SetActive(false);
        slider.SetActive(false);

    }
}
