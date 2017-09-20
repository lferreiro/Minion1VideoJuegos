using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour {

	public GameObject jumpPlatform;
	public GameObject breakPlatform;
	public GameObject doublePlatform;
	public GameObject movingPlatform;
	public Transform generationPoint;
	public GameObject player;

	public float distanceBetweenPlatforms;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.y < generationPoint.position.y){
			

			transform.position = new Vector3 (Random.Range (-2.74f, 2.74f), transform.position.y + distanceBetweenPlatforms, transform.position.z);

			PlatformSelector (transform.position);

		}
	}

	void PlatformSelector(Vector3 spawnLocation){

		if (player.transform.position.y < 70) {
			EasyPlatformSpawner (spawnLocation);
		} else if (player.transform.position.y > 200) {
			HardPlatformSpawner (spawnLocation);
		} 
		else {
			NormalPlatformSpawner (spawnLocation);
		}
			
	}

	void EasyPlatformSpawner(Vector3 spawnLocation){

		int platRandom = Random.Range (1, 3);

		if (platRandom == 1) {
			Instantiate (jumpPlatform, spawnLocation, transform.rotation);
		} 
		else {
			Instantiate (movingPlatform, spawnLocation, transform.rotation);
		}
	}

	void HardPlatformSpawner(Vector3 spawnLocation){

		int platRandom = Random.Range (2, 4);

		if (platRandom == 2) {
			Instantiate (movingPlatform, spawnLocation, transform.rotation);
		} 
		else {
			Instantiate (breakPlatform, spawnLocation, transform.rotation);
		}
	}


	void NormalPlatformSpawner (Vector3 spawnLocation){

		int platRandom = Random.Range (1, 5);

		if (platRandom == 1) {
			Instantiate (jumpPlatform, spawnLocation, transform.rotation);
		}
		if (platRandom == 2) {
			Instantiate (movingPlatform, spawnLocation, transform.rotation);
		}
		if (platRandom == 3) {
			Instantiate (breakPlatform, spawnLocation, transform.rotation);
		}
		if (platRandom == 4) {
			Instantiate (doublePlatform, spawnLocation, transform.rotation);

		}
	}

}
