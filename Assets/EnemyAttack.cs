using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public int damage = 1; // Sát thương gây ra cho player
    private EnemyHealth myHealth; // Máu của chính kẻ địch này

    void Start()
    {
        myHealth = GetComponent<EnemyHealth>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        // Kiểm tra xem va chạm có phải là Player không
        PlayerHealth player = collision.GetComponent<PlayerHealth>();

        if (player != null)
        {
            // 1. Gây sát thương cho Player
            player.TakeDamage(damage);

            // 2. Kẻ địch tự sát (trừ 1000 máu để chết ngay lập tức)
            if (myHealth != null)
            {
                myHealth.TakeDamage(1000);
            }
        }
    }
}