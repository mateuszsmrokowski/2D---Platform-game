using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashElements : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if ((transform.parent == null) && this.GetComponent<Rigidbody2D>() == null)
        {
            this.gameObject.AddComponent<Rigidbody2D>();
            this.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-10f, 10f), Random.Range(-10f, 10f)));
        }
    
		
	}
}
