using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactable : MonoBehaviour {

	public Sprite interactsWith;
	private SpriteRenderer spriteName;
	private Inventory inventory;
	public InventoryManager inventoryManager;
	public Image selectedItem;


	void OnMouseDown ()
	{
		inventory = GameObject.Find ("Inventory").GetComponent<Inventory> ();
		inventoryManager = GameObject.Find ("InventoryManager").GetComponent<InventoryManager> ();
		selectedItem = inventoryManager.revealSelctedSlot ();
		Debug.Log (selectedItem.sprite);

		if (selectedItem != null && selectedItem.sprite != null) {
//			Debug.Log ("interactable selected: " + selectedItem.sprite);
			if (selectedItem.sprite == interactsWith) {
				Debug.Log("match!");
				Debug.Log(selectedItem.GetType());
				inventory.RemoveItem(selectedItem);
			}

		}

//		Debug.Log(interactsWith);

		spriteName = gameObject.GetComponent<SpriteRenderer>();
//		Debug.Log("gameobject: " + spriteName);
	}
}
