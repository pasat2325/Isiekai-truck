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
                // �� ����.
                Vector3 collisionDirection = new Vector3(0, 0, -1);

                // ���� ������ �ݴ� �������� ���� ���մϴ�. ��, �浹�� ������Ʈ�� �Դ� �������κ��� �־����� ����ϴ�.
                rb.AddForce(collisionDirection * pushForce, ForceMode.Impulse);
            }
        }
    }

    private void DestroySelf()
    {
        Destroy(gameObject);
    }
}
