using UnityEngine;
using System.Collections;

public class HocketBall : MonoBehaviour {
	Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		rb.velocity = new Vector3 (4,-2,0);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
