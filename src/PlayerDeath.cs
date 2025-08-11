using UnityEngine.SceneManagement;
using UnityEngine;
public class PlayerDeath : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Z")
        {
            SceneManager.LoadScene(2);
        }
    }
}