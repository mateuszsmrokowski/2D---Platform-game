using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cont : MonoBehaviour {

    private GameObject Player;
    private PllayerController PC;
    private float value;

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

    //public GameObject Ref;
    // Use this for initialization
    void Start () {
       
        PC = GameObject.FindGameObjectWithTag("Player").GetComponent<PllayerController>();
    }
	
	// Update is called once per frame
	void Update () {
        value = this.GetComponent<SimpleInputNamespace.AxisInputUI>().value;
        if (value == -1)
        {
            //PC.GetComponent<PllayerController>().MoveLeft();
            //Debug.Log(value);
        }

        if (value == 1)
        {
            //PC.GetComponent<PllayerController>().MoveRight();
            //Debug.Log(value);
        }

        if (value == 2)
        {
            //PC.GetComponent<PllayerController>().Jump();
            //Debug.Log(value);
        }

        if (value == -1)
        {
            //PC.GetComponent<PllayerController>().MoveNone();
        }

        if (value == 0)
        {
            //PC.GetComponent<PllayerController>().MoveNone();
            //Debug.Log(value);
        }
    }
}
