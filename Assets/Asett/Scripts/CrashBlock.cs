using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashBlock : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnDestroy()
    {
        

        foreach (Transform child in transform)
        {
            child.GetComponent<CrashElements>().enabled = true;
        }

        transform.DetachChildren();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            //
        }
    }
}
