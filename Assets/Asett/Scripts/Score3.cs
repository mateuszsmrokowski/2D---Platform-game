using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score3 : MonoBehaviour
{

    void Start()
    {
        if (PlayerPrefs.HasKey("Platform3") == false)
        {
            this.GetComponent<Text>().text = "0/100";
            PlayerPrefs.SetInt("Platform3", 0);
        }
        else
        {
            this.GetComponent<Text>().text = PlayerPrefs.GetInt("Platform3") + "/100";
        }
    }
}
