using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionReaction : MonoBehaviour
{
    public Rigidbody rb;
    public CapsuleCollider collide;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroySelf", 20f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        //if (other.gameObject.CompareTag("Player"))
        //{
            rb.AddForce(new Vector3(200, 300, 300),ForceMode.Impulse);
            rb.AddTorque(transform.forward * 30f, ForceMode.Impulse);
            
        //}
    }

    private void DestroySelf()
    {
        Destroy(gameObject);
    }
}
