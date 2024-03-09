using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe_Controls : MonoBehaviour
{
    public float laneWidth = 16f; // 차선 변경시 이동거리
    public float moveSpeed = 15f; // 전진속도
    private int currentLane = 2; // 출발차선
    private float targetPositionX; // 목표 X 위치
    public Rigidbody rb;
    public float laneChangeSpeed = 2f; // 차선 변경 속도

    public SpawnManager spawnManager;

    void Start()
    {
        // 초기 목표 X 위치 설정
        targetPositionX = rb.position.x;
    }

    void FixedUpdate()
    {
        // 전진 속도 유지
        Vector3 forwardMove = new Vector3(0, 0, moveSpeed * Time.fixedDeltaTime);
        // 현재 X 위치에서 목표 X 위치로 부드럽게 이동
        float newX = Mathf.Lerp(rb.position.x, targetPositionX, laneChangeSpeed * Time.fixedDeltaTime);
        Vector3 newPosition = new Vector3(newX, rb.position.y, rb.position.z) + forwardMove;
        rb.MovePosition(newPosition);
    }

    void Update()
    {
        // 방향키를 이용한 차선 변경
        if (Input.GetKeyDown(KeyCode.RightArrow) && currentLane < 3)
        {
            currentLane++;
            targetPositionX = (currentLane - 1.5f) * laneWidth;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) && currentLane > 0)
        {
            currentLane--;
            targetPositionX = (currentLane - 1.5f) * laneWidth;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //spawnManager.SpawnTriggerEntered();
    }
}
