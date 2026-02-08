using UnityEngine;

// 1. Thay đổi: Kế thừa từ 'Health' thay vì 'MonoBehaviour'
public class EnemyHealth : Health
{
    // 2. Ghi đè hàm Die để thêm logic riêng của Enemy
    protected override void Die()
    {
        Debug.Log("Enemy died"); // In ra console để kiểm tra
        
        // 3. Gọi lại hàm Die của lớp cha (Health) để thực hiện nổ và xóa object
        base.Die(); 
    }
}