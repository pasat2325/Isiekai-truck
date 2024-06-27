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
            MovingDirection = UnityEngine.Random.Range(0, 2); // �̵�����
            MovingSpeed = UnityEngine.Random.Range(5, 20); // �̵� �ӵ�
            YuushaSpawnInterval = UnityEngine.Random.Range(1, 5); // ���� ������ 1-5�ʷ� ����

            Debug.Log("New YuushaSpawnInterval: " + YuushaSpawnInterval);

            SpawnYuusha(MovingDirection, MovingSpeed);
            YuushaTimer = 0f; // Ÿ�̸� �缳��
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


