using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempMove : MonoBehaviour {

	public float xMove;

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.D)) {
			transform.Translate (new Vector2(xMove,0));
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.Translate (new Vector2(-1*xMove,0));
		}
	}
}
