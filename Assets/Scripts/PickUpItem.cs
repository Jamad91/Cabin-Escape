using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpItem : MonoBehaviour {

//	public Sprite interactsWith;
//	private SpriteRenderer spriteName;
	private Inventory inventory;
//	public InventoryManager inventoryManager;
//	public Image selectedItem;
	public Item item;
	private SaveObject saveData;

	void Start ()
	{
		GameObject SaveObject = GameObject.FindGameObjectWithTag ("SaveObject");
		saveData = SaveObject.GetComponent<SaveObject> ();
//		Debug.Log(saveData.state.Keys.GetType());
		foreach (var key in saveData.state.Keys) {
//			Debug.Log("KEY: "+key+" VAL: "+saveData.state[key]+" GAMEOBJECT: "+gameObject);
			if (saveData.state [key] == false && key == item.name) {
				Debug.Log("GOPHER: "+ key);
				Debug.Log("OWL: " + item);
				gameObject.SetActive(false);
			}
		}
//		if (saveData.state [key] == false) {
//			gameObject.SetActive(false);
//		}

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
//		Debug.Log("hitting this shit", item);
		inventory.AddItem(item);
//		Destroy(gameObject);


		gameObject.SetActive(false);

		//THIS IS THE PROBLEM
//		**********************
		Debug.Log("GAMEOBJECT: " +gameObject+ " ITEM: "+ item.name);
		saveData.ChangeState(item.name);
//		**********************

	}

}
