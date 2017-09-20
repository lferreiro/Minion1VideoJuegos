using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float moveSpeed = 4f;
	public float jumpSpeed = 23f;

	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis ("Horizontal");
		GetComponent<Rigidbody2D>().velocity = new Vector2(h * moveSpeed, GetComponent<Rigidbody2D>().velocity.y);

	}
}
