using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController: MonoBehaviour {


	public GameObject player;

	public GUIText scoreText;
	public GUIText maxScore;
	public int score;
	int highScore;

	void Start (){
		score = 0;
		highScore = PlayerPrefs.GetInt ("HighScore1", 0);
		maxScore.text = "HighScore: " + highScore;
	}

	// Update is called once per frame
	void Update () {

		if (player.transform.position.y * 2 > score) {
			score = (int)player.transform.position.y * 2;
			UpdateScore ();
		}

		float nuevaAltura = Mathf.Lerp (transform.position.y, player.transform.position.y , Time.deltaTime * 2); //Se define la posicion de comienzo de la camara antes de moverse, la posicion deseada(a la que llega el jugador en el salto) y el tiempo que tarda el movimiento de la camara.

		if (player.transform.position.y > transform.position.y) {
			transform.position = new Vector3 (transform.position.x, nuevaAltura, transform.position.z);    		//Si la posicion de nuestro personaje es mayor a la de la camara, la camara se ajusta.
		} 
		else if (player.transform.position.y < transform.position.y - 5.5f) {
			CheckHighScore ();
			Application.LoadLevel (Application.loadedLevel);
		}


	}

	void UpdateScore(){
		scoreText.text = "Score: " + score;
	}

	void CheckHighScore(){
		if (score > highScore) {
			Debug.Log ("Saving score");

			PlayerPrefs.SetInt("HighScore1", score);
		}
	}
}
