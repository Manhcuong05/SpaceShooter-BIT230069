using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    void Update()
    {
        // Lấy vị trí chuột trên màn hình
        Vector3 mousePos = Input.mousePosition;
        // Chuyển đổi sang tọa độ trong game (World Point)
        Vector3 worldPoint = Camera.main.ScreenToWorldPoint(mousePos);
        
        // Giữ nguyên độ sâu Z = 0
        worldPoint.z = 0;
        
        // Gán vị trí máy bay bằng vị trí chuột
        transform.position = worldPoint;
    }
}