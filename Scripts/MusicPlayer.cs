﻿using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {
	static MusicPlayer instance=null;
	void Awake(){
		Debug.Log ("Music Player awake"+GetInstanceID());
		if (instance != null) {
			Destroy (gameObject);
			print ("duplicate music playe gets desroyed");
		} else {
			instance=this;
			GameObject.DontDestroyOnLoad(gameObject);
		}
	}
	// Use this for initialization
	void Start () {
		Debug.Log ("Music Player start"+GetInstanceID());

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
