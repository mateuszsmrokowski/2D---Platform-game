using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCommon : MonoBehaviour {
    public Rigidbody2D rb;
    public bool Turn = true;
    public ContactPoint2D CP;
    public int Licznik;
    public float Force = 20f;
    public float Tim, Tim1;

    // Use this for initialization
    void Start () {
        rb.collisionDetectionMode = CollisionDetectionMode2D.Discrete;
        //TurnC();
        Tim = Time.time;

    }
	
	// Update is called once per frame
	void Update () {

       

    }

    private void FixedUpdate()
    {
        Tim1 = Time.time;

        if ((Licznik == 2) && ((Tim1 - Tim) > 0.05))
        {
            Force = -Force;
        }
        
        if ((Tim1 - Tim) > 0.05)
        {
            rb.AddForce(new Vector2(Force, 0f));
            Tim = Time.time;

        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Force = -Force;
        Licznik ++;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Licznik--;
    }

    //private onCo


}
