using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactable : MonoBehaviour {

//	public Sprite interactsWith;
//	private SpriteRenderer spriteName;
	private Inventory inventory;
//	public InventoryManager inventoryManager;
//	public Image selectedItem;
	public Item item;
	public SaveObject saveData;

	void Start ()
	{
//		HingeJoint hinge = GetComponent<HingeJoint>();
//		GameObject ZD = GameObject.FindGameObjectWithTag ("Zone Manager");
		GameObject SaveObject = GameObject.FindGameObjectWithTag("SaveObject");
		saveData = SaveObject.GetComponent<SaveObject>();


		Debug.Log("SAVE DATA: "+saveData);
		if (saveData.state ["shield"] == false) {
			gameObject.SetActive(false);
		}

	}

	void OnMouseDown ()
	{
		Debug.Log("SAVE DATA: "+saveData);
		inventory = GameObject.Find ("Inventory").GetComponent<Inventory> ();
////		inventoryManager = GameObject.Find ("InventoryManager").GetComponent<InventoryManager> ();
////		selectedItem = inventoryManager.revealSelctedSlot ();
////
////		if (selectedItem != null && selectedItem.sprite != null) {
////			if (selectedItem.sprite == interactsWith) {
////				inventory.RemoveItem(selectedItem);
////				selectedItem = null;
////			}
////		}
////
////		spriteName = gameObject.GetComponent<SpriteRenderer>();
//
		inventory.AddItem(item);
//		Destroy(gameObject);
		gameObject.SetActive(false);
		saveData.ChangeState("shield");
	}

}
