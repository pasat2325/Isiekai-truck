using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yuusha_Movement : MonoBehaviour
{
    public SphereCollider collider;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        rb.velocity = new Vector3(0, 0, 0);
        Debug.Log("yuusha stop");
    }
}
