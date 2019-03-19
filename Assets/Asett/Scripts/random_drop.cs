using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DropSpawn : MonoBehaviour
{
    public GameObject apple;      // Apple Object in Scene (Sprite)
    public GameObject badApple;      // Bad Apple Object in Scene (Sprite)
    public float spawnTime = 2f;            // How long between each spawn.
    public float fallSpeed = 40.0f;    //The speed of falling Apples
    private float timer = 0; //counting timer, reset after calling SpawnRandom() function
    private int randomNumber;       //variable for storage of an random Number

    void Update()
    {
        timer += Time.deltaTime;   // Timer Counter
        if (timer > spawnTime)
        {
            SpawnRandom();       //Calling method SpawnRandom()
            timer = 0;        //Reseting timer to 0
        }
    }
    public void SpawnRandom()
    {

        //Creating random Vector3 position
        Vector3 screenPosition = Camera.main.ScreenToWorldPoint(new Vector3(Random.Range(0, Screen.width), Random.Range(600, Screen.height), Camera.main.farClipPlane / 2));
        //Instantiation of the Apple Object
        Instantiate(apple, screenPosition, Quaternion.identity);
    }
}