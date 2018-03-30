using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsLevelManager : MonoBehaviour {

	public string previousScene;
	public LevelManager levelManager;
	//	saveObject = SaveObject.GetComponent<SaveObject> ();

	public void Start ()
	{
		Debug.Log("NAME: "+levelManager.getPreviousScene());
	}

	public void updatePreviousScene (string name)
	{
		previousScene = name;
	}

	public string getPreviousScene ()
	{
		return previousScene;
	}

}
