using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testTomato : MonoBehaviour {
	public GameObject tomatoPrefab;
	public GameObject gun;
	//offset between gun and projectile
	public float offset = 0.1f;
	public float shootForce = 5f;
	// Use this for initialization
	
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) {
			shootTomato ();
		}
	}


	void shootTomato(){
		GameObject thisTomato = GameObject.Instantiate (tomatoPrefab, transform.position + (transform.forward * offset), new Quaternion ());
		Rigidbody thisRb = thisTomato.GetComponent<Rigidbody> ();
		thisRb.velocity = transform.forward * shootForce;
	}
}
