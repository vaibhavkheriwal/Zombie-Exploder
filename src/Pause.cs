using UnityEngine.SceneManagement;
using UnityEngine;
public class Pause : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.End))
        {
            SceneManager.LoadScene(1);
        }
        if (Input.GetKeyUp(KeyCode.Home))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            SceneManager.LoadScene(0);
        }
    }
}