using UnityEngine;

public class GameObjectReaction : DelayedReaction
{
    public GameObject gameObject;
    public bool activeState;


    protected override void ImmediateReaction()
    {

    	////////Debug.Log("REACTION: " + gameObject.name + " " + activeState);
        gameObject.SetActive (activeState);
    }
}