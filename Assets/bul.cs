using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bul : MonoBehaviour
{
    public InputField girisDegeri;
    public GameObject basariFoto;

    private void Start()
    {
        basariFoto.SetActive(false);
    }
    public void bulYildiz()
    {
        if(girisDegeri.text=="Y�ld�z" || girisDegeri.text=="YILDIZ" || girisDegeri.text == "y�ld�z")
        {
            basariFoto.SetActive(true);
        }
    }
}
