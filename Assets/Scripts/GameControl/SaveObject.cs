using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveObject : MonoBehaviour {

	public Dictionary<string, bool> state;
	public Dictionary<string, bool> conditions = new Dictionary<string, bool>();
	public GameObject Gogo;

	void Awake () {
		state = new Dictionary<string, bool>();

		conditions["haveKettle"] = false;
		conditions["haveFullBaloon"] = false;
		conditions["haveSlit1"] = false;
		conditions["haveSlit2"] = false;
		conditions["haveSlit3"] = false;
		conditions["haveCircularStrip"] = false;
		conditions["haveEmptyBaloon"] = false;
		conditions["haveLamp"] = false;
		conditions["haveOil"] = false;
		conditions["haveMatches"] = false;
		conditions["haveAntler1"] = false;
		conditions["haveAntler2"] = false;
		conditions["haveKey"] = false;
		conditions["placedLamp"] = false;
		conditions["placedStrip"] = false;
		conditions["placedBalloon"] = false;
		conditions["kettleHasWater"] = false;
		conditions["kettleIsBoiling"] = false;
		conditions["lampHasOil"] = false;
		conditions["lampIsLit"] = false;
		conditions["baloonIsInflated"] = false;
		conditions["antler1Placed"] = false;
		conditions["antler2Placed"] = false;
		conditions["stoveGasOn"] = false;
		conditions["stoveGasLit"] = false;
		conditions["dial1Correct"] = false;
		conditions["dial2Correct"] = false;
		conditions["dial3Correct"] = false;
		conditions["slit1Placed"] = false;
		conditions["slit2Placed"] = false;
		conditions["slit3Placed"] = false;
		conditions["stripCompleted"] = false;



	}

	public void ChangeState(string itemName) {
		state[itemName] = false;
	}

	public void ToggleCondition (string conditionName)
	{
		conditions[conditionName] = !conditions[conditionName];
	}

}
