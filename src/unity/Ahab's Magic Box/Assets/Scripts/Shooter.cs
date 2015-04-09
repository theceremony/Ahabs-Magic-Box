using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Shooter : MonoBehaviour {
	private GameObject sphere;

	void Start () {
		sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
		sphere.transform.localScale = new Vector3 (3, 3, 3);
	}
	void Update () {
		sphere.transform.position = sphere.transform.position + new Vector3 (0, 0, 1f);
		if (sphere.transform.position.z > 100) {
			sphere.transform.position = Vector3.zero;
		}
	}
}
