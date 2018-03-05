using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Persistant : MonoBehaviour {

	void Start () {
		SceneManager.LoadScene("L1_Wall01", LoadSceneMode.Additive);
	}

}
