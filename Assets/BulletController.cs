using UnityEngine;

public class BulletController : MonoBehaviour
{
    // Phải có chữ "public" thì mới hiện ô chỉnh tốc độ trong Unity
    public float speed = 20f; 

    void Update()
    {
        // 1. Làm viên đạn bay lên trên (Vector2.up)
        transform.Translate(Vector2.up * speed * Time.deltaTime);

        // 2. Tự hủy nếu bay quá xa (ra khỏi màn hình phía trên)
        if (transform.position.y > 10f) 
        {
            Destroy(gameObject);
        }
    }

    // 3. Xử lý va chạm với kẻ địch
    void OnTriggerEnter2D(Collider2D other)
    {
        // Nếu vật chạm vào có Tag là "Enemy"
        if (other.CompareTag("Enemy"))
        {
            // Phá hủy kẻ địch
            Destroy(other.gameObject); 
            // Phá hủy luôn viên đạn
            Destroy(gameObject);       
        }
    }
}