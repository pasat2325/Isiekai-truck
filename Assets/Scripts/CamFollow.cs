using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public float carSpeed;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = new Vector3(0, 0, carSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
