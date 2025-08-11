using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    void Start()
    {
        Screen.SetResolution(1920, 1080, true);
    }
    public void Play()
    {
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
        Application.Quit();
    }
}