﻿using UnityEngine;
using System.Collections;

public class VillageLogic : MonoBehaviour {

	public GameObject GameState;
    public GameObject goWater;

	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.name == "Water") {
			GameState.SendMessage ("LevelCompleted", true);
            goWater.SendMessage("SetActive", false);
		}
	}
}