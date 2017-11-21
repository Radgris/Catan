using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour {

	public GameObject hexprefab;

	int heigth = 5;

	int width = 5;

	// Use this for initialization
	void Start () {
		for (int x = 0; x < width; x++) {
			for (int y = 0; y < heigth; y++) {

				Instantiate (hexprefab, new Vector3 (x*5, 0, y*5), Quaternion.identity);

				


			}
		}
			

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
