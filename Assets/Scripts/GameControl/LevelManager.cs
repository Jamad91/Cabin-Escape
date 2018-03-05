﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public void LoadLevel (string name)
	{
		SceneManager.UnloadSceneAsync(gameObject.scene.name);
		SceneManager.LoadScene(name, LoadSceneMode.Additive);
	}

	public void QuitGame ()
	{
		Application.Quit();
	}
}
