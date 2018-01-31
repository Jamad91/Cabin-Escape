using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventoryStatus : MonoBehaviour {

	private static Inventory inventory;

	static inventoryStatus singleInventory;
	public static inventoryStatus GetInstance() {
		return singleInventory;
	}

	void Start() {
//		Debug.Log("hitting: " + singleInventory);
		if (singleInventory != null) {
			// Someone ELSE is the singleton already.
			// So let's just destory ourselves before we cause trouble.
			Destroy(this.gameObject);
			return;
		}
		// If we get here, then we are "the one".
		singleInventory = this;
		GameObject.DontDestroyOnLoad(this.gameObject); //Become immortal

	}
}
