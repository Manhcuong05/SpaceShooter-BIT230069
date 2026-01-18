using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab; // Khuôn đạn
    public Transform firePoint;     // Nòng súng
    public float fireRate = 0.2f;   // Tốc độ bắn
    private float nextFire = 0f;

    void Update()
    {
        // Luôn luôn bắn (hoặc giữ chuột trái)
        // Ở đây mình để giữ chuột trái cho dễ kiểm soát
        if (Input.GetMouseButton(0)) 
        {
            if (Time.time > nextFire)
            {
                Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
                nextFire = Time.time + fireRate;
            }
        }
    }
}