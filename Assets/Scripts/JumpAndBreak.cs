using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpAndBreak : MonoBehaviour {

	public float alturaSalto = 8f; 		//Salto normal
	float velocityY;

	public AudioClip breakSound;

	private AudioSource source;

	void Awake(){
		source = GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	void Update () {
		velocityY = GetComponent<Rigidbody2D> ().velocity.y;
	}

	void OnTriggerEnter2D(Collider2D collider){
		if (collider.tag == "Break" && velocityY <= 0) {
			GetComponent<Rigidbody2D>( ).velocity = new Vector2 (0, 0);﻿
			GetComponent<Rigidbody2D>( ).velocity = new Vector2 (0, alturaSalto);
			source.PlayOneShot (breakSound);
			DestroyObject (collider.gameObject);
		}
	}
}
