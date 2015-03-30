using UnityEngine;
using System.Collections;

public class GridInstantiate : MonoBehaviour {

	public Transform floorTilePrefab; // assign in inspector
	public Transform wallTilePrefab; // assign in inspector

	public GameObject pathInstantiatePrefab;
	public float chanceOfPath = .5f;

	// Use this for initialization
	void Start () {
		for ( int counter = 0 ; counter < 5 ; counter++ ) {
			for ( int otherCounter = 0 ; otherCounter < 5 ; otherCounter++ ) {

				Vector3 pos = (new Vector3(counter * 5,0,otherCounter * 5) + this.transform.position);

				float randomNumber = Random.Range (0f, 1f);

				if (randomNumber < .7f) {
					Instantiate ( floorTilePrefab, 
					             pos,
					             this.transform.rotation
					             );
				}
				else if (randomNumber < .95f) {
					Instantiate ( wallTilePrefab, 
					             pos,
					             this.transform.rotation
					             );
				}

			}
		}

		float pathRandom = Random.Range(0f,1f);
		
		if (pathRandom < chanceOfPath) {
			Instantiate (pathInstantiatePrefab,this.transform.position,this.transform.rotation);
		}

		Destroy (gameObject);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

/*
// put this on a small cube, it will instantiate a grid of 5x5 floors with random walls
START:
for ( integer X starts at zero; as long as X is less than 5; increment X):
	for ( integer Z starts at zero; as long as Z is less than 5; increment Z):
		Generate a temporary Vector3 "pos" of "(X, 0, Z) + current position"
		70% chance to instantiate a floor tile prefab at "pos"
		25% chance to instantiate a wall tile prefab at "pos"
		5% chance to instantiate nothing
Destroy self
// when you are done, make sure you test this and it's working
*/