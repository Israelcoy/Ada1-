using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.left * Time.deltaTime * 1, Space.World);
	}

	void OnTriggerEnter2D (Collider2D other){
		if (other.tag == "Killer") {
			Destroy (this.gameObject);
		}
	} 
}
