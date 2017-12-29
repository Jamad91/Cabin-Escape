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
		for (int i = 0; i < items.Length; i++) {
			if (items[i].transform.GetChild(0).GetComponent<Image>().sprite == null) {
				itemImage = items[i].transform.GetChild(0).GetComponent<Image>();
				itemImage.sprite = itemToAdd.GetComponent<SpriteRenderer>().sprite;
				Destroy(itemToAdd);
				return;
			}
		}	
	}

	public void RemoveItem (GameObject itemToRemove) {
		Debug.Log("removal");
		Debug.Log(itemToRemove.GetComponent<Image>().sprite);
		for (int i = 0; i < items.Length; i++) {
			if (items [i] == itemToRemove) {
				items[i] = null;
				return;
			}
		}	
	}

}
