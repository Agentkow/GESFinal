using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryObject : MonoBehaviour, IActivatable
{
    [SerializeField]
    private string nameText;

    [SerializeField]
    private string descriptionText;

    private InventoryMenu inventoryMenu;
    private MeshRenderer meshRenderer;
    private Collider bump;

    public string NameText
    {
        get
        {
            return nameText;
        }
    }

    public string DescriptionText { get { return descriptionText; } }

    private void Start()
    {
        inventoryMenu = FindObjectOfType<InventoryMenu>();
        meshRenderer = GetComponent<MeshRenderer>();
        bump = GetComponent<Collider>();
    }

    public void DoActivate()
    {
        inventoryMenu.PlayerInventory.Add(this);
        meshRenderer.enabled = false;
        bump.enabled = false;
    }




}
