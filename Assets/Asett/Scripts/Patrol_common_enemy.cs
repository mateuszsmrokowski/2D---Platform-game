using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol_common_enemy : MonoBehaviour {

	public float speed;
	public float distance;
    public bool movingRight;
    public bool Stop = false;
    public Transform groundDetection;
    private RaycastHit2D blockInfo;
    private int LayerMask1 = 1 << 9;
    private int LayerMask2 = 1 << 14;
    public string EnemyType; // 

    public GameObject enemyparticle;

    private void Start()
    {
        LayerMask1 = LayerMask1 | LayerMask2;
		LayerMask1 = ~LayerMask1;
        if (this.gameObject.tag == "EnemyFrontResist")
        {
            movingRight = false;
        }

        //Physics2D.IgnoreCollision(this.GetComponent<BoxCollider2D>().collider, this.GetComponent<BoxCollider2D>().collider, true);
    }

    void Update(){

        if (( this.gameObject.tag == "EnemyFrontResist") && (Stop == false))
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            //movingRight = false;
        }
        else
        {
            if (Stop == false)
            {
                transform.Translate(Vector2.right * speed * Time.deltaTime);
            }
        }


		//transform.Translate (Vector2.right * speed * Time.deltaTime);

		RaycastHit2D groundInfo = Physics2D.Raycast (groundDetection.position, Vector2.down, distance, LayerMask1);


        RaycastHit2D blockInfo = Physics2D.Raycast (groundDetection.position, Vector2.right, distance*0.001f, LayerMask1);
        

        if ((blockInfo.collider == true) || ((groundInfo.collider == false)))
        {
            //Debug.Log("weszlo");

            if (movingRight == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true;
            }

        }
 
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if ((collision.collider.tag == "Lava") || (collision.collider.tag == "Traps"))
        {
            Destroy(this.gameObject);
        }
        
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if ((collision.collider.tag == "Lava") || (collision.collider.tag == "Traps"))
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.GetComponent<Collider2D>().tag == "Lava") || (collision.GetComponent<Collider2D>().tag == "Traps"))
        {
            Destroy(this.gameObject);
        }
    }



}