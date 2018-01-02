using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour {

	public const int numItemSlots = 6;
	public GameObject[] items = new GameObject[numItemSlots];
	private Image itemImage;
	private Sprite selectedItem;

	public void AddItem (GameObject itemToAdd)
	{
//		Debug.Log(itemToAdd.GetComponent<SpriteRenderer>().sprite);
		for (int i = 0; i < items.Length; i++) {
			itemImage = items[i].transform.GetChild(0).GetComponent<Image>();
			Debug.Log("itemImage: "+itemImage);
			if (itemImage == null || itemImage.sprite == null) {
				itemImage.sprite = itemToAdd.GetComponent<SpriteRenderer>().sprite;
				Destroy(itemToAdd);
				return;
			}
		}	
	}

	public void RemoveItem (Image itemToRemove)
	{
//		Debug.Log("removal");
		Debug.Log (itemToRemove.GetComponent<Image> ().sprite);
		 
		for (int i = 0; i < items.Length; i++) {
			itemImage = items [i].transform.GetChild (0).GetComponent<Image> ();

			if (itemImage == itemToRemove) {
				Debug.Log("time to remove");
				Destroy(itemImage);
//				itemImage = null;
//				items[i] = null;
			}
		}
		Debug.Log(items[0]);	
	}

}
