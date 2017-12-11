using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wifi : MonoBehaviour, IActivatable
{

    [SerializeField]
    private string nameText = "Wifi station";

    public bool reset = false;

    public string NameText
    {
        get
        {
            string returnLine = nameText;

            if (reset)
            {
                returnLine += " reset";
            }
            
            return returnLine;
        }
    }

   

    public void DoActivate()
    {
        reset = true;
    }
}
