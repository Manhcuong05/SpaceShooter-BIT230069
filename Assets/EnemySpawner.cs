using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnRate = 1.5f; // 1.5 giây ra 1 con
    float nextSpawn = 0f;

    void Update()
    {
        if (Time.time > nextSpawn)
        {
            // Random vị trí chiều ngang (X)
            float randX = Random.Range(-2.5f, 2.5f);
            Vector3 spawnPos = new Vector3(randX, 6f, 0); // Xuất hiện ở trên cao
            
            Instantiate(enemyPrefab, spawnPos, Quaternion.Euler(0,0,180)); // Xoay 180 độ
            
            nextSpawn = Time.time + spawnRate;
        }
    }
}