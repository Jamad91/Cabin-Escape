using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public float autoLoadNextLevel;

	void Start ()
	{
		Debug.Log (SceneManager.GetActiveScene ().name == "Splash");
		if (SceneManager.GetActiveScene ().name == "Splash") {
			Invoke("LoadNextLevel", autoLoadNextLevel);
		}
	}

	public void LoadLevel (string name)
	{
		Debug.Log (name);
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

