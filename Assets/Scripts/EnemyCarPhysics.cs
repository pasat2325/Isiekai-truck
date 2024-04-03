using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyCarPhysics : MonoBehaviour
{
    public Rigidbody rb;
    public float minimum_speed; // 최저속도
    public float maximum_speed; // 최고속도
    // Start is called before the first frame update
    void Start()
    {
        float coming = 0f;
        if(transform.position.x < 0)
        { //1 2 레인
            coming = -1f; //플레이어에게 다가오는
        }
        else //3 4레인
        {
            coming = 1f; //플레이어에게서 멀어지는
        }

        float carSpeed = Random.Range(minimum_speed, maximum_speed) * coming;
        rb.velocity = new Vector3(0, 0, carSpeed );
        if (carSpeed < 0)
        {
            transform.forward = new Vector3(0, 0, -1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
