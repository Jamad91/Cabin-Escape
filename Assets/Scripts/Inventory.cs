using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable] 

public class Inventory : MonoBehaviour {

	public const int numItemSlots = 6;
	public Image[] itemImages = new Image[numItemSlots];
	public Item[] items = new Item[numItemSlots];

//	static Inventory singleInventory;
//	public static Inventory GetInstance() {
//		return singleInventory;
//	}
//
//	void Start() {
//		////////Debug.Log("hitting: " + singleInventory);
//		if (singleInventory != null) {
//			// Someone ELSE is the singleton already.
//			// So let's just destory ourselves before we cause trouble.
//			Destroy(this.gameObject);
//			return;
//		}
//		// If we get here, then we are "the one".
//		singleInventory = this;
//		GameObject.DontDestroyOnLoad(this.gameObject); //Become immortal
//
//	}

	public void AddItem (Item itemToAdd)
	{
		////////Debug.Log("adding Item: " + itemToAdd.sprite);
		for (int i = 0; i < items.Length; i++)
        {
            if (items[i] == null)
            {
                items[i] = itemToAdd;
                itemImages[i].sprite = itemToAdd.sprite;
                itemImages[i].enabled = true;
                return;
            }

        }

	

//		for (int i = 0; i < items.Length; i++) {
//			itemImage = items [i].transform.GetChild (0).GetComponent<Image> ();
//			if (itemImage == null || itemImage.sprite == null) {
//				itemImage.sprite = itemToAdd.GetComponent<SpriteRenderer>().sprite;
//				Destroy(itemToAdd);
//				return;
//			}
//		}	
	}

	public void RemoveItem (Item itemToRemove)
	{

		for (int i = 0; i < items.Length; i++)
        {
            if (items[i] == itemToRemove)
            {
                items[i] = null;
//                itemImages[i].sprite = null;
//                itemImages[i].enabled = false;
                return;
            }
        }
//		for (int i = 0; i < items.Length; i++) {
//			itemImage = items [i].transform.GetChild (0).GetComponent<Image> ();
//			if (itemImage == itemToRemove) {
//				itemToRemove.transform.localScale -= new Vector3 (0.1F, 0.1F, 0);
//				itemImage.sprite = null;
//				inventoryManager.clearSelectedSlot();
//				itemImage.transform.localScale -= new Vector3 (0.1F, 0.1F, 0);
//				return;
//			}
//		}
	}

}


//using UnityEngine;
//using UnityEngine.UI;
//
//public class Inventory : MonoBehaviour
//{
//    public Image[] itemImages = new Image[numItemSlots];
//    public Item[] items = new Item[numItemSlots];
//
//
//    public const int numItemSlots = 4;
//
//
//    public void AddItem(Item itemToAdd)
//    {
//        for (int i = 0; i < items.Length; i++)
//        {
//            if (items[i] == null)
//            {
//                items[i] = itemToAdd;
//                itemImages[i].sprite = itemToAdd.sprite;
//                itemImages[i].enabled = true;
//                return;
//            }
//        }
//    }
//
//
//    public void RemoveItem (Item itemToRemove)
//    {
//        for (int i = 0; i < items.Length; i++)
//        {
//            if (items[i] == itemToRemove)
//            {
//                items[i] = null;
//                itemImages[i].sprite = null;
//                itemImages[i].enabled = false;
//                return;
//            }
//        }
//    }
//}

