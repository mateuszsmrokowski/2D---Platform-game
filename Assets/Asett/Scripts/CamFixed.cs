using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFixed : MonoBehaviour {
    private Transform Player;

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

        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Player.GetComponent<PllayerController>().HP > 0)
        {
            this.transform.position = new Vector3(Player.position.x, Player.position.y, -10f);

        }

	}

    private void LateUpdate()
    {
        //this.GetComponent<Camera>().transform.rotation = Quaternion.Euler(0, 0, 0);
    }

    private void FixedUpdate()
    {
        //this.GetComponent<Camera>().transform.rotation = Quaternion.Euler(0, 0, 0);
    }
}
