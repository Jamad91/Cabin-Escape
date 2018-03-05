using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveObject : MonoBehaviour {

	public Dictionary<string, bool> state;

	void Awake () {
		state = new Dictionary<string, bool>();
	}

	public void ChangeState(string itemName) {
		state[itemName] = false;
	}

}