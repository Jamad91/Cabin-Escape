using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InventoryManager : MonoBehaviour {

	private Inventory inventory;
	private Image selectedSlot;
	public Image itemSlot;

	public void SelectItem (Image itemImage)
	{
		inventory = GameObject.Find ("Inventory").GetComponent<Inventory> ();

		Image itemSlot = itemImage.GetComponent<Image> ();

		Debug.Log (itemSlot.sprite);
		for (int i = 0; i < inventory.items.Length; i++) {
			
			if (inventory.items [i].GetComponent<Image> ().GetInstanceID () - itemImage.GetInstanceID () == 2) {
				if (selectedSlot == null || selectedSlot != itemImage && itemSlot.sprite != null) {
					if (selectedSlot != null) {
						selectedSlot.transform.localScale -= new Vector3(0.1F, 0.1F, 0);
					}

					selectedSlot = itemImage;
					selectedSlot.transform.localScale += new Vector3(0.1F, 0.1F, 0);
				}
			}
		}
	}

}
