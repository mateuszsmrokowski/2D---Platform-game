using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TeleportToScene : MonoBehaviour
{
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

    //Obsolete protected bool IsPressed(EventSystem.BaseEventData eventData);
    //protected bool isPressed();
    // Use this for initialization
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    void FixedUpdate()
    {
        EnterStatus = Player.GetComponent<PllayerController>().EnterDoor;
        Debug.Log(transform.parent);
    }


    private void OnTriggerStay2D(Collider2D collision)
    { 
        if ((collision.gameObject.tag == "Player") && (EnterStatus == true))
        {
            Application.LoadLevel("Plansza1");

        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
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








