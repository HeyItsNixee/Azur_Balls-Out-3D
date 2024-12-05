using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HUD_LevelSelect : MonoBehaviour
{
    [SerializeField] private InputField inputField;
    [SerializeField] private GameObject screenOBJ;

    private bool screenState = false;

    private void Start()
    {
        screenOBJ.SetActive(screenState);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
            screenOBJ.SetActive(!screenState);
    }

    public void SubmitLevel()
    {
        int value = int.Parse(inputField.text);
        if (value > 0)
            value = value - 1;
        else
            value = 0;

        PlayerPrefs.SetInt("level", value);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
