﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YogaModeManager : MonoBehaviour {
	public static float ufoAngle = 0;
	public float health;
	public int score;
	public int bp;
	public float thresh;
	public int diff = 1;
	public GameObject player;

	public GameObject alienHead;
	public Transform alienSpawn;

	// Use this for initialization
	void Start () {
		spawnOM ();
		InvokeRepeating ("spawnOM", 0, 3);
		
	}
	
	// Update is called once per frame
	void Update () {
		score = GameObject.Find ("player").GetComponent<YPlayer> ().score;
		GameObject.Find ("GameManager").GetComponent<GameManagerScript> ().score = score;
		health = GameObject.Find ("player").GetComponent<YPlayer> ().health;
		if (health <= 0) {
			Destroy (player);
			SceneManager.LoadScene ("GameOver");
		}
		
	}
	void spawnOM(){
		GameObject go = Instantiate (alienHead, alienSpawn.position,alienSpawn.rotation) as GameObject;
	}
}
