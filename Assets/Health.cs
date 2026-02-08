using UnityEngine;

public class Health : MonoBehaviour
{
    public int defaultHealthPoint = 1; // Máu mặc định
    protected int healthPoint;         // Máu hiện tại
    public GameObject explosionPrefab; // Hiệu ứng nổ

    protected virtual void Start()
    {
        healthPoint = defaultHealthPoint;
    }

    // Hàm nhận sát thương
    public void TakeDamage(int damage)
    {
        healthPoint -= damage;
        if (healthPoint <= 0)
        {
            Die();
        }
    }

    // Hàm chết (cho phép ghi đè - override)
    protected virtual void Die()
    {
        // Tạo hiệu ứng nổ nếu có
        if (explosionPrefab != null)
        {
            GameObject explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);
            Destroy(explosion, 1f); // Xóa nổ sau 1s
        }
        
        // Hủy đối tượng
        Destroy(gameObject);
    }
}