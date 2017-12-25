using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddItem : MonoBehaviour {

	public Inventory inventory;

	void OnMouseDown ()
	{
//		Debug.Log ("clicking");
//		Debug.Log (gameObject.name);
//		Debug.Log (gameObject.tag);
//		inventory = gameObject.GetComponent<Inventory> ();
//		levelManager = GameObject.FindObjectOfType<LevelManager>();
//		inventory = gameObject.GetComponent<Inventory>();
//		GameObject.Find("nameOfObjectYourScriptIsOn").GetComponent<move>().speed
		inventory = GameObject.Find("Inventory").GetComponent<Inventory>();
		if (inventory == null) {
			Debug.Log("null time");
		}
//		inventory.AddItem();
		Debug.Log("inventory:" + inventory.items.Length);

	}
}
