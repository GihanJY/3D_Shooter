using UnityEngine;

public class PauseMenuBehaviour : MonoBehaviour
{
    [Header("UI")]
    [SerializeField] private Canvas pauseMenuCanvas;
    [SerializeField] private GameObject settingsMenuPanel;

    [Header("Scripts")]
    [SerializeField] private PauseMenuButtonCodes pauseButtonCodes;
    [SerializeField] private SettingsMenuBehavior settingsCode;

    public bool isPaused = false;
    private int menuIndex;

    private void Start()
    {
        pauseMenuCanvas.enabled = false;
    }

    private void Update()
    {
        menuIndex = settingsCode.menuIndex;

        if (Input.GetKeyDown(KeyCode.Escape) && menuIndex == 0)
        {
            PauseGame();
        }
        else if(Input.GetKeyDown(KeyCode.Escape) && menuIndex == 1)
        {
            pauseButtonCodes.closeSettings();
        }

        if (isPaused)
        {
            pauseMenuCanvas.enabled = true;
            Time.timeScale = 0f;
        }
        else
        {
            pauseMenuCanvas.enabled = false;
            Time.timeScale = 1.0f;
        }
    }

    public void PauseGame()
    {
        isPaused = !isPaused;
    }
}
