using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saver : MonoBehaviour {
	public Dictionary<string, bool> pickedUpItems = new Dictionary<string, bool>();

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Awake ()
	{
		Debug.Log("yoo hoo boo");

	}
}
