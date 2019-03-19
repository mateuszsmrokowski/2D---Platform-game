using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseOn : MonoBehaviour {

    public UnityEngine.UI.Text Txt1;
    public Image Img1;

	// Use this for initialization
	void Start () {
        Txt1.text = "Zwiększenie predkości biegu";
        
        
        Txt1.transform.position = new Vector2(Img1.transform.position.x + 150f, Img1.transform.position.y);
        Txt1.color = Color.red;
        Txt1.enabled = false;

        
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnMouseEnter()
    {
        Txt1.enabled = true;
        Debug.Log("weszło");
    }

    public void OnMouseExit()
    {
        Txt1.enabled = false;
        Debug.Log("weyszło");
    }
}
