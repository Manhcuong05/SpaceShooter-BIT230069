using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public GameObject explosionPrefab; // Nơi chứa Prefab nổ vừa tạo

    // Hàm này tự động chạy khi có vật thể (có Collider + IsTrigger) chạm vào
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Kiểm tra nếu vật chạm vào là Đạn (PlayerBullet) hoặc Player
        // Ở đây mình làm đơn giản: cứ chạm là nổ
        Die();
        
        // Xóa luôn viên đạn vừa chạm vào mình (để đạn không bay xuyên qua)
        Destroy(collision.gameObject);
    }

    private void Die()
    {
        // 1. Tạo ra hiệu ứng nổ ngay tại vị trí của Enemy
        if (explosionPrefab != null)
        {
            GameObject boom = Instantiate(explosionPrefab, transform.position, transform.rotation);
            // 2. Xóa hiệu ứng nổ sau 0.5 giây (để không rác bộ nhớ)
            Destroy(boom, 0.5f); 
        }

        // 3. Xóa chính bản thân Enemy
        Destroy(gameObject);
    }
}