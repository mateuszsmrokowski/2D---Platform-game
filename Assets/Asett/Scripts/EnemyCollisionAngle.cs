using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollisionAngle : MonoBehaviour {
    public float CollideAngle;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if ((collision.gameObject.tag == "Enemy") || (collision.gameObject.tag == "EnemyFrontResist"))
        {
            //Debug.Log("Prawie done");
            //Debug.Log(Mathf.Atan2(collision.gameObject.transform.position.y - this.GetComponent<Rigidbody2D>().transform.position.y, collision.gameObject.transform.position.x - this.GetComponent<Rigidbody2D>().transform.position.x)* 180 / Mathf.PI);

            CollideAngle = Mathf.Atan2(collision.gameObject.transform.position.y - this.GetComponent<Rigidbody2D>().transform.position.y, collision.gameObject.transform.position.x - this.GetComponent<Rigidbody2D>().transform.position.x) * 180 / Mathf.PI;
            if ((this.GetComponent<Rigidbody2D>().transform.position.x < collision.gameObject.transform.position.x) && (collision.gameObject.GetComponent<Patrol_common_enemy>().movingRight == true ))
            {
                //Debug.Log(this.GetComponent<Rigidbody2D>().transform.position.x + " " + collision.gameObject.transform.position.x);
                CollideAngle = -1.0f * CollideAngle;
            }
        }
    }
    
}
