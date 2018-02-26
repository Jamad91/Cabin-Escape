using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactable : MonoBehaviour {

//	public Sprite interactsWith;
//	private SpriteRenderer spriteName;
//	private Inventory inventory;
//	public InventoryManager inventoryManager;
//	public Image selectedItem;
	public Item item;


	void OnMouseDown ()
	{
////		inventory = GameObject.Find ("Inventory").GetComponent<Inventory> ();
////		inventoryManager = GameObject.Find ("InventoryManager").GetComponent<InventoryManager> ();
////		selectedItem = inventoryManager.revealSelctedSlot ();
////
////		if (selectedItem != null && selectedItem.sprite != null) {
////			if (selectedItem.sprite == interactsWith) {
////				inventory.RemoveItem(selectedItem);
////				selectedItem = null;
////			}
////		}
////
////		spriteName = gameObject.GetComponent<SpriteRenderer>();
//
		Debug.Log(item.sprite.name);
	}

}
