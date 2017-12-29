using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddItem : MonoBehaviour {

	private Inventory inventory;

	void OnMouseDown ()
	{
		inventory = GameObject.Find("Inventory").GetComponent<Inventory>();
		inventory.AddItem(gameObject);
	}
}