using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public float autoLoadNextLevel;

	void Start ()
	{
		if (SceneManager.GetActiveScene ().name == "Splash") {
			Invoke("LoadNextLevel", autoLoadNextLevel);
		}
	}

	public void LoadLevel (string name)
	{
		if (SceneManager.GetActiveScene ().name == "Start") {
			SceneManager.LoadScene(name);
			return;
		}
		SceneManager.UnloadSceneAsync(gameObject.scene.name);
		SceneManager.LoadScene(name, LoadSceneMode.Additive);
	}

	public void QuitGame ()
	{
		Application.Quit();
	}

	public void LoadNextLevel() {
		SceneManager.LoadScene("Start");
	}
}

