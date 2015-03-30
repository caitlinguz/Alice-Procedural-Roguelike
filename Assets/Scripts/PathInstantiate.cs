using UnityEngine;
using System.Collections;

public class PathInstantiate : MonoBehaviour {

	int tilesPlacedCounter = 0;
	public Transform floorTilePrefab; // assign in inspector

	public GameObject gridInstantiatePrefab;
	public float chanceOfGrid = .5f;
	public Collider cubePathTrigger;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (tilesPlacedCounter < 50) {

			float randomNum = Random.Range (0f, 1f);

			if (randomNum < .25f) {
				transform.Rotate (0f, 90f, 0f);
			}
			else if (randomNum < .5f) {
				transform.Rotate (0f, -90f, 0f);
			}

			Instantiate ( floorTilePrefab, 
			             transform.position,
			             Quaternion.Euler ( 0f, 0f, 0f )
			             );

			transform.position += transform.forward * 5f;

			tilesPlacedCounter++;
		}

		else {

			float gridRandom = Random.Range (0f, 1f);

			if (gridRandom < chanceOfGrid) {
				Instantiate (gridInstantiatePrefab,this.transform.position,this.transform.rotation);
			}

			Destroy (gameObject);
		}

	}

	void OnTriggerEnter ( Collider activator ) {
//		activator.Destroy;
	}
}

/*
// put this on a small cube, it will move around and drop floor modules like breadcrumbs
UPDATE:
If counter is less than 50, then:
	Generate random number from 0.0f to 1.0f
	If number is less than 0.25f, then rotate 90 degrees
	... Else if number is 0.25f-0.5f, then rotate -90 degrees
	Instantiate a floor tile prefab at current position
	Move forward (with respect to rotation) by 5 units
	Increment counter
Else
	Destroy self
// when you are done, make sure you test this and it's working
*/