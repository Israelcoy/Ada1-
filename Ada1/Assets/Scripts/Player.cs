using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	public float speed;
	private Animator anim;
	private Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		anim = GetComponent <Animator> ();
		rb = GetComponent <Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		anim.SetBool ("running", false);
		anim.SetBool ("dies", false);

		if (Input.GetKey (KeyCode.A)) {
			transform.Translate (Vector3.left  * Time.deltaTime * speed, Space.World);
			transform.localScale = new Vector3 (-1, 1, 1);
			anim.SetBool ("running", true);
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.Translate (Vector3.right  * Time.deltaTime * speed, Space.World);
			transform.localScale = new Vector3 (1, 1, 1);
			anim.SetBool ("running", true);
		}
		if (Input.GetKeyDown (KeyCode.Space)) {
			rb.velocity = new Vector3 (0, 8.5f, 0);
			
		}
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "Mario") {
			anim.SetBool ("dies", true);
		}
		if (other.tag == "Coin") {
			Destroy (other.gameObject);
		}
	}

}
