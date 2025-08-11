using UnityEngine;
public class ScreenSetting : MonoBehaviour
{
    bool is720p = false;
    void Update()
    {
        if (!is720p && Input.GetKey(KeyCode.RightAlt))
        {
            Screen.SetResolution(1280, 720, true);
        }
        else if (is720p && Input.GetKey(KeyCode.RightAlt))
        {
            Screen.SetResolution(1920, 1080, true);
        }
    }
}