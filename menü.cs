using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menü : MonoBehaviour

{
    public GameObject menüpaneli;

 public void oyunubaslat()
    {
        Application.LoadLevel(1);
        Time.timeScale = 1.0f;
    }
    public void menüpaneliac()
    {
        menüpaneli.SetActive(true);
        Time.timeScale = 0.0f;
    }
    public void oyunadevamet()
    {
        menüpaneli.SetActive(false);
        Time.timeScale = 1.0f;
    }
    public void anamenüyegit()
    {
        Application.LoadLevel(0);
    }
}
