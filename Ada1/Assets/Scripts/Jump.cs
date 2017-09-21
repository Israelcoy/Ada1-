using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {
	public bool jump;
	private Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent <Rigidbody2D> ();
		jump = false;
	}
	
	// Update is called once per frame
	void Update () {

		if (jump == true) {
			if (Input.GetKeyDown (KeyCode.Space)) {
				rb.velocity = new Vector3 (0, 10, 0);
				jump = false;
			}
		}
	}

	void OnTriggerStay2D (Collider2D other) {
		if (other.tag == "Ground" || other.tag == "Caja?") {
			jump = true;
		}
	}
}
