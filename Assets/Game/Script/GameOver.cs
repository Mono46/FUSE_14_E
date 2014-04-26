using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnTriggerEnter(Collider col) {
		Debug.Log("gameover");
		if (col.gameObject.tag == "roomba") {
			Debug.Log("gameover!");
			Application.LoadLevel("GameOver");
		}
	}
}
