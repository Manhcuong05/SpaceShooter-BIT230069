using UnityEngine;
using UnityEngine.SceneManagement; // Bắt buộc phải có dòng này để chuyển Scene

public class MainMenu : MonoBehaviour
{
    public void OnPlayButtonClicked()
    {
        // Lưu ý: Thay chữ "Battle" thành ĐÚNG TÊN SCENE bắn súng của bạn (ví dụ: "SampleScene")
        SceneManager.LoadScene("SampleScene"); 
    }
}