using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour {

	public const int numItemSlots = 6;
	public GameObject[] items = new GameObject[numItemSlots];
	private Image itemImage;
	private Sprite selectedItem;
	public InventoryManager inventoryManager;


	public void AddItem (GameObject itemToAdd)
	{
		for (int i = 0; i < items.Length; i++) {
			itemImage = items [i].transform.GetChild (0).GetComponent<Image> ();
			if (itemImage == null || itemImage.sprite == null) {
				itemImage.sprite = itemToAdd.GetComponent<SpriteRenderer>().sprite;
				Destroy(itemToAdd);
				return;
			}
		}	
	}

	public void RemoveItem (Image itemToRemove)
	{
		for (int i = 0; i < items.Length; i++) {
			itemImage = items [i].transform.GetChild (0).GetComponent<Image> ();
			if (itemImage == itemToRemove) {
				itemToRemove.transform.localScale -= new Vector3 (0.1F, 0.1F, 0);
				itemImage.sprite = null;
				inventoryManager.clearSelectedSlot();

//				itemImage.transform.localScale -= new Vector3 (0.1F, 0.1F, 0);
				return;
			}
		}
	}

}
