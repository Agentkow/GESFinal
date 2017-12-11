﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericObject: MonoBehaviour, IActivatable {

    [SerializeField]
    private string nameText;

    public string NameText
    {
        get
        {
            return nameText;
        }
    }
    public void DoActivate()
    {
        Debug.Log(transform.name +" was activated!");
    }

   
}