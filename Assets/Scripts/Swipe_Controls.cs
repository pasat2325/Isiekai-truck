using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe_Controls : MonoBehaviour
{
    public float laneWidth = 16f; // 차선 변경시 이동거리
    public float moveSpeed = 5f; // 전진속도
    private int currentLane = 2; // 출발차선

    private float currentVelocity = 0f; // SmoothDamp에 필요한 현재 속도 변수

    public Rigidbody rb;

   

    void FixedUpdate()
    {
        rb.velocity = new Vector3(0, 0, moveSpeed);
    }

    void Update()
    {
        // 방향키를 이용한 차선 변경
        if (Input.GetKeyDown(KeyCode.RightArrow) && currentLane < 3)
        {
            currentLane++;
        }

        else if (Input.GetKeyDown(KeyCode.LeftArrow) && currentLane > 0)
        {
            currentLane--;
        }

        // 목표 위치 계산
        float targetPositionX = (currentLane - 1.5f) * laneWidth;

        // SmoothDamp를 사용하여 부드럽게 이동
        float smoothTime = 0.1f; // 부드러운 시간 설정
        float maxSpeed = Mathf.Infinity; // 최대 속도 설정 (여기서는 무한대)
        float newPositionX = Mathf.SmoothDamp(transform.position.x, targetPositionX, ref currentVelocity, smoothTime, maxSpeed);

        // 새로운 위치로 차량 이동
        transform.position = new Vector3(newPositionX, transform.position.y, transform.position.z);
    }
}
