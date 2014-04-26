using UnityEngine;
using System.Collections;

public class Roomba : MonoBehaviour {

	public float moveSpeed = 1.0f;
	public float rotateSpeed = 1.0f;

	public Transform cameraTransform;

	private enum Direction {
		Left,
		Right,
		Front
	}
	private Direction direction = Direction.Front;
	private bool isRotate {
		get {
			if (direction == Direction.Front) {
				return false;
			} else {
				return true;
			}
		}
	}



	// Use this for initialization
	void Start () {
		 
	}
	
	// Update is called once per frame
	void Update() {

		Vector3 pos = this.gameObject.transform.position;
		pos.y = cameraTransform.position.y;

		if (Input.GetKey(KeyCode.LeftArrow)) {
			this.gameObject.transform.Rotate(new Vector3(.0f, -1 * rotateSpeed, .0f));
			cameraTransform.RotateAround(pos, Vector3.up, -1 * rotateSpeed);
		} else if(Input.GetKey(KeyCode.RightArrow)) {
			this.gameObject.transform.Rotate(new Vector3(.0f, rotateSpeed, .0f));
			cameraTransform.RotateAround(pos, Vector3.up, rotateSpeed); 
		} else {
			this.gameObject.transform.position = (this.gameObject.transform.forward * moveSpeed) + this.gameObject.transform.position;
			cameraTransform.position = (this.gameObject.transform.forward * moveSpeed) + cameraTransform.position;
		}
	}



}
