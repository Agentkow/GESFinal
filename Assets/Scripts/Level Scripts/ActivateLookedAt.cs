using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivateLookedAt : MonoBehaviour {

    //script goes on player camera
    [SerializeField]
    private float maxDistanceToCheck = 2.0f;

    [SerializeField]
    private Text lookedAtObjectText;

    private IActivatable lookedAtObject;


    private void Update()
    {
        UpdateLookedAtObject();
        UpdateLookedAtObjectText();
        HandleInput();

    }

    private void UpdateLookedAtObjectText()
    {
        if (lookedAtObject == null)
        {
            lookedAtObjectText.text = string.Empty;
        }
        else
        {
            lookedAtObjectText.text = lookedAtObject.NameText;
        }
    }

    private void UpdateLookedAtObject()
    {
        Debug.DrawRay(transform.position, transform.forward * maxDistanceToCheck, Color.green);

        RaycastHit raycastHit;

        if (Physics.Raycast(transform.position, transform.forward, out raycastHit, maxDistanceToCheck))
        {
            Debug.Log(raycastHit.transform.name + " is being looked at!!");

            lookedAtObject = raycastHit.transform.GetComponent<IActivatable>();
            
        }
        else
        {
            lookedAtObject = null;
        }
    }

    private void HandleInput()
    {
        if (lookedAtObject != null && Input.GetButtonDown("Activate"))
        {
            Debug.Log("This is an IActivatable");
            lookedAtObject.DoActivate();
        }
    }
}
