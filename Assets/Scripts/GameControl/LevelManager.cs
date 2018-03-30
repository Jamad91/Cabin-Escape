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

	public string getPreviousScene ()
	{
		return gameObject.scene.name;
	}

	public void LoadLevel (string name)
	{
		if (SceneManager.GetActiveScene ().name == "Start" && name != "Settings") {
			SceneManager.LoadScene (name);
			return;
//		} else if (SceneManager.GetActiveScene ().name != "Start" && name == "Settings") {
//			SceneManager.UnloadSceneAsync(gameObject.scene.name);
//			SceneManager.LoadScene(name, LoadSceneMode.Additive);
//			Debug.Log("Hit menu: " + name);
//			Debug.Log("Hitting this: " + gameObject.scene.name);
//			Debug.Log("Hitting That: "+ currentScene);
//			SceneManager.UnloadSceneAsync(gameObject.scene.name);
//			SceneManager.LoadScene(name, LoadSceneMode.Additive);
//			return;
		}
		Debug.Log ("To: " + name);
		Debug.Log ("From: " + gameObject.scene.name);
		SceneManager.UnloadSceneAsync (gameObject.scene.name);
		SceneManager.LoadScene (name, LoadSceneMode.Additive);
		if (name == "Settings") {
			getPreviousScene();
		}
	}

	public void QuitGame ()
	{
		Application.Quit();
	}

	public void LoadNextLevel() {
		SceneManager.LoadScene("Start");
	}
}

