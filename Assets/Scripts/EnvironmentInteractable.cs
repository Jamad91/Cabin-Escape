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
	}

	void OnMouseDown ()
	{
		for (int i = 0; i < inventory.itemImages.Length; i++) {
			if (inventory.itemImages[i].sprite.name == slotSelection.revealSelctedSlot().sprite.name) {
				item = inventory.items[i];
				inventory.RemoveItem(item);
				slotSelection.resetSelectedSlot();
				return;
			}
		}
	}

}
