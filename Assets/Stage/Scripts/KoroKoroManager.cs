using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class KoroKoroManager : MonoBehaviour {

	State state;
	public GameObject whisper1;
	public GameObject coin;
	public static KoroKoroManager instance = null;
	int stage = 1;
	public GameObject clearObject;
	public GameObject faultObject;

	public GameObject[] stages;

	float timer = 60.0f;
	public Text timerLabel;

	public float initTime = 40;


	Vector3 startpos;

	void Awake(){

		if (instance == null) {
			instance = this;
		}else{
			Destroy(this.gameObject);
		}

	}

	enum State{
		PreGame = 0,
		Game = 1,
		Clear = 2,
		Fault = 3,
	}

	// Use this for initialization
	void Start () {
		state = State.PreGame;
		startpos = whisper1.transform.position;
		SelectStage (1);
	
	}
	
	// Update is called once per frame
	void Update () {
		timerLabel.text = timer.ToString ("f1");
		switch (state) {
		case State.PreGame:
			coin.GetComponent<Rigidbody> ().useGravity = false;
			whisper1.transform.position = startpos;
			coin.transform.parent = whisper1.transform;
			coin.transform.localPosition = new Vector3 (0, 0.4f, 0);
			coin.GetComponent<Rigidbody> ().velocity = Vector3.zero;
			if (Input.GetKeyDown ("n")) {
				SetState (1);
			}
			timer = initTime;
			clearObject.SetActive (false);
			faultObject.SetActive (false);
			break;
		case State.Game:
			//coin.transform.parent = null;
			clearObject.SetActive (false);
			faultObject.SetActive (false);
			timer -= Time.deltaTime;
			if (timer < 0) {
				SetState (3);
				timer = 0;
			}
			break;
		case State.Clear:
			clearObject.SetActive (true);
			faultObject.SetActive (false);
			
			break;
		case State.Fault:
			clearObject.SetActive (false);
			faultObject.SetActive (true);

			
			break;
		default:
			break;
		}

		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			SelectStage (1);
		}
		if (Input.GetKeyDown (KeyCode.Alpha2)) {
			SelectStage (2);
		}
		if (Input.GetKeyDown (KeyCode.Alpha3)) {
			SelectStage (3);
		}
		if (Input.GetKeyDown (KeyCode.Alpha4)) {
			SelectStage (4);
		}


	
	}

	public void SetState(int input){
		switch (input) {
		case (int)State.PreGame:
			state = State.PreGame;

			break;
		case (int)State.Game:
			coin.transform.parent = null;
			coin.GetComponent<Rigidbody> ().useGravity = true;
			state = State.Game;
			break;
		case (int)State.Clear:
			state = State.Clear;
			break;
		case (int)State.Fault:
			state = State.Fault;
			break;
		default:
			break;
		}
	}

	public int GetState(){
		return (int)state;
	}

	public void SelectStage(int num){


		for (int i = 0; i < stages.Length; i++) {
			if (num - 1 == i) {
				stages [i].SetActive (true);
			} else {
				stages [i].SetActive (false);
			}
		}
		SetState (0);
		state = State.PreGame;
	}
}
