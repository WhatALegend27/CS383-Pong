using UnityEngine;

public class HelpScreenManager : MonoBehaviour
{
    public GameObject helpPanel;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1)) ToggleHelp();
    }

    void ToggleHelp()
    {
        // Flips the active state of the panel
        bool isActive = helpPanel.activeSelf;
        helpPanel.SetActive(!isActive);

        // Pauses the game
        if (helpPanel.activeSelf)
            Time.timeScale = 0f;
        else
            Time.timeScale = 1f;
    }
}
