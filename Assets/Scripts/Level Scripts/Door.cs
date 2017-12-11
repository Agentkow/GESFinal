using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, IActivatable {

    private Animator animator;

    [SerializeField]
    private string nameText = "Door";

    public string NameText
    {
        get
        {
            return nameText;
        }
    }

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void DoActivate()
    {
        animator.SetBool("isOpen",true);
    }

    
}
