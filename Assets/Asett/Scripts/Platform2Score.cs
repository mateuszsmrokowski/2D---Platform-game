using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Platform2Score : MonoBehaviour
{
    public GameObject PickUp;
    private int PickupCount;
    private int PrefCount;
    // Use this for initialization
    void Start()
    {
        if (PlayerPrefs.HasKey("Platform2") == false)
        {
            this.GetComponent<Text>().text = "0/" + PickUp.GetComponent<Transform>().childCount;
            PlayerPrefs.SetInt("Platform2", 0);
        }
        else
        {
            this.GetComponent<Text>().text = PlayerPrefs.GetInt("Platform2") + "/" + PickUp.GetComponent<Transform>().childCount;
        }

        PickupCount = PickUp.GetComponent<Transform>().childCount;
        PrefCount = PlayerPrefs.GetInt("Platform2");
    }

    // Update is called once per frame
    void Update()
    {
        if (Application.loadedLevelName == "Plansza2")
        {
            if (PrefCount < (PickupCount - PickUp.GetComponent<Transform>().childCount))
            {
                PrefCount = (PickupCount - PickUp.GetComponent<Transform>().childCount);
                this.GetComponent<Text>().text = PrefCount + "/" + PickupCount;
                PlayerPrefs.SetInt("Platform2", PrefCount);
            }
        }
    }
}
