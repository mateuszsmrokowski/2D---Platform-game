using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardControll : MonoBehaviour {

    private GameObject Script;
    PllayerController PC;

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

    // Use this for initialization
    void Start () {

        //PllayerController Script = GetComponent<PllayerController>();

        PC = GameObject.FindGameObjectWithTag("Player").GetComponent<PllayerController>();
}
	
	// Update is called once per frame
    
	void Update () {
		if (Input.GetKeyDown("w"))
        {
            PC.Jump();
        }

        if (Input.GetKeyUp("w"))
        {
			PC.JumpOver ();
        }

        if (Input.GetKeyDown("a"))
        {
            PC.MoveLeft();
        }

        if (Input.GetKeyUp("a"))
        {
            PC.MoveNone();
        }

        if (Input.GetKeyDown("d"))
        {
            PC.MoveRight();
        }

        if (Input.GetKeyUp("d"))
        {
            PC.MoveNone();
        }

        if (Input.GetKeyDown("s"))
        {
            PC.Enter();
        }

        if (Input.GetKeyUp("s"))
        {
            PC.EnterEnd();
        }

        if (Input.GetKeyDown("q"))
        {
            PC.GetComponent<Player>().NextSkill();
        }

        if (Input.GetKeyDown("r"))
        {
            PC.GetComponent<Player>().UseSkill();
        }

    }

}
