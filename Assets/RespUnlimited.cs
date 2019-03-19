using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespUnlimited : MonoBehaviour
{

    public List<Vector2> Enemys;
    public List<GameObject> EnemysExist;
    // Use this for initialization
    void Start()
    {
        foreach (Transform child in transform)
        {
            Enemys.Add(child.transform.position);
            EnemysExist.Add(child.transform.gameObject);
        }
        InvokeRepeating("RespawnEnemys", 10f, 10f);
    }

    // Update is called once per frame
    void RespawnEnemys()
    {
        for (int i = 0; i < EnemysExist.Count; i++)
        {
            //if (EnemysExist[i] == null)
            {
                GameObject Enemy = Instantiate(Resources.Load("Common_enemy (2)"), new Vector2(Enemys[i].x, Enemys[i].y), new Quaternion(0f, 0f, 0f, 0f)) as GameObject;
                Enemy.GetComponent<Patrol_common_enemy>().distance = 20f;
                EnemysExist[i] = Enemy;
            }
        }

    }
}
