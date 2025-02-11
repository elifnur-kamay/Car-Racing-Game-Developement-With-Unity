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
        // Baþlangýçta seslerin oynatýlmamasý için ses kaynaklarýný durdur
        engineStartSound.Stop();
        engineLoopSound.Stop();
    }

    void Update()
    {
        // Motorun çalýþmasýný baþlat
        if (!engineStarted && Input.GetKeyDown(KeyCode.W))
        {
            StartCoroutine(StartEngine());
            engineStarted = true;
        }
    }

    IEnumerator StartEngine()
    {
        // Motor baþlangýç sesini oynat
        engineStartSound.Play();
        // Motor baþlangýç sesinin süresi kadar bekle
        yield return new WaitForSeconds(engineStartSound.clip.length);
        // Sürekli motor sesini oynat
        engineLoopSound.Play();
    }
}

