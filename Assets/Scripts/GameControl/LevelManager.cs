using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public float autoLoadNextLevel;
	public string leftRoomName;
	public string rightRoomName;
	public string currentScene;
	private SaveObject saveObject;

	void Start ()
	{
		GameObject SaveObject = GameObject.FindGameObjectWithTag ("SaveObject");
		saveObject = SaveObject.GetComponent<SaveObject> ();
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
		if (SceneManager.GetActiveScene ().name == "Start" && name != "Settings") {
			SceneManager.LoadScene (name);
			return;
		} else if (SceneManager.GetActiveScene ().name == "Start" && name == "Settings") {
			SceneManager.LoadScene (name);
			return;
		} else if (SceneManager.GetActiveScene ().name == "Settings" && name.Length == 0) {
			SceneManager.LoadScene ("Start");
			return;
		}
		if (gameObject.scene.name == "Settings") {
			name = saveObject.previousScene;
		}
		saveObject.previousScene = gameObject.scene.name;
		SceneManager.UnloadSceneAsync (gameObject.scene.name);
		SceneManager.LoadScene (name, LoadSceneMode.Additive);

	}

	public void QuitGame ()
	{
		Application.Quit();
	}

	public void LoadNextLevel() {
		SceneManager.LoadScene("Start");
	}
}

