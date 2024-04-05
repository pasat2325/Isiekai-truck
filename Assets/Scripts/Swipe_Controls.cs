using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe_Controls : MonoBehaviour
{
    public float laneWidth = 16f; // 차선 변경시 이동거리
    public float moveSpeed; // 전진속도
    private int currentLane = 2; // 출발차선
    private float targetPositionX; // 목표 X 위치
    public Rigidbody rb;
    public float laneChangeSpeed = 2f; // 차선 변경 속도

    public bool isSmashed = false;
    private float originalMoveSpeed; // 원래 moveSpeed 값을 저장할 필드
    public float reflex_force;
    public bool isRestoring = false;

    void Start()
    {
        // 초기 목표 X 위치 설정
        targetPositionX = rb.position.x;
        originalMoveSpeed = moveSpeed;
    }

    void FixedUpdate()
    {
        
            // 전진 속도 설정
            Vector3 forwardMove = new Vector3(0, 0, moveSpeed);
            float targetVelocityX = (targetPositionX - rb.position.x) * laneChangeSpeed;
            Vector3 newVelocity = new Vector3(targetVelocityX, rb.velocity.y, forwardMove.z);
            rb.velocity = newVelocity; //is not smashed
        
        
    }

    private IEnumerator RestoreSpeed()
    {
        isRestoring = true;
        moveSpeed = 0;
        
        float elapsed = 0; // 경과 시간을 추적하는 변수
        float duration = 5f; // 속도를 복원하는 데 걸리는 시간 (5초)

        while (elapsed < duration)
        {
            // 경과 시간에 따라 moveSpeed를 0에서 originalMoveSpeed까지 서서히 증가
            moveSpeed = Mathf.Lerp(0, originalMoveSpeed, elapsed / duration);
            elapsed += Time.deltaTime; // 매 프레임마다 경과 시간 업데이트
            yield return null; // 다음 프레임까지 대기
        }

        isRestoring = false;
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

    public void MoveLeft()
    {
        if (currentLane > 0)
        {
            currentLane--;
            targetPositionX = (currentLane - 1.5f) * laneWidth;
        }
    }

    public void MoveRight()
    {
        if (currentLane < 3)
        {
            currentLane++;
            targetPositionX = (currentLane - 1.5f) * laneWidth;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("EnemyCar"))
        {
            if (!isRestoring) 
            {
                isSmashed = true;
                rb.AddForce(new Vector3(0, 0, -reflex_force));
                StartCoroutine(RestoreSpeed());
            }
            
            
        }

    }

}
