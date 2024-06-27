using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab1; // �� ������
    public GameObject enemyPrefab2; // �� ������
    public GameObject enemyPrefab3; // �� ������
    public GameObject enemyPrefab4; // �� ������
    public GameObject enemyPrefab5; // �� ������
    public float enemySpawnInterval = 2f; // ���� �����Ǵ� �ð� ���� (��)

    public GameObject soldierPrefab1; // ��� ������
    public float soldierSpawnInterval = 2f; // ��簡 �����Ǵ� �ð� ���� (��)


    public GameObject player; // �÷��̾� ������Ʈ
    
    private float carTimer = 0f; // Ÿ�̸�
    //private float soldierTimer = 0f; // Ÿ�̸�

    // �����ϰ� ������ x ��ǥ
    private float[] spawnEnemyXPositions = new float[] { -22.5f, -7.5f, 7.5f, 22.5f };

    void Update()
    {
        // Ÿ�̸Ӹ� ������Ʈ�ϰ� ������ ���ݸ��� �� ����
        carTimer += Time.deltaTime;
        if (carTimer > enemySpawnInterval)
        {
            SpawnEnemy();
            carTimer = 0f; // Ÿ�̸� �缳��
        }
        
    }

    void SpawnEnemy()
    {
        // x ��ǥ�� �����ϰ� ����
        int randomIndex = Random.Range(0, spawnEnemyXPositions.Length);
        // �÷��̾� z ��ġ�� 500�� ���� ��ġ ���
        float spawnEnemyZPosition = player.transform.position.z + 500;

        // ���õ� ��ġ�� �� ����
        Vector3 spawnPosition = new Vector3(spawnEnemyXPositions[randomIndex], 0f, spawnEnemyZPosition);
        Instantiate(enemyPrefab1, spawnPosition, Quaternion.identity);
    }

    
}
