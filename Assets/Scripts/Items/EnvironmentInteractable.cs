using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentInteractable : MonoBehaviour {

	public EnvironmentItem environmentItem;
	private SlotSelection slotSelection;
	private Inventory inventory;
	private Item item;

	void Start() {
		slotSelection = GameObject.Find ("SlotSelection").GetComponent<SlotSelection> ();
		inventory = GameObject.Find ("Inventory").GetComponent<Inventory> ();
	}

	void OnMouseDown ()
	{
		for (int i = 0; i < inventory.itemImages.Length; i++) {
			Debug.Log("ITEM IMAGES SPRITE: "+inventory.itemImages[i].sprite.name);
			Debug.Log("SELECTED SLOT SPRITE: "+slotSelection.revealSelctedSlot().sprite.name);
			Debug.Log(environmentItem.combinesWith);
			Debug.Log("TRUE OR FALSE? "+inventory.itemImages[i].sprite.name.ToString() == slotSelection.revealSelctedSlot().sprite.name.ToString());
			if (inventory.itemImages[i].sprite.name == slotSelection.revealSelctedSlot().sprite.name && environmentItem.combinesWith == slotSelection.revealSelctedSlot().sprite.name) {
				Debug.Log("hitting");
				item = inventory.items[i];
				inventory.RemoveItem(item);
				slotSelection.resetSelectedSlot();
				return;
			}
		}
	}

}
