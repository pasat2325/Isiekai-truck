using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab; // 적 프리팹
    public GameObject player; // 플레이어 오브젝트
    public float spawnInterval = 2f; // 적이 생성되는 시간 간격 (초)
    private float timer = 0f; // 타이머

    // 랜덤하게 생성할 x 좌표
    private float[] spawnXPositions = new float[] { -26.5f, -11.5f, 3.5f, 18.5f };

    void Update()
    {
        // 타이머를 업데이트하고 지정된 간격마다 적 생성
        timer += Time.deltaTime;
        if (timer > spawnInterval)
        {
            SpawnEnemy();
            timer = 0f; // 타이머 재설정
        }
    }

    void SpawnEnemy()
    {
        // x 좌표를 랜덤하게 선택
        int randomIndex = Random.Range(0, spawnXPositions.Length);
        // 플레이어 z 위치에 300을 더한 위치 계산
        float spawnZPosition = player.transform.position.z + 300;

        // 선택된 위치에 적 생성
        Vector3 spawnPosition = new Vector3(spawnXPositions[randomIndex], 0f, spawnZPosition);
        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }
}
