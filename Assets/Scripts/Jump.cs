using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

	public bool enTierra;				//Verdadero si estamos en la tierra
	public float alturaSalto = 8f;
	public AudioClip jumpSound;

	private AudioSource source;

	public Transform checkeoTierra;		//Se encarga de checkear si estas en la tierra

	public LayerMask tierra;			//Decide que capa cuenta como tierra.

	float radioCheck = 0.2f; 			//Radio que define si estamos en tierra o no
	// Update is called once per frame

	void Awake () { 
		source = GetComponent<AudioSource> ();
	} 

	void FixedUpdate () {

		enTierra = Physics2D.OverlapCircle (checkeoTierra.position, radioCheck, tierra);

		if (enTierra && GetComponent<Rigidbody2D>().velocity.y <= 0) {

			GetComponent<Rigidbody2D>( ).velocity = new Vector2 (0, 0);﻿
			source.PlayOneShot (jumpSound);
			GetComponent<Rigidbody2D>( ).velocity = new Vector2 (0, alturaSalto);﻿
		}		
	}
}
