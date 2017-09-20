using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPiso : MonoBehaviour {

	float velocidadMovimiento = 2f;
	bool llegoAlFinal;
	
	// Update is called once per frame
	void Update () {

		if (llegoAlFinal) {
			transform.position += Vector3.right * velocidadMovimiento * Time.deltaTime;
		} 
		else {
			transform.position -= Vector3.right * velocidadMovimiento * Time.deltaTime;
		}

		if (transform.position.x >= 2.74f) {
			llegoAlFinal = false;
		}

		if (transform.position.x <= -2.74f) {
			llegoAlFinal = true;
		}
	}
}
