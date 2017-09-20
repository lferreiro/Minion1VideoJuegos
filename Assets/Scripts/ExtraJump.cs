using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ExtraJump : MonoBehaviour {

	public float alturaSalto = 16f; 		//Doble de salto que el normal
	float velocityY;

	// Update is called once per frame
	void Update () {
		velocityY = GetComponent<Rigidbody2D> ().velocity.y;
	}

	void OnTriggerEnter2D(Collider2D collider){
		if (collider.tag == "DobleSalto" && velocityY <= 0) {
			GetComponent<Rigidbody2D>( ).velocity = new Vector2 (0, 0);﻿
			GetComponent<Rigidbody2D>( ).velocity = new Vector2 (0, alturaSalto);
		}
	}
}