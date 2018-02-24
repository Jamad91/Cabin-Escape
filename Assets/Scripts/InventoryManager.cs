using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InventoryManager : MonoBehaviour {

	private static Inventory inventory;
	public static Image selectedSlot;
	public Image itemSlot;

	public void SelectItem (Image itemImage)
	{
		
		inventory = GameObject.Find ("Inventory").GetComponent<Inventory> ();

//		Image itemSlot = itemImage.GetComponent<Image> ();
		Debug.Log (itemImage.sprite);
		for (int i = 0; i < inventory.items.Length; i++) {
			
//			if (itemSlot.sprite != null && Mathf.Abs(inventory.items [i].GetComponent<Image> ().GetInstanceID () - itemImage.GetInstanceID ()) == Mathf.Abs (2)) {
//				if (selectedSlot == null || selectedSlot != itemImage && itemSlot.sprite != null) {
//					selectedSlot = itemImage;
//					selectedSlot.transform.localScale += new Vector3 (0.1F, 0.1F, 0);
//				} else if (selectedSlot == itemImage) {
//					selectedSlot.transform.localScale -= new Vector3 (0.1F, 0.1F, 0);
//					selectedSlot = null;
//				}
//			}

		}

	}

	public Image revealSelctedSlot ()
	{
		return selectedSlot;
	}

	public void clearSelectedSlot ()
	{
		selectedSlot = null;
	}

//	public void RemoveItem (Image itemToRemove) {
//		Debug.Log("removal of "+  itemToRemove.sprite);
//		for (int i = 0; i < items.Length; i++) {
////			itemImage = items [i].transform.GetChild (0).GetComponent<Image> ();
////
////			if (itemImage == itemToRemove) {
////				Debug.Log("time to remove");
//////				Destroy(itemToRemove);
////				itemImage = null;
//////				items[i] = null;
////				return;
////			}
//		}
////		Debug.Log(items[0]);	
//	}
}