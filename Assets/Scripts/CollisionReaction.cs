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

    // OnTriggerEnter �Լ� ����
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            rb.AddForce(new Vector3(200, 300, 300), ForceMode.Impulse);
            rb.AddTorque(transform.forward * 30f, ForceMode.Impulse);
        }
    }

    private void DestroySelf()
    {
        Destroy(gameObject);
    }
}
