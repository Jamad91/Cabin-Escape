using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentInteractable : MonoBehaviour {

	public EnvironmentItem environmentItem;
	private SlotSelection slotSelection;
	private Inventory inventory;
	public Item item;

	void Start() {
		slotSelection = GameObject.Find ("SlotSelection").GetComponent<SlotSelection> ();
		inventory = GameObject.Find ("Inventory").GetComponent<Inventory> ();
		Debug.Log("WHOOOOOS NELLY: "+inventory);
	}

	void OnMouseDown ()
	{
//		Debug.Log ("clicking: " + slotSelection.revealSelctedSlot ().sprite.name);

		for (int i = 0; i < inventory.itemImages.Length; i++) {
			if (inventory.itemImages[i].sprite.name == slotSelection.revealSelctedSlot().sprite.name) {
//				Debug.Log(inventory.itemImages[i].sprite.name);
				item = inventory.items[i];
				inventory.RemoveItem(item);
				Debug.Log(item.name);
				return;
			}
		}
//		Debug.Log ("ITEM: " + item.combinesWith.GetType());
//		Debug.Log("TRUE/FALSE! "+inventory.revealSelctedSlot ().sprite.name == item.combinesWith);

//		NEED TO DETERMINE WHAT NUMBER SLOT I'VE SELECTED. IF I CAN DO THAT, I CAN GET THE ITEM FROM inventory.items[i]
//		WITH THAT I CAN CALL inventory.RemoveItem(inventory.items[i]) AND REMOVE THE ITEM
//		I THEN NEED TO FIGURE OUT A WAY TO REVERT SELECTED SLOT TO NULL, POSSIBLY WITH slotSelection.clearSelectedSlot();
		if (slotSelection.revealSelctedSlot ().sprite.name == environmentItem.combinesWith) {
			
		}
	}
}
