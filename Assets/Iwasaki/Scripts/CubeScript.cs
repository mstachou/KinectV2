using UnityEngine;
using System.Collections;

public class CubeScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionExit(Collision col){
		if (col.gameObject.tag == "Player") {
			Rigidbody rb = col.gameObject.GetComponent<Rigidbody> ();
			Vector3 vec = rb.velocity;

			rb.velocity += Vector3.up * 3;

		}
	}
}
