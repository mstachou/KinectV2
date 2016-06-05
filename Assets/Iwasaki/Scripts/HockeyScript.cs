using UnityEngine;
using System.Collections;

public class HockeyScript : MonoBehaviour {

	public float speed = 5;
	//Rigidbody rb;
	float h;

	// Use this for initialization
	void Start () {
		//rb = GetComponent<Rigidbody> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		h = Input.GetAxis ("Horizontal");
		transform.position += h * speed * Time.deltaTime * Vector3.right;

		if (transform.position.x > 6) {
			transform.position = Vector3.Scale(new Vector3 (0, 1, 1),transform.position) + Vector3.right*6;
		}
		if (transform.position.x < -6) {
			transform.position = Vector3.Scale(new Vector3 (0, 1, 1),transform.position) + Vector3.right*-6;
		}

	
	}

	void FixedUpdate(){
		
	//	rb.velocity = h * speed * Vector3.right;

	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "Hockey") {
			Rigidbody rb = col.gameObject.GetComponent<Rigidbody> ();
			rb.velocity = Vector3.Scale (new Vector3(1,-1,1),rb.velocity);
		}
	}
}
