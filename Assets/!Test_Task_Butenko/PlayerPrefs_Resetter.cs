using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPrefs_Resetter : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            PlayerPrefs.SetInt("best", 0);
            PlayerPrefs.SetInt("level", 0);
            PlayerPrefs.SetInt("vibrate", 0);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
