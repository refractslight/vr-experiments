using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tomato : MonoBehaviour {

	public SteamVR_TrackedObject trackedObj;
	public SteamVR_Controller.Device device;
	public float throwForce = 1.5f;
	public GameObject splatObject;
	public float tomatoLifetime;
	public bool isSplatted = false;



	// Use this for initialization
	void Start () {
		trackedObj = GetComponent<SteamVR_TrackedObject> ();

<<<<<<< HEAD
=======
	
>>>>>>> master
	}

	void onTriggerStay(Collider col){
		if (GetComponent<Collider> ().gameObject.CompareTag ("tomato")) {
			if (device.GetPressUp (SteamVR_Controller.ButtonMask.Trigger)) {
				ThrowTomato (col);
			} else if (device.GetPressDown (SteamVR_Controller.ButtonMask.Trigger)) {
				GrabTomato (col);
			}
		}
	}



	void GrabTomato(Collider coli){
		coli.transform.SetParent (gameObject.transform);
		coli.GetComponent<Rigidbody> ().isKinematic = true;
		device.TriggerHapticPulse (2000);
		Debug.Log ("You are holding a tomato.");
	}

	void ThrowTomato(Collider coli){
		coli.transform.SetParent (null);
		Rigidbody rigidbody = coli.GetComponent<Rigidbody> ();
		rigidbody.isKinematic = false;
		rigidbody.velocity = device.velocity * throwForce;
		rigidbody.angularVelocity = device.angularVelocity;
		Debug.Log ("You threw the tomato!");
	}


	void OnCollisionEnter(Collision collision){
<<<<<<< HEAD
//		if (created == false) {

=======
>>>>>>> master
		splatObject = (GameObject) Instantiate (splatObject, transform.position, transform.rotation);
		Debug.Log ("Splat Called");
			Destroy (gameObject);
		Destroy(splatObject, tomatoLifetime);
<<<<<<< HEAD
		Debug.Log ("Splat Destroyed");

=======
		   //FadeOutSplat();
		//if (isSplatted == true) {
		//	Destroy (splatObject);
>>>>>>> master
		//}
	} 

	void FadeOutSplat(){
		iTween.ValueTo(gameObject, iTween.Hash(
			"from", 1.0f, "to", 0.0f,
			"time", 1f, "easetype", "linear",
			"onupdate", "setAlpha"));
					isSplatted = true;
	}

}
