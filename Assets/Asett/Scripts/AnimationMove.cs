using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationMove : MonoBehaviour {
    public float Speed = 0.1f;
    private float startTime;
    private float journeyLength;
    private Vector2 StartTransform;
    private Vector2 EndTransform;
    private Transform MoveBackup;
    private GameObject EnemyBkp;
    private string EnemyTag;
    private Sprite NoneSprite = null;
    private bool Return = false;

    // Use this for initialization
    void Start()
    {
        StartTransform = this.GetComponent<Transform>().position;
        if (this.GetComponent<Transform>().rotation.eulerAngles.z == 270)
        {
            EndTransform = new Vector2(StartTransform.x + 15f, StartTransform.y);
        }
        else
        {
            EndTransform = new Vector2(StartTransform.x - 15f, StartTransform.y);
        }

        startTime = Time.time;
        Debug.Log(this.GetComponent<Transform>().position.x + "     " + EndTransform.x);

        if (this.gameObject.name == "FreezBall(Clone)")
        {
            if ((this.GetComponent<Transform>().position.x > EndTransform.x - 0.5f) && (this.GetComponent<Transform>().position.x < EndTransform.x + 0.5f))
            {
                Destroy(this.gameObject);
            }
        }
        else
        {
            if ((this.GetComponent<Transform>().position.x > EndTransform.x - 0.5f) && (this.GetComponent<Transform>().position.x < EndTransform.x + 0.5f))
            {
                Destroy(this.gameObject);
            }

        }
        
    }
	
	// Update is called once per frame
	void Update () {
        journeyLength = Vector2.Distance(this.transform.position, EndTransform);
        float distCovered = (Time.time - startTime) * Speed;
        float fracJourney = distCovered / journeyLength;
        this.transform.position = Vector2.Lerp(this.transform.position, EndTransform, fracJourney);

        if ((this.GetComponent<Transform>().position.x > EndTransform.x - 0.5f) && (this.GetComponent<Transform>().position.x < EndTransform.x + 0.5f))
        {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (( collision.collider.tag == "Enemy") || (collision.collider.tag == "FlyEnemy"))
        {

            if (this.gameObject.name == "FreezBall(Clone)")
            {

                collision.collider.gameObject.GetComponent<Patrol_common_enemy>().Stop = true;
                MoveBackup = collision.collider.gameObject.GetComponent<Transform>();
                collision.collider.gameObject.GetComponent<Transform>().Translate(Vector3.zero);
                EnemyBkp = collision.collider.gameObject;

                Destroy(this.gameObject.GetComponent<BoxCollider2D>());
                if (collision.collider.tag != "Enemy")
                {
                    EnemyTag = collision.collider.tag;
                }
                this.GetComponent<SpriteRenderer>().enabled = false;
                Invoke("UnFreez", 2f);
            }
            else
            {
                Destroy(collision.collider.gameObject);
                Destroy(this.gameObject);

            }
            
        }

        if (collision.collider.tag == "EnemyFrontResist")
        {
            if ((this.transform.position.x < collision.collider.transform.position.x) && (collision.gameObject.GetComponent<Transform>().rotation.eulerAngles.y == 0))
            {
                //this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
                journeyLength = Vector2.Distance(this.transform.position, EndTransform);
                StartTransform = this.GetComponent<Transform>().position;
                EndTransform = new Vector2(StartTransform.x - 15f, StartTransform.y);
                Return = true;
                this.GetComponent<Transform>().eulerAngles = new Vector3(0f, 180f, -90f);

            }

            if ((this.transform.position.x < collision.collider.transform.position.x) && (collision.gameObject.GetComponent<Transform>().rotation.eulerAngles.y == 180))
            {
                Destroy(collision.collider.gameObject);
                Destroy(this.gameObject);

            }

            if ((this.transform.position.x > collision.collider.transform.position.x) && (collision.gameObject.GetComponent<Transform>().rotation.eulerAngles.y == 180))
            {
                //this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
                journeyLength = Vector2.Distance(this.transform.position, EndTransform);
                StartTransform = this.GetComponent<Transform>().position;
                EndTransform = new Vector2(StartTransform.x + 15f, StartTransform.y);
                Return = true;
                this.GetComponent<Transform>().eulerAngles = new Vector3(0f, 180f, 90f);

            }

            if ((this.transform.position.x > collision.collider.transform.position.x) && (collision.gameObject.GetComponent<Transform>().rotation.eulerAngles.y == 0))
            {
                Destroy(collision.collider.gameObject);
                Destroy(this.gameObject);
            }

        }


        if ((collision.collider.tag == "Player") && (Return == true))
        {
            collision.collider.GetComponent<RespawnPoint>().RespawnOn();
            Return = false;
            Destroy(this.gameObject);
        }


        if (collision.collider.tag == "CrashBox")
        {
            Destroy(collision.collider.gameObject); 
        }
    }

    void UnFreez()
    {
        if (EnemyBkp.GetComponent<Patrol_common_enemy>().movingRight == true)
        {
            EnemyBkp.GetComponent<Transform>().Translate((Vector2.right * EnemyBkp.GetComponent<Patrol_common_enemy>().speed * 0.5f));
        }
        else
        {
            EnemyBkp.GetComponent<Transform>().Translate((Vector2.left * EnemyBkp.GetComponent<Patrol_common_enemy>().speed*0.5f));
        }

        EnemyBkp.GetComponent<Patrol_common_enemy>().Stop = false;
        EnemyBkp.tag = EnemyTag;
        Debug.Log("nope");
        Destroy(this.gameObject);

    }
}


