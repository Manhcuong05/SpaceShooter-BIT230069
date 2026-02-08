using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed = 10f;
    public int damage = 1; // Sát thương của đạn

    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
        if (transform.position.y > 10f) Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Kiểm tra xem vật va chạm có máu không (EnemyHealth)
        EnemyHealth enemy = other.GetComponent<EnemyHealth>();
        
        if (enemy != null)
        {
            // Gây sát thương
            enemy.TakeDamage(damage);
            
            // Hủy viên đạn
            Destroy(gameObject);
        }
    }
}