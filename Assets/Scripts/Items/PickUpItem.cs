using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUps : MonoBehaviour {

	private Inventory inventory;
	public Item item;
	private SaveObject saveObject;

	void Start ()
	{
		GameObject SaveObject = GameObject.FindGameObjectWithTag ("SaveObject");
		saveObject = SaveObject.GetComponent<SaveObject> ();
		foreach (var key in saveObject.pickups.Keys) {
			if (saveObject.pickups [key] == false && key == item.name) {
				gameObject.SetActive(false);
			}
		}
	}

	void OnMouseDown ()
	{
		inventory = GameObject.Find ("Inventory").GetComponent<Inventory> ();
		inventory.AddItem(item);
		gameObject.SetActive(false);
		saveObject.ChangeState(item.name);
	}

}
