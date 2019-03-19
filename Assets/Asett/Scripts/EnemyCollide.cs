using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollide : MonoBehaviour {
    //public Transform Respawn;
    // Use this for initialization
    private float XDist, YDist;
    private GameObject Box;
	void Start () {



    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (this.tag == "Player")
        {
            if ((collision.collider.tag == "Bomb") || (collision.collider.tag == "Follower"))
            {
                this.GetComponent<RespawnPoint>().RespawnOn();
            }

            if (collision.collider.tag == "EnemyFrontResist")
            {
                //Debug.Log(this.GetComponent<EnemyCollisionAngle>().CollideAngle);
                if ((this.GetComponent<Transform>().position.x > collision.collider.GetComponent<Transform>().position.x) && (collision.gameObject.GetComponent<Transform>().rotation.eulerAngles.y == 180))
                {
                    if ((this.GetComponent<EnemyCollisionAngle>().CollideAngle > -165.0) && (this.GetComponent<EnemyCollisionAngle>().CollideAngle < -140.0))
                    {
                        this.GetComponent<RespawnPoint>().RespawnOn();
                    }
                    else
                    {
                        Destroy(collision.collider.gameObject);
                    }
                }

                if ((this.GetComponent<Transform>().position.x > collision.collider.GetComponent<Transform>().position.x) && (collision.gameObject.GetComponent<Transform>().rotation.eulerAngles.y == 0))
                {
                    if ((this.GetComponent<EnemyCollisionAngle>().CollideAngle > -165.0) && (this.GetComponent<EnemyCollisionAngle>().CollideAngle < -140.0))
                    {
                        Destroy(collision.collider.gameObject);
                    }
                    else
                    {
                        this.GetComponent<RespawnPoint>().RespawnOn();
                    }
                }

                if ((this.GetComponent<Transform>().position.x < collision.collider.GetComponent<Transform>().position.x) && (collision.gameObject.GetComponent<Transform>().rotation.eulerAngles.y == 0))
                {
                    if ((this.GetComponent<EnemyCollisionAngle>().CollideAngle > -35.0) && (this.GetComponent<EnemyCollisionAngle>().CollideAngle < -15.0))
                    {
                        this.GetComponent<RespawnPoint>().RespawnOn();
                    }
                    else
                    {
                        Destroy(collision.collider.gameObject);
                    }
                }

                if ((this.GetComponent<Transform>().position.x < collision.collider.GetComponent<Transform>().position.x) && (collision.gameObject.GetComponent<Transform>().rotation.eulerAngles.y == 180f))
                {
                    if ((this.GetComponent<EnemyCollisionAngle>().CollideAngle > -35.0) && (this.GetComponent<EnemyCollisionAngle>().CollideAngle < -15.0))
                    {
                        Destroy(collision.collider.gameObject);
                    }
                    else
                    {

                        this.GetComponent<RespawnPoint>().RespawnOn();
                    }
                }
            }
            if (collision.collider.tag == "Enemy")
            {
                if (((this.GetComponent<EnemyCollisionAngle>().CollideAngle < 90) && (this.GetComponent<EnemyCollisionAngle>().CollideAngle > 70.0)) || ((this.GetComponent<EnemyCollisionAngle>().CollideAngle > -125) && (this.GetComponent<EnemyCollisionAngle>().CollideAngle < -80.0)))
                {
                    Destroy(collision.gameObject);
                }
                else
                {
                    this.GetComponent<RespawnPoint>().RespawnOn();
                }
                //Debug.Log(this.GetComponent<EnemyCollisionAngle>().CollideAngle);
            }


            if (collision.collider.tag == "Platform")
            {
                XDist = this.transform.position.x - collision.gameObject.transform.position.x;
                YDist = this.transform.position.y - collision.gameObject.transform.position.y;
            }

            if (collision.collider.tag == "Traps")
            {
                this.GetComponent<RespawnPoint>().RespawnOn();
            }

            if (collision.collider.tag == "CrashGround")
            {
                if ((this.transform.position.y - this.GetComponent<BoxCollider2D>().size.y/2) > collision.collider.gameObject.transform.position.y + collision.collider.gameObject.GetComponent<BoxCollider2D>().size.y/2)
                {
                    Box = collision.collider.gameObject;
                    Invoke("DestroyBox", 0.3f);
                }

            }

            if (collision.collider.tag == "CrashBox")
            {
                //Destroy(collision.collider.gameObject);
                Box = collision.collider.gameObject;
                Invoke("DestroyBox", 0.45f);

            }


        }

    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.tag == "Platform")
        {

            this.transform.position = new Vector2(collision.gameObject.transform.position.x + XDist, collision.gameObject.transform.position.y + YDist);
        }
    }

    private void DestroyBox()
    {
        Destroy(Box.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.gameObject.tag == "Lava") && ((this.gameObject.tag == "Player") || (this.gameObject.tag == "GhostPlayer")))
        {
            this.gameObject.tag = "Dead";
            this.GetComponent<RespawnPoint>().RespawnOn();

        }
    }
}
