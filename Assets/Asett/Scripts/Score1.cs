using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score1 : MonoBehaviour {

    void Start()
    {
        if (PlayerPrefs.HasKey("Platform1") == false)
        {
            this.GetComponent<Text>().text = "0/100";
            PlayerPrefs.SetInt("Platform1", 0);
        }
        else
        {
            this.GetComponent<Text>().text = PlayerPrefs.GetInt("Platform1") + "/100";
        }
    }
}
