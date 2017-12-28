using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddItem : MonoBehaviour {

	private Inventory inventory;

	void OnMouseDown ()
	{
		inventory = GameObject.Find("Inventory").GetComponent<Inventory>();
//			.GetComponent<Image>().sprite
//		Debug.Log(gameObject.GetComponent<SpriteRenderer>().sprite.GetType());
		inventory.AddItem(gameObject);

	}
}


//public string NameOfItemToEquip;
//	public string whereToEquipItem;
//	public int quality = 0;
//	public string NameOfSlotImage;
//	public GameObject backpack; 
//	// Use this for initialization
//	void Start () {
//
//		SetNameColor (quality);
//	
//	}
//	
//	// Update is called once per frame
//	void Update () {
//	
//	}
//
//
//	void OnTriggerEnter(Collider other){
//		if (other.gameObject.tag == "Player") {
////			if (whereToEquipItem == "rightHand") {
////				GameObject item = Instantiate (Resources.Load (NameOfItemToEquip, typeof(GameObject))) as GameObject;
////				other.gameObject.GetComponent<EquipItemScript> ().EquipRightHandWith (item);
////			} else if (whereToEquipItem == "leftHand") {
////				GameObject item = Instantiate (Resources.Load (NameOfItemToEquip, typeof(GameObject))) as GameObject;
////				other.gameObject.GetComponent<EquipItemScript> ().EquipShield (item);
////			} else if (whereToEquipItem == "head") {
////				GameObject item = Instantiate (Resources.Load (NameOfItemToEquip, typeof(GameObject))) as GameObject;
////				other.gameObject.GetComponent<EquipItemScript> ().EquipHeadWith (item);
////			} else if (whereToEquipItem == "buckle") {
////				GameObject item = Instantiate (Resources.Load (NameOfItemToEquip, typeof(GameObject))) as GameObject;
////				other.gameObject.GetComponent<EquipItemScript> ().EquipBuckleWith (item);
////			} else if (whereToEquipItem == "shoulders") {
////				string leftShoulderName = NameOfItemToEquip + "-left";
////				string rightShoulderName = NameOfItemToEquip + "-right";
////				GameObject itemLeft = Instantiate (Resources.Load (leftShoulderName, typeof(GameObject))) as GameObject;
////				GameObject itemRight = Instantiate (Resources.Load (rightShoulderName, typeof(GameObject))) as GameObject;
////				other.gameObject.GetComponent<EquipItemScript> ().EquipLeftShoulderWith (itemLeft);
////				other.gameObject.GetComponent<EquipItemScript> ().EquipRightShoulderWith (itemRight);
////			}
//
//			//todo: add item to inventory
//			GameObject imageObject = Instantiate(Resources.Load(NameOfSlotImage)) as GameObject;
//				
//			GameObject player = GameObject.FindGameObjectWithTag("Player");
////			GameObject backpack = player.GetComponent<EquipItemScript>().backpack;
//			backpack = player.GetComponent<EquipItemScript>().backpack;
//
////			GameObject backpack = GameObject.FindGameObjectWithTag("Backpack");
//
//			backpack.GetComponent<BackpackManager>().AddItem(imageObject);
//			Destroy (this.gameObject);
//
//		}
//	}