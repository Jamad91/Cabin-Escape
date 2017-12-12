using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class GameControl : MonoBehaviour {

	public static GameControl control;

	public float health;
	public float experience;

	void Awake ()
	{
		if (control == null) {
			DontDestroyOnLoad(gameObject);
			control = this;
		} else if(control != this) {
			Destroy(gameObject);
		}
	}
	
	void OnGUI ()
	{
		GUI.Label(new Rect(10,10,100,50), "Health: " + health);
		GUI.Label(new Rect(10,40,100,30), "Experience: " + experience);
	}
}
