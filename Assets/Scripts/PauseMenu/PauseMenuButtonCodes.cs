using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuButtonCodes : MonoBehaviour
{
    [SerializeField] protected GameObject settingsPanel;

    private Animator SettingsAnim;
    [SerializeField] private Canvas pauseMenuCanvas;
    [SerializeField] private Animator SettingsAnimator;
    [SerializeField] private PauseMenuBehaviour pauseMenuScript;

    private void Start()
    {
        SettingsAnim = settingsPanel.GetComponent<Animator>();
    }
    public void resume()
    {
        pauseMenuScript.PauseGame();
    }
    public void openSettings()
    {
        SettingsAnim.SetTrigger("SettingsOn");
    }
    public void closeSettings()
    {
        SettingsAnim.SetTrigger("SettingsOff");
    }
    public void quitToMainMenu()
    {
        MenuBehavior.prevScene = 1;
        SceneManager.LoadScene(0);
    }
    public void quitGame()
    {
        Application.Quit();
    }
}
