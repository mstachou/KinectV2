using UnityEngine;
using System.Collections;

public class PlayerScript1 : MonoBehaviour {

	public GameObject particle;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "Body") {
			Instantiate (particle, col.contacts[0].point, transform.rotation);
		}
	}
}
