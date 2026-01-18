using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float speed = 3f;

    void Update()
    {
        // Bay xuống dưới (Vì tàu đã xoay 180 độ, nên "up" của nó là đi xuống)
        // Hoặc dùng Vector3.down cho chắc chắn
        transform.Translate(Vector3.up * speed * Time.deltaTime);

        // Tự hủy nếu bay ra khỏi màn hình dưới
        if (transform.position.y < -10f) Destroy(gameObject);
    }
}