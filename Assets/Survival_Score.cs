using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Survival_Score : MonoBehaviour {

    // Use this for initialization
    private int timeCount;

    void Start () {
        timeCount = 0;
        InvokeRepeating("countCoin", 0f, 1f);
	}
	
	// Update is called once per frame
	void Update () {
        this.GetComponent<Text>().text = timeCount + "/" + 600;
    }

    void countCoin()
    {
        timeCount += 1;
    }
}
