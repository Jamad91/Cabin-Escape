using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour {

	public void LoadLevel (string name)
	{
		Debug.Log("Level Load Requested for: " + name);
		Application.LoadLevel(name);
	}

	public void QuitGame ()
	{
		Debug.Log("Qutting Game");
		Application.Quit();
	}
}
