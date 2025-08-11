using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndScene : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(wait());
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(0);
    }
}