﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour {

	public Image[] itemImages = new Image[numItemSlots];
	public Item[] items = new Item[numItemSlots];

	public const int numItemSlots = 6;

	public void AddItem ()
	{
//		for (int i = 0; i < items.Length; i++) {
//			if (items [i] == null) {
//				items[i] = itemToAdd;
//				itemImages[i].sprite = itemToAdd.sprite;
//				itemImages[i].enabled = true;
				Debug.Log("items: " + items);
//				return;
//			}
//		}	
	}

	public void RemoveItem (Item itemToRemove) {
		for (int i = 0; i < items.Length; i++) {
			if (items [i] == itemToRemove) {
				items[i] = null;
				itemImages[i].sprite = null;
				itemImages[i].enabled = false;
				return;
			}
		}	
	}

}
