using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muzik : MonoBehaviour
{
    public AudioSource genelMuzik;
    private bool isPlaying = false;

    private void Start()
    {
        genelMuzik.Play();
    }

    public void sesAcKapa()
    {
        if (isPlaying)
        {
            genelMuzik.Pause();
            isPlaying = false;
        }
        else
        {
            genelMuzik.Play();
            isPlaying = true;
        }
    }
    public void cikis()
    {
        Application.Quit();
    }
}