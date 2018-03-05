using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentInteractable : MonoBehaviour {

	public EnvironmentItem item;
	private SlotSelection slotSelection;
	private Inventory inventory;

	void Start() {
		slotSelection = GameObject.Find ("SlotSelection").GetComponent<SlotSelection> ();
		inventory = GameObject.Find ("Inventory").GetComponent<Inventory> ();
		Debug.Log("WHOOOOOS NELLY: "+inventory);
	}

	void OnMouseDown ()
	{
//		Debug.Log ("clicking: " + inventory.revealSelctedSlot ().sprite.name);
//		Debug.Log ("ITEM: " + item.combinesWith.GetType());
//		Debug.Log("TRUE/FALSE! "+inventory.revealSelctedSlot ().sprite.name == item.combinesWith);

//		NEED TO DETERMINE WHAT NUMBER SLOT I'M CLICKING. IF I CAN DO THAT, I CAN GET THE ITEM FROM inventory.items[i]
//		WITH THAT I CAN CALL inventory.RemoveItem(inventory.items[i]) AND REMOVE THE ITEM
//		I THEN NEED TO FIGURE OUT A WAY TO REVERT SELECTED SLOT TO NULL, POSSIBLY WITH slotSelection.clearSelectedSlot();

		if (slotSelection.revealSelctedSlot ().sprite.name == item.combinesWith) {
			
		}
	}
}
