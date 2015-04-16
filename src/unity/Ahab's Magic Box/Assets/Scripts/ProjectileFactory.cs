using UnityEngine;
using System.Collections;

public class ProjectileFactory : MonoBehaviour {

	public GameObject projectile;

	public int speed = 80;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")) {
			CreateProjectile();
		}

	}

	void ExpellProjectile(){
		CreateProjectile ();
		//Debug.Log (_pj);
		//_pj.velocity = transform.TransformDirection(Vector3.forward * 10);
	}

	void CreateProjectile(){
		GameObject clone;
		clone = Instantiate(projectile, transform.position, transform.rotation) as GameObject;
		clone.GetComponent<Rigidbody>().velocity = transform.TransformDirection(Vector3.forward * speed);
	}
}
