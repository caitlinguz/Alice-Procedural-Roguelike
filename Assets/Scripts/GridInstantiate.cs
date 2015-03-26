using UnityEngine;
using System.Collections;

public class GridInstantiate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		for ( int counter = 0 ; counter < 5 ; counter++ ) {
			for ( int otherCounter = 0 ; otherCounter < 5 ; otherCounter++ ) {
				transform.position += transform.forward * 5f;

				float randomNumber = Random.Range (0f, 1f);


			}
		}

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