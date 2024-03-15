﻿using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public Transform player;
	public Text scoreText;
	
	void Start()
    {
		scoreText.fontSize = PlayerPrefs.GetInt("FontSize");
    }
	// Update is called once per frame
	void Update () {
		scoreText.text = player.position.z.ToString("0");
	}
}