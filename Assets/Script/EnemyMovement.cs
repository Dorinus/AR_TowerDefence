using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform target;
    public float speed;
    public float distance =0.001f ;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 a = transform.position;
        Vector3 b = target.position;
        if (a==b)
        {
            Destroy(this.gameObject);
        }
        this.transform.LookAt(target);
        
        transform.position = Vector3.MoveTowards(a, b, speed);
       
    }
}
