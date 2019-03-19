using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearPrefs : MonoBehaviour {

	// Use this for initialization
	void Start () {
        this.GetComponent<Button>().onClick.AddListener(Clear);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Clear()
    {
        PlayerPrefs.SetInt("Platform1", 0);
    }
}
