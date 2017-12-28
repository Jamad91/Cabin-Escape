using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour {

	public GameObject[] items = new GameObject[numItemSlots];
	public const int numItemSlots = 6;
	private Image itemImage;

	public void AddItem (GameObject itemToAdd)
	{
		
		for (int i = 0; i < items.Length; i++) {
//			
			if (items[i].transform.GetChild(0).GetComponent<Image>().sprite == null) {
				itemImage = items[i].transform.GetChild(0).GetComponent<Image>();
				itemImage.sprite = itemToAdd.GetComponent<SpriteRenderer>().sprite;
				Destroy(itemToAdd);
				return;
			}
		}	
	}

//	public void RemoveItem (Item itemToRemove) {
//		for (int i = 0; i < items.Length; i++) {
//			if (items [i] == itemToRemove) {
//				items[i] = null;
//				itemImages[i].sprite = null;
//				itemImages[i].enabled = false;
//				return;
//			}
//		}	
//	}

}
