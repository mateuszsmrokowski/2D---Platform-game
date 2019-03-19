using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score2 : MonoBehaviour
{

    void Start()
    {
        if (PlayerPrefs.HasKey("Platform2") == false)
        {
            this.GetComponent<Text>().text = "0/100";
            PlayerPrefs.SetInt("Platform2", 0);
        }
        else
        {
            this.GetComponent<Text>().text = PlayerPrefs.GetInt("Platform2") + "/100";
        }
    }
}
