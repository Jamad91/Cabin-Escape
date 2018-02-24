using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public void LoadLevel (string name)
	{
		Debug.Log("current scene is " + gameObject.scene.name);
		Debug.Log("Level Load Requested for: " + name);
//		Debug.Log("gameobjects:" + gameObject.scene.GetRootGameObjects()[5]);
		SceneManager.UnloadSceneAsync(gameObject.scene.name);
		SceneManager.LoadScene(name, LoadSceneMode.Additive);

//		Application.LoadLevel(name);
//		Application.LoadLevelAdditive(name);
//		Application.SceneManager.LoadScene(name);
//		SceneManager.LoadScene(name);
//		SceneManager.LoadSceneAsync(name);
	}

	public void QuitGame ()
	{
		Debug.Log("Qutting Game");
		Application.Quit();
	}
}
