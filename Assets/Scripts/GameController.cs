using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController: MonoBehaviour {


	public GameObject player;

	public GUIText scoreText;
	public int heightScore;
	private int highScore;

	void Start (){
		heightScore = 0;
		UpdateScore ();
	}

	// Update is called once per frame
	void Update () {


		float nuevaAltura = Mathf.Lerp (transform.position.y, player.transform.position.y , Time.deltaTime * 2); //Se define la posicion de comienzo de la camara antes de moverse, la posicion deseada(a la que llega el jugador en el salto) y el tiempo que tarda el movimiento de la camara.

		if (player.transform.position.y > transform.position.y) {
			transform.position = new Vector3 (transform.position.x, nuevaAltura, transform.position.z);    		//Si la posicion de nuestro personaje es mayor a la de la camara, la camara se ajusta.
		} 
		else if (player.transform.position.y < transform.position.y - 5.5f) {
			Application.LoadLevel (Application.loadedLevel);
		}

		if (player.transform.position.y * 11 > heightScore) {
			heightScore = (int)player.transform.position.y * 11;
			UpdateScore ();
		}
	}

	void UpdateScore(){
		scoreText.text = "Score : " + heightScore;
	}
}
