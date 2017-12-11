using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Computer : MonoBehaviour, IActivatable
{

    [SerializeField]
    private string nameText = "Computer";

    public bool resetWifi;

    public void Update()
    {
        resetWifi = GameObject.Find("Wifi_station").GetComponent<Wifi>().reset;
    }

    public string NameText
    {
        get
        {
            string returnLine = nameText;

            if (resetWifi)
            {
                returnLine += " ";
            }
            else
            {
                returnLine += " (No wifi)";
            }

            return returnLine;
        }
    }

    public void DoActivate()
    {
        if (resetWifi)
        {
            SceneManager.LoadScene("Win");
        }
        
    }
}
