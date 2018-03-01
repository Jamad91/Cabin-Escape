using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveObject : MonoBehaviour {

	public Dictionary<string, bool> state = new Dictionary<string, bool>();

	// Use this for initialization
	void Awake () {
		
		state.Add("shield", true);
		Debug.Log("STATE: "+state["shield"]);
	}

	public void ChangeState(string itemName) {
		state[itemName] = false;
	}
	

}


//public Dictionary<Vector3, bool> IsZoneEmpty { 
//    get
//    {
//        return _isZoneEmpty;
//    }
//    set 
//    {
//        _isZoneEmpty = value;
//    }
//}
