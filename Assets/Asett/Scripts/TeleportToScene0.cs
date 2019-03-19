using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TeleportToScene0 : MonoBehaviour
{
    private bool Press;
    private GameObject Player;
    public bool EnterStatus;

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

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        EnterStatus = Player.GetComponent<PllayerController>().EnterDoor;
        this.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("drzwi2");

    }

    void OnTriggerStay2D(Collider2D other)
    {

        if ((other.gameObject.tag == "Player") && (EnterStatus == true))
        {

            Application.LoadLevel("Skills");
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            this.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("drzwi4");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)

    {
        if (collision.gameObject.tag == "Player")
        {
            this.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("drzwi2");
        }
    }


}





