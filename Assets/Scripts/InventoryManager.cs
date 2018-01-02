using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InventoryManager : MonoBehaviour {

	private Inventory inventory;
	public static Image selectedSlot;
	public Image itemSlot;
	public Image blank;

	public void SelectItem (Image itemImage)
	{
		
		inventory = GameObject.Find ("Inventory").GetComponent<Inventory> ();

		Image itemSlot = itemImage.GetComponent<Image> ();
	
		for (int i = 0; i < inventory.items.Length; i++) {
			
			if (itemSlot.sprite != null && inventory.items [i].GetComponent<Image> ().GetInstanceID () - itemImage.GetInstanceID () == 2) {
				if (selectedSlot == null || selectedSlot != itemImage && itemSlot.sprite != null) {
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

	public void RemoveItem () {
		Debug.Log("Selected: " );
	}
}