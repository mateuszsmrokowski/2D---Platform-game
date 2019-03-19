using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyEnemy : MonoBehaviour {

    public float MaxHorizontalDistance, MinJumpHeigh;
    private Vector2 StartPos;
    private bool MoveRight = true;
    public float speed;
    public float BombChance = 0.5f;
    public GameObject BombPref;
    public Canvas CmRef;


	// Use this for initialization
	void Start () {
        StartPos = this.GetComponent<Transform>().transform.position;
        InvokeRepeating("drop_chance", 0f, 0.5f);

    }

    // Update is called once per frame
    void Update() {
        this.transform.Translate(Vector2.right * speed * Time.deltaTime);

        if (this.GetComponent<Transform>().transform.position.x >= (StartPos.x + MaxHorizontalDistance))
        {
            transform.eulerAngles = new Vector3(0, -180, 0);
            //Debug.Log("No hey prawo");
        }

        if (this.GetComponent<Transform>().transform.position.x <= (StartPos.x - MaxHorizontalDistance))
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
            //Debug.Log("No hey lewo");
        }

        if (this.GetComponent<Transform>().transform.position.y <= (StartPos.y - MinJumpHeigh))
        {
            this.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 75f));
            //Debug.Log("No hey ziemia");
        }

        

    }

    void drop_chance()
    {
        if (Random.value > BombChance)
        {
            GameObject Bomb;
            Bomb = Instantiate(BombPref, this.GetComponent<Transform>().position, new Quaternion(0f, 0f, 0f, 0f));
            Bomb.transform.SetParent(CmRef.transform, false);
            Bomb.transform.position = this.GetComponent<Transform>().position;
        }
    }
}
