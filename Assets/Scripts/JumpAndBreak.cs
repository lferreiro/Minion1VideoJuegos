using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpAndBreak : MonoBehaviour {

	public float alturaSalto = 8f; 		//Salto normal
	float velocityY;
	
	// Update is called once per frame
	void Update () {
		velocityY = GetComponent<Rigidbody2D> ().velocity.y;
	}

	void OnTriggerEnter2D(Collider2D collider){
		if (collider.tag == "Break" && velocityY <= 0) {
			GetComponent<Rigidbody2D>( ).velocity = new Vector2 (0, 0);﻿
			GetComponent<Rigidbody2D>( ).velocity = new Vector2 (0, alturaSalto);
			DestroyObject (collider.gameObject);
		}
	}
}
