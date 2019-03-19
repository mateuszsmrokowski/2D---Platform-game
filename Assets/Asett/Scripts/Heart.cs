using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Heart : MonoBehaviour {
    public Image Heart1;
    public Image Heart2;
    public Image Heart3;
    public Image Heart4;
    private GameObject Player;
    private int HPRemain;

    public Player Player1
    {
        get
        {
            throw new System.NotImplementedException();
        }

        set
        {
        }
    }

    public RespawnPoint RespawnPoint
    {
        get
        {
            throw new System.NotImplementedException();
        }

        set
        {
        }
    }

    // Use this for initialization
    void Start () {
        Player = GameObject.FindGameObjectWithTag("Player");
        HPRemain = Player.GetComponent<PllayerController>().HP;
    }
	
	// Update is called once per frame
	void Update () {
        HPRemain = Player.GetComponent<PllayerController>().HP;
        switch (HPRemain)
        {
            case 4:
                {
                    Heart4.GetComponent<CanvasGroup>().alpha = 1;
                    Heart3.GetComponent<CanvasGroup>().alpha = 1;
                    Heart2.GetComponent<CanvasGroup>().alpha = 1;
                    Heart1.GetComponent<CanvasGroup>().alpha = 1;
                    break;
                }

            case 3:
                {
                    Heart4.GetComponent<CanvasGroup>().alpha = 0;
                    Heart3.GetComponent<CanvasGroup>().alpha = 1;
                    Heart2.GetComponent<CanvasGroup>().alpha = 1;
                    Heart1.GetComponent<CanvasGroup>().alpha = 1;
                    break;
                }
            case 2:
                {
                    Heart4.GetComponent<CanvasGroup>().alpha = 0;
                    Heart3.GetComponent<CanvasGroup>().alpha = 0;
                    Heart2.GetComponent<CanvasGroup>().alpha = 1;
                    Heart1.GetComponent<CanvasGroup>().alpha = 1;
                    break;
                }
            case 1:
                {
                    Heart4.GetComponent<CanvasGroup>().alpha = 0;
                    Heart3.GetComponent<CanvasGroup>().alpha = 0;
                    Heart2.GetComponent<CanvasGroup>().alpha = 0;
                    Heart1.GetComponent<CanvasGroup>().alpha = 1;
                    break;
                }

            case 0:
                {
                    Heart4.GetComponent<CanvasGroup>().alpha = 0;
                    Heart3.GetComponent<CanvasGroup>().alpha = 0;
                    Heart2.GetComponent<CanvasGroup>().alpha = 0;
                    Heart1.GetComponent<CanvasGroup>().alpha = 0;
                    break;
                }

        }

    }
}
