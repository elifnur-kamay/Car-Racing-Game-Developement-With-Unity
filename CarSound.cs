using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSound : MonoBehaviour
{
    public AudioSource engineStartSound;
    public AudioSource engineLoopSound;
    private bool engineStarted = false;

    void Start()
    {
        // Ba�lang��ta seslerin oynat�lmamas� i�in ses kaynaklar�n� durdur
        engineStartSound.Stop();
        engineLoopSound.Stop();
    }

    void Update()
    {
        // Motorun �al��mas�n� ba�lat
        if (!engineStarted && Input.GetKeyDown(KeyCode.W))
        {
            StartCoroutine(StartEngine());
            engineStarted = true;
        }
    }

    IEnumerator StartEngine()
    {
        // Motor ba�lang�� sesini oynat
        engineStartSound.Play();
        // Motor ba�lang�� sesinin s�resi kadar bekle
        yield return new WaitForSeconds(engineStartSound.clip.length);
        // S�rekli motor sesini oynat
        engineLoopSound.Play();
    }
}

