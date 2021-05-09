using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformPool : MonoBehaviour
{
    [SerializeField]
    GameObject PlatformPrafab = default;
    
    List<GameObject> platforms = new List<GameObject>();

    Vector2 platformPozisyon;

    [SerializeField]
     float platformArasiMesafe = default;

    // Start is called before the first frame update
    void Start()
    {
        PlatformUret();
    }

    // Update is called once per frame
    void Update()
    {
        if (platforms[platforms.Count -1].transform.position.y < Camera.main.transform.position.y + EkranHesaplayicisi.instance.Yukseklik)
        {
            Debug.Log("Platform Yerlestir");

        }
    }

    void PlatformUret()
    {
        platformPozisyon = new Vector2(0, 0);
        for (int i = 0; i < 10; i++)
        {
            GameObject platform = Instantiate(PlatformPrafab, platformPozisyon, Quaternion.identity);
            platforms.Add(platform);
            platform.GetComponent<Platform>().Hareket = true;
            SonrakiPlatformPozisyon();

        }
    }

    void SonrakiPlatformPozisyon()
    {
        platformPozisyon.y += platformArasiMesafe;
        float random = Random.Range(0.0f, 1.0f);
        if (random < 0.5f)
        {
            platformPozisyon.x = EkranHesaplayicisi.instance.Genislik / 2;
            
        }else
        {
            platformPozisyon.x = -EkranHesaplayicisi.instance.Genislik / 2;

        }


    }
}
