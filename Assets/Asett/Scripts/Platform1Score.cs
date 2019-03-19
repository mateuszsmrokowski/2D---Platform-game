using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Platform1Score : MonoBehaviour
{

    public GameObject PickUp;
    private int PickupCount;
    private int PrefCount;
	// Use this for initialization
	void Start () {

        //PickUp = GameObject.Find("PickUps");

        if (PlayerPrefs.HasKey("Platform1") == false)
        {
            this.GetComponent<Text>().text = "0/" + PickUp.GetComponent<Transform>().childCount;
            PlayerPrefs.SetInt("Platform1", 0);
        }
        else
        {
            this.GetComponent<Text>().text = PlayerPrefs.GetInt("Platform1") + "/" + PickUp.GetComponent<Transform>().childCount;
        }

        PickupCount = PickUp.GetComponent<Transform>().childCount;
        PrefCount = PlayerPrefs.GetInt("Platform1");
    }
	
	// Update is called once per frame
	void Update () {

        if (Application.loadedLevelName == "Plansza1"){

            if (PrefCount < (PickupCount - PickUp.GetComponent<Transform>().childCount))
            {
                PrefCount = (PickupCount - PickUp.GetComponent<Transform>().childCount);
                this.GetComponent<Text>().text = PrefCount + "/" + PickupCount;
                PlayerPrefs.SetInt("Platform1", PrefCount);
            }
        }
		
	}
}
