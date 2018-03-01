using UnityEngine;

public class GameObjectActivitySaver : Saver
{
    public GameObject gameObjectToSave;


    protected override string SetKey()
    {
		////////Debug.Log("GAME ACTIVITY SET KEY: "+gameObjectToSave.name + " " + gameObjectToSave.GetType().FullName +" " + uniqueIdentifier);
        return gameObjectToSave.name + gameObjectToSave.GetType().FullName + uniqueIdentifier;
    }


    protected override void Save()
    {
    	////////Debug.Log("SAVING: " + key + " " + gameObject.activeSelf);
        saveData.Save(key, gameObjectToSave.activeSelf);
    }


    protected override void Load ()
	{
		bool activeState = false;

		if (saveData.Load (key, ref activeState)) {
			gameObjectToSave.SetActive (activeState);
			////////Debug.Log("LOADING: "+gameObjectToSave.name);
		}
    }
}
