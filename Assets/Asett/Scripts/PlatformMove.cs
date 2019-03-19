using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour {

    public float Speed = 0.1f;
    private float startTime;
    private float journeyLength;
    private Vector3 StartTransform;
    private Vector3 EndTransformCopy;
    private Vector3 EndTransform;


    // Use this for initialization
    void Start () {
        StartTransform = this.transform.position;
        EndTransform = new Vector3(StartTransform.x + 5f, StartTransform.y + 0, 0f);
        startTime = Time.time;
        EndTransformCopy = EndTransform;
    }
	
	// Update is called once per frame
	void Update () {

        if (this.transform.position == EndTransform)
        {
            EndTransform = StartTransform;
            startTime = Time.time;
        }

        if (this.transform.position == StartTransform)
        {
            EndTransform = EndTransformCopy;
            //startTime = Time.time;
        }

        journeyLength = Vector2.Distance(this.transform.position, EndTransform);

        float distCovered = (Time.time - startTime) * Speed;
        float fracJourney = distCovered / journeyLength;
        this.transform.position = Vector2.Lerp(this.transform.position, EndTransform, fracJourney);



    }

    void PlaformMove(Vector2 Start, Vector2 End)
    {

    }
}
