using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooter : MonoBehaviour {

	public GameObject gun;
	public GameObject projectile;
	//public bool isShooting = false;
	public float shootForce = 5f;
	public float spawnDistance = .1f;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) {
			Shoot ();
		}
	}



	void Shoot (){
		GameObject thisTomato = Instantiate (projectile, transform.position + (transform.forward * spawnDistance), new Quaternion ());
		Rigidbody thisRigidbody = GetComponent<Rigidbody> ();
		thisRigidbody.velocity = transform.forward * shootForce;
		thisRigidbody.angularVelocity = new Vector3 (Random.value, Random.value, Random.value);



	}

}
