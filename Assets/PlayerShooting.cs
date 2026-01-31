using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab; // Kéo Prefab viên đạn vào đây
    public Transform muzzle;        // Kéo điểm bắn (nòng súng) vào đây

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Bắn ngay tại vị trí của muzzle
            Instantiate(bulletPrefab, muzzle.position, transform.rotation);
        }
    }
}