using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public float autoLoadNextLevel;
	public string leftRoomName;
	public string rightRoomName;

	void Start ()
	{
		if (SceneManager.GetActiveScene ().name == "Splash") {
			Invoke("LoadNextLevel", autoLoadNextLevel);
		}
	}

	void Update ()
	{
		if (Input.GetKeyDown ("right") && rightRoomName.Length > 0) {
			LoadLevel (rightRoomName);
		} else if (Input.GetKeyDown ("left") && leftRoomName.Length > 0) {
			LoadLevel (leftRoomName);
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

