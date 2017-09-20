using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wrap : MonoBehaviour {


	// Update is called once per frame
	void FixedUpdate () {
		//Si el jugador se va del borde de la pantalla vuelve a aparecer del otro lado.
		if (transform.position.x <= -4.12f) {
			transform.position = new Vector3 (4.12f, transform.position.y, transform.position.z);
		}
		else if (transform.position.x >= 4.12f) {
			transform.position = new Vector3 (-4.12f, transform.position.y, transform.position.z);
		}
	}
}
