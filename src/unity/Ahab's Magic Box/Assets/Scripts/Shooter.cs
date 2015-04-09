using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Shooter : MonoBehaviour {

	//private List<GameObject> spheres = new List<GameObject>();
	private GameObject sphere;
	// Use this for initialization
	void Start () {
		sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
	}
	
	// Update is called once per frame
	void Update () {
		sphere.transform.position = sphere.transform.position + new Vector3 (0, 0, .2f);
		if (sphere.transform.position.z > 100) {
			sphere.transform.position = Vector3.zero;
		}
	}
}
