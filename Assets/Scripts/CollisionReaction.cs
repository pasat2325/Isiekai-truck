using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionReaction : MonoBehaviour
{
    public Rigidbody rb;

    public float pushForce;

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

            Rigidbody playerRb = other.attachedRigidbody;

            if(rb != null)
            {
                // 뒤 방향.
                Vector3 collisionDirection = new Vector3(0, 0, -1);

                // 계산된 방향의 반대 방향으로 힘을 가합니다. 즉, 충돌한 오브젝트가 왔던 방향으로부터 멀어지게 만듭니다.
                rb.AddForce(collisionDirection * pushForce, ForceMode.Impulse);
            }
        }
    }

    private void DestroySelf()
    {
        Destroy(gameObject);
    }
}
