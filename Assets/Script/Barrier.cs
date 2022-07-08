using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour
{
    public GameObject MyBarrier;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if(InPlay.InGame){
            rb.MovePosition(new Vector3(transform.position.x, transform.position.y, transform.position.z - 1));
            if(transform.position.z < -20)
            {
                Destroy(MyBarrier);
            }
        }
    }
}
