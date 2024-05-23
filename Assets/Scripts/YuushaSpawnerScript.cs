using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YuushaSpawnerScript : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject YuushaOriginal;
    public Rigidbody rb;
    public GameObject Player;

    public float YuushaTimer;
    public float YuushaSpawnInterval;
    public int MovingDirection;
    public int MovingSpeed;

    void Start()
    {
        YuushaTimer = 0f;
        YuushaSpawnInterval = 2f;
    }

    // Update is called once per frame
    void Update()
    {
        YuushaTimer += Time.deltaTime;
        if (YuushaTimer > YuushaSpawnInterval)
        {
            MovingDirection = UnityEngine.Random.Range(0, 2); // 이동방향
            MovingSpeed = UnityEngine.Random.Range(5, 20); // 이동 속도
            YuushaSpawnInterval = UnityEngine.Random.Range(1, 5); // 스폰 간격을 1-5초로 변경

            Debug.Log("New YuushaSpawnInterval: " + YuushaSpawnInterval);

            SpawnYuusha(MovingDirection, MovingSpeed);
            YuushaTimer = 0f; // 타이머 재설정
        }
    }

    private void FixedUpdate()
    {
        
    }

    void SpawnYuusha(int MovingDirection, int MovingSpeed)
    {
        if(MovingDirection == 0)
        {
            GameObject YuushaInstance = Instantiate(YuushaOriginal, new Vector3(32, 3, Player.transform.position.z + 300), Quaternion.identity);
            Rigidbody rb = YuushaInstance.GetComponent<Rigidbody>();

            if (rb != null)
            {
                rb.velocity = new Vector3(-1 * MovingSpeed, 0, 0);
            }
        }
        else if (MovingDirection == 1)
        {
            GameObject YuushaInstance = Instantiate(YuushaOriginal, new Vector3(-32, 3, Player.transform.position.z + 300), Quaternion.identity);
            Rigidbody rb = YuushaInstance.GetComponent<Rigidbody>();

            if (rb != null)
            {
                rb.velocity = new Vector3(MovingSpeed, 0, 0);
            }
        }
    }
}


