using UnityEngine;

// Script này quản lý máu của người chơi
public class PlayerHealth : Health
{
    // Ghi đè hàm Die để xử lý khi người chơi chết (Game Over)
    protected override void Die()
    {
        Debug.Log("Player died - GAME OVER");
        // Sau này bạn sẽ thêm lệnh hiện bảng Game Over ở đây
        base.Die();
    }
}