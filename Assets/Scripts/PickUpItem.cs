using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpItem : MonoBehaviour {

	private Inventory inventory;
	public Item item;
	private SaveObject saveData;

	void Start ()
	{
		GameObject SaveObject = GameObject.FindGameObjectWithTag ("SaveObject");
		saveData = SaveObject.GetComponent<SaveObject> ();
		foreach (var key in saveData.state.Keys) {
			if (saveData.state [key] == false && key == item.name) {
				gameObject.SetActive(false);
			}
		}
	}

	void OnMouseDown ()
	{
		inventory = GameObject.Find ("Inventory").GetComponent<Inventory> ();
		inventory.AddItem(item);
		gameObject.SetActive(false);
		saveData.ChangeState(item.name);
	}

}
