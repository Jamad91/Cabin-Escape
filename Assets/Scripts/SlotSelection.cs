using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SlotSelection : MonoBehaviour {

	private static Inventory inventory;
	public static Image selectedSlot;
	public Transform inventoryItems;

	public void SelectItem (Image itemImage)
	{
		inventory = GameObject.Find ("Inventory").GetComponent<Inventory> ();

		for (int i = 0; i < inventory.items.Length; i++) {
			if (inventory.items [i] != null) {
				if (selectedSlot == null) {
					selectedSlot = itemImage;
					selectedSlot.transform.localScale += new Vector3 (0.1F, 0.1F, 0);
				} else if (selectedSlot == itemImage) {
					selectedSlot.transform.localScale -= new Vector3 (0.1F, 0.1F, 0);
					selectedSlot = null;
				}
			}
		}
	}

	public Image revealSelctedSlot ()
	{
		return selectedSlot;
	}

	public void resetSelectedSlot() {
		selectedSlot.transform.localScale -= new Vector3 (0.1F, 0.1F, 0);
		selectedSlot = null;
	}
}