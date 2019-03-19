using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamDestroy : MonoBehaviour {

	// Use this for initialization
	public void DestroyIT(GameObject GO)
    {
        Debug.Log("Jeblo");
        
        Destroy(GO);


    }

    public void DestroyAll()
    {
        Destroy(GameObject.FindGameObjectWithTag("dynamit"));
    }
}
