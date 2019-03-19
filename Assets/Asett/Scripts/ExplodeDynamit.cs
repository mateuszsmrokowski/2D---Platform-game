using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;

public class ExplodeDynamit : MonoBehaviour
{
    public GameObject explosion;
    private Collider2D[] Objects;
    public DynamDestroy DynamEx;

    private void Start()
    {
        Invoke("Explode", 3f);
        //DynamEx = GetComponent<DynamDestroy>();
    }


    private void Explode()
    {
        Objects = Physics2D.OverlapCircleAll(this.transform.position, 1f);
        Debug.Log(this.transform.position);
        int i = 0;
        Debug.Log(Objects.Length);
        while (i < Objects.Length)
        {
            Debug.Log(Objects[i].tag);
            //Debug.Log("Kurwa");
            if ((Objects[i].tag == "CrashGround") || (Objects[i].tag == "Enemy"))
            {
                //Debug.Log("Cos weszlo");
                Destroy(Objects[i].gameObject);
            }
            i++;
        }
        Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }

    private void OnDrawGizmos()
    {
        //Gizmos.DrawSphere(this.transform.position, 1f);
    }

}
    