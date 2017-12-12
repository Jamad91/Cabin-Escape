using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdjustScript : MonoBehaviour {

	void OnGUI ()
	{
		if (GUI.Button (new Rect (100, 200, 110, 30), "Health up")) {
			GameControl.control.health += 10;
		}
		if (GUI.Button (new Rect (100, 240, 110, 30), "Health down")) {
			GameControl.control.health -= 10;
		}
		if (GUI.Button (new Rect (100, 280, 110, 30), "Experience up")) {
			GameControl.control.experience += 10;
		}
		if (GUI.Button (new Rect (100, 320, 110, 30), "Experience down")) {
			GameControl.control.experience -= 10;
		}
	}
}
