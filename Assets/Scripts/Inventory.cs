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

//	static Inventory singleInventory;
//	public static Inventory GetInstance() {
//		return singleInventory;
//	}
//
//	void Start() {
//		Debug.Log("hitting: " + singleInventory);
//		if (singleInventory != null) {
//			// Someone ELSE is the singleton already.
//			// So let's just destory ourselves before we cause trouble.
//			Destroy(this.gameObject);
//			return;
//		}
//		// If we get here, then we are "the one".
//		singleInventory = this;
//		GameObject.DontDestroyOnLoad(this.gameObject); //Become immortal
//
//	}

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
