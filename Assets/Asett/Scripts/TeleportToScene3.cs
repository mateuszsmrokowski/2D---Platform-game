using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TeleportToScene3 : MonoBehaviour
{
    private bool Press;
    public GameObject Player;
    private bool CanEnter = false;
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
        EnterStatus = Player.GetComponent<PllayerController>().EnterDoor;
    }

    void Update()
    {
        if ((PlayerPrefs.GetInt("Plansza2") > 51) && (CanEnter == false))
        {
            CanEnter = true;
            this.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("drzwi2");
        }

    }

    void OnTriggerStay2D(Collider2D other)
    {

        if ((other.gameObject.tag == "Player") && (EnterStatus == true) && CanEnter == true)
        {

            Application.LoadLevel("Plansza3");
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.gameObject.tag == "Player") && (CanEnter == true))
        {
            this.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("drzwi4");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)

    {
        if ((collision.gameObject.tag == "Player") && (CanEnter == true))
        {
            this.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("drzwi2");
        }
    }


}





