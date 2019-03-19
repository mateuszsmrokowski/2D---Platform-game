using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Follower : MonoBehaviour {

    private GameObject Player;
    private Transform PlayerPos;
    public float Speed = 0.01f;
    private float startTime;
    private float journeyLength;

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

    // Use this for initialization
    void Start () {
        //this.GetComponent<BoxCollider2D>().isTrigger = true;
        Player = GameObject.FindGameObjectWithTag("Player");
        PlayerPos = Player.GetComponent<Transform>().transform;
        startTime = Time.time;
        
    }
	
	// Update is called once per frame
	void Update () {

        PlayerPos = Player.GetComponent<Transform>().transform;
        journeyLength = Vector2.Distance(this.transform.position, PlayerPos.position);

        float distCovered = (Time.time - startTime) * Speed;
        float fracJourney = distCovered / journeyLength;
        this.transform.position = Vector2.Lerp(this.transform.position, PlayerPos.position, fracJourney);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            collision.collider.gameObject.GetComponent<RespawnPoint>().RespawnOn();
            //Instantiate(enemyparticle, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
