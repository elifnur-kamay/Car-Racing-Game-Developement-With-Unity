using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class arabasatınal : MonoBehaviour
{
    public float para;
    public GameObject[] arabalar;
    public GameObject panel;
    public bool a1, a2, a3;
    public Text sarıarabayazısı, kırmızıarabayazısı, griarabayazısı;
    void Start()
    {

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            panel.SetActive(true);
        }

    }
    public void standartaraba()
    {
        for (int i = 0; i < arabalar.Length; i++)
        {
            arabalar[i].SetActive(false);
            arabalar[0].SetActive(true);
            panel.SetActive(false);

        }
    }

    public void sarıaraba()
    {
        if (para >= 200 || a1)
        {
            para -= 200;
            for (int i = 0; i < arabalar.Length; i++)
            {
                arabalar[i].SetActive(false);
                arabalar[1].SetActive(true);
                panel.SetActive(false);
                a1 = true;
                sarıarabayazısı.text = ("Seç");
            }
        }

    }
    public void kırmızıaraba()
    {
        if (para >= 400 || a2)
        {
            para -= 400;
            for (int i = 0; i < arabalar.Length; i++)
            {
                arabalar[i].SetActive(false);
                arabalar[2].SetActive(true);
                panel.SetActive(false);
                a2 = true;
                kırmızıarabayazısı.text = ("Seç");
            }
        }

    }
    public void griaraba()
    {
        if (para >= 800 || a3)
        {
            para -= 800;
            for (int i = 0; i < arabalar.Length; i++)
            {
                arabalar[i].SetActive(false);
                arabalar[3].SetActive(true);
                panel.SetActive(false);
                a3 = true;
                griarabayazısı.text = ("Seç");
            }
        }

    }
}