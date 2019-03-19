using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPoint : MonoBehaviour {
	public Transform startPoint;

	// Use this for initialization
	void Start () {
		
	}
	
	void OnTriggerEnter2D (Collider2D other) {
		//Transform startPoint = GameObject ("PStart");
		if (other.gameObject.tag=="Player") {

            other.GetComponent<RespawnPoint>().RespawnOn();

		}


	}
}
