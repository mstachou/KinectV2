using UnityEngine;
using System.Collections;

public class WhisperScript : MonoBehaviour {

	Animator anim;
	public int num;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		anim.SetInteger ("number",num);
	
	}
	
	// Update is called once per frame
	void Update () {
		anim.SetInteger ("number",num);
	}
}
