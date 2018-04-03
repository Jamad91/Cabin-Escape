using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable] 

public class Inventory : MonoBehaviour {

	public const int numItemSlots = 8;
	public Image[] itemImages = new Image[numItemSlots];
	public Item[] items = new Item[numItemSlots];

//	public void Start ()
//	{
//		Debug.Log("THIS: "+this.transform.parent.gameObject);
////		this.transform.parent.gameObject.SetActive(false);
//	}

	public void AddItem (Item itemToAdd)
	{
		for (int i = 0; i < items.Length; i++)
        {
            if (items[i] == null)
            {
                items[i] = itemToAdd;
                itemImages[i].sprite = itemToAdd.sprite;
                itemImages[i].enabled = true;
                return;
            }
        }
	}

	public void RemoveItem (Item itemToRemove)
	{
		for (int i = 0; i < items.Length; i++)
        {
            if (items[i] == itemToRemove)
            {
                items[i] = null;
                itemImages[i].sprite = null;
                return;
            }
        }
	}

	public void SetActive (bool active)
	{
		this.transform.parent.gameObject.SetActive(active);
	}

}