using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionReaction : MonoBehaviour
{
    public Rigidbody rb;

    void Start()
    {
        Invoke("DestroySelf", 40f);
    }

    void Update()
    {

    }

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            rb.AddForce(new Vector3(50f, 30f, 200f), ForceMode.Impulse);
            rb.AddTorque(transform.forward * 100f, ForceMode.Impulse);
        }
    }

    private void DestroySelf()
    {
        Destroy(gameObject);
    }
}
