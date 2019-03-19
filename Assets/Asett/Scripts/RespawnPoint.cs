using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPoint : MonoBehaviour {
    public Vector2 Respawn;
    public Transform Resp;
    public GameObject HPRef;
    private int HPRemain = 3;

    public StartPoint StartPoint
    {
        get
        {
            throw new System.NotImplementedException();
        }

        set
        {
        }
    }

    public Player Player
    {
        get
        {
            throw new System.NotImplementedException();
        }

        set
        {
        }
    }

    void Start () {

        Respawn = Resp.position;
        HPRemain = this.GetComponent<PllayerController>().HP;

    }
	
	// Update is called once per frame
	void Update () {
        HPRemain = this.GetComponent<PllayerController>().HP;
    }

    public void RespawnOn()
    {
        if (HPRemain > 0)
        {
            Invoke("RespawnFx", 0.0f);
        }
        
    }

    void LoadStartLevel()
    {
        Application.LoadLevel("Startowa Plansza");
        this.GetComponent<PllayerController>().speed = 7f;
    }

    void RespawnFx()
    {
        this.transform.position = Respawn;
        this.GetComponent<PllayerController>().HP--;
        this.gameObject.tag = "Player";
        HPRemain = this.GetComponent<PllayerController>().HP;
        if (HPRemain <= 0)
        {
            Invoke("LoadStartLevel", 0.1f);
        }
    }
}
