using UnityEngine;
using System.Collections;

public class bodyScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 v = transform.position;
		transform.position = new Vector3 (v.x,v.y,0);
	
	}
}
