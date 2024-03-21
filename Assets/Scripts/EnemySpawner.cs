using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab1; // 적 프리팹
    public GameObject enemyPrefab2; // 적 프리팹
    public GameObject enemyPrefab3; // 적 프리팹
    public GameObject enemyPrefab4; // 적 프리팹
    public GameObject enemyPrefab5; // 적 프리팹
    public float enemySpawnInterval = 2f; // 적이 생성되는 시간 간격 (초)

    public GameObject soldierPrefab1; // 용사 프리팹
    public float soldierSpawnInterval = 2f; // 용사가 생성되는 시간 간격 (초)


    public GameObject player; // 플레이어 오브젝트
    
    private float carTimer = 0f; // 타이머
    private float soldierTimer = 0f; // 타이머

    // 랜덤하게 생성할 x 좌표
    private float[] spawnEnemyXPositions = new float[] { -26.5f, -11.5f, 3.5f, 18.5f };

    void Update()
    {
        // 타이머를 업데이트하고 지정된 간격마다 적 생성
        carTimer += Time.deltaTime;
        if (carTimer > enemySpawnInterval)
        {
            SpawnEnemy();
            carTimer = 0f; // 타이머 재설정
        }
        /*soldierTimer += Time.deltaTime;
        if (soldierTimer > soldierSpawnInterval)
        {
            SpawnSoldier();
            soldierTimer = 0f; // 타이머 재설정
        }*/
    }

    void SpawnEnemy()
    {
        // x 좌표를 랜덤하게 선택
        int randomIndex = Random.Range(0, spawnEnemyXPositions.Length);
        // 플레이어 z 위치에 500을 더한 위치 계산
        float spawnEnemyZPosition = player.transform.position.z + 500;

        // 선택된 위치에 적 생성
        Vector3 spawnPosition = new Vector3(spawnEnemyXPositions[randomIndex], 2f, spawnEnemyZPosition);
        Instantiate(enemyPrefab1, spawnPosition, Quaternion.identity);
    }

    void SpawnSoldier()
    {
        int randomIndex = Random.Range(0, spawnEnemyXPositions.Length);
        // 플레이어 z 위치에 470을 더한 위치 계산
        float spawnSoldierZPosition = player.transform.position.z + 470;

        // 선택된 위치에 용사 생성
        Vector3 spawnPosition = new Vector3(spawnEnemyXPositions[randomIndex], 0f, spawnSoldierZPosition);
        Instantiate(soldierPrefab1, spawnPosition, Quaternion.identity);
    }
}
