using UnityEngine;
using System.Collections;

public class CoinScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col){
		if (col.tag == "Goal") {
			KoroKoroManager.instance.SetState (2);
			GetComponent<Rigidbody> ().velocity = Vector3.zero;
		}
		if (col.tag == "GameOver") {
			KoroKoroManager.instance.SetState (3);
		}

	}
}
