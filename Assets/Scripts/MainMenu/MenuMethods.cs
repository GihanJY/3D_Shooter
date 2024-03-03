using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuMethods : MonoBehaviour
{
    [SerializeField] private GameObject settingsPanel;
    [SerializeField] private GameObject creditsPanel;
    [SerializeField] private GameObject[] gacPanels;
    [SerializeField] private Button[] graphicButtons;
    [SerializeField] private Button[] resButtons;
    [SerializeField] private AudioSource click;
    [SerializeField] private AudioSource buttonHover;
    [SerializeField] private Toggle fullscreenToggle;
    private Animator menuAnim;
    private int menuIndex = 0;
    private void Start()
    {
        menuAnim = GameObject.FindGameObjectWithTag("MainMenu").GetComponent<Animator>();
        if (PlayerPrefs.GetInt("LevelToPlay") < 1)
        {
            GameObject.FindGameObjectWithTag("continueButton").GetComponent<Button>().interactable = false;
            GameObject.FindGameObjectWithTag("continueButtonText").GetComponent<Text>().color = Color.gray;
        }
        else
        {
            GameObject.FindGameObjectWithTag("continueButton").GetComponent<Button>().interactable = true;
            GameObject.FindGameObjectWithTag("continueButtonText").GetComponent<Text>().color = Color.white;
        }
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)&&menuIndex==1&&settingsPanel.activeInHierarchy)
        {
            CloseSettings();
        }
        if (Input.GetKeyDown(KeyCode.Escape) && menuIndex == 1 && creditsPanel.activeInHierarchy)
        {
            CloseCredits();
        }
        selectQuality();
        selectRes();
        
    }
    public void continueGame()
    {
        buttonsOut();
        SceneManager.LoadScene(PlayerPrefs.GetInt("LevelToPlay"));
    }
    public void NewGame()
    {
        buttonsOut();
        SceneManager.LoadScene(1);
    }
    public void OpenSettings()
    {
        buttonsOut();
        settingsPanel.SetActive(true);
        if (!gacPanels[0].activeInHierarchy && !gacPanels[1].activeInHierarchy && !gacPanels[2].activeInHierarchy)
        {
            gacPanels[0].SetActive(true);
        }
        settingsPanel.GetComponent<Animator>().SetTrigger("OpenSettings");
        buttonSelected();
        menuIndex = 1;
    }
    public void CloseSettings()
    {
        settingsPanel.GetComponent<Animator>().SetTrigger("CloseSettings");
        settingsPanel.SetActive(false);
        menuIndex = 0;
        buttonsIn();
    }
    public void OpenCredits()
    {
        buttonsOut();
        creditsPanel.SetActive(true);
        creditsPanel.GetComponent<Animator>().SetTrigger("OpenCredits");
        menuIndex = 1;
    }
    public void CloseCredits()
    {
        creditsPanel.GetComponent<Animator>().SetTrigger("CloseCredits");
        creditsPanel.SetActive(false);
        menuIndex = 0;
        buttonsIn();
    }
    public void QuitGame()
    {
        buttonsOut();
        Application.Quit();
    }
    public void openGraphics()
    {
        gacPanels[1].SetActive(false);
        gacPanels[2].SetActive(false);
        gacPanels[0].SetActive(true);
        menuIndex = 1;
        buttonSelected();
    }
    public void openAudio()
    {
        gacPanels[2].SetActive(false);
        gacPanels[0].SetActive(false);
        gacPanels[1].SetActive(true);
        menuIndex = 1;
        buttonSelected();
    }
    public void openControls()
    {
        gacPanels[0].SetActive(false);
        gacPanels[1].SetActive(false);
        gacPanels[2].SetActive(true);
        menuIndex = 1;
        buttonSelected();
    }
    public void buttonHoverFX()
    {
        buttonHover.Play();
    }
    public void buttonClickFX()
    {
        click.Play();
    }
    public void res13366x768()
    {
        Screen.SetResolution(1366, 768, true);
    }
    public void res1920x1080()
    {
        Screen.SetResolution(1920, 1080, true);
    }
    public void res2560x1440()
    {
        Screen.SetResolution(2560, 1440, true);
    }
    public void res3840x2160()
    {
        Screen.SetResolution(3840, 2160, true);
    }
    public void lowQuality()
    {
        QualitySettings.SetQualityLevel(0);
    }
    public void mediumQuality()
    {
        QualitySettings.SetQualityLevel(1);
    }
    public void highQuality()
    {
        QualitySettings.SetQualityLevel(2);
    }
    public void ultraQuality()
    {
        QualitySettings.SetQualityLevel(3);
    }
    public void changeFullscreenMode()
    {
        if(fullscreenToggle.isOn)
        {
            Screen.fullScreenMode = FullScreenMode.FullScreenWindow;
            Debug.Log("FS");
        }
        else
        {
            Screen.fullScreenMode = FullScreenMode.Windowed;
            Debug.Log("W");
        }
    }
    private void buttonsIn()
    {
        menuAnim.SetTrigger("ButtonsIn");
    }
    private void buttonsOut()
    {
        menuAnim.SetTrigger("ButtonsOut");
    }
    private void buttonSelected()
    {
        if (gacPanels[0].activeInHierarchy)
        {
            GameObject.FindGameObjectWithTag("Button0").GetComponent<Button>().interactable = false;
            GameObject.FindGameObjectWithTag("Button1").GetComponent<Button>().interactable = true;
            GameObject.FindGameObjectWithTag("Button2").GetComponent<Button>().interactable = true;
        }
        else if (gacPanels[1].activeInHierarchy)
        {

            GameObject.FindGameObjectWithTag("Button0").GetComponent<Button>().interactable = true;
            GameObject.FindGameObjectWithTag("Button1").GetComponent<Button>().interactable = false;
            GameObject.FindGameObjectWithTag("Button2").GetComponent<Button>().interactable = true;
        }
        else
        {
            GameObject.FindGameObjectWithTag("Button0").GetComponent<Button>().interactable = true;
            GameObject.FindGameObjectWithTag("Button1").GetComponent<Button>().interactable = true;
            GameObject.FindGameObjectWithTag("Button2").GetComponent<Button>().interactable = false;
        }
    }
    private void selectRes()
    {
        if(Screen.currentResolution.width == 1366 && Screen.currentResolution.height == 768)
        {
            resButtons[0].GetComponent<Button>().interactable = false;
            resButtons[1].GetComponent<Button>().interactable = true;
            resButtons[2].GetComponent<Button>().interactable = true;
            resButtons[3].GetComponent<Button>().interactable = true;
        }
        else if (Screen.currentResolution.width == 1920 && Screen.currentResolution.height == 1080)
        {
            resButtons[0].GetComponent<Button>().interactable = true;
            resButtons[1].GetComponent<Button>().interactable = false;
            resButtons[2].GetComponent<Button>().interactable = true;
            resButtons[3].GetComponent<Button>().interactable = true;
        }
        else if (Screen.currentResolution.width == 2560 && Screen.currentResolution.height == 1440)
        {
            resButtons[0].GetComponent<Button>().interactable = true;
            resButtons[1].GetComponent<Button>().interactable = true;
            resButtons[2].GetComponent<Button>().interactable = false;
            resButtons[3].GetComponent<Button>().interactable = true;
        }
        else if (Screen.currentResolution.width == 3840 && Screen.currentResolution.height == 2160)
        {
            resButtons[0].GetComponent<Button>().interactable = true;
            resButtons[1].GetComponent<Button>().interactable = true;
            resButtons[2].GetComponent<Button>().interactable = true;
            resButtons[3].GetComponent<Button>().interactable = false;
        }
    }
    private void selectQuality()
    {
        if(QualitySettings.GetQualityLevel() == 0)
        {
            graphicButtons[0].GetComponent<Button>().interactable = false;
            graphicButtons[1].GetComponent<Button>().interactable = true;
            graphicButtons[2].GetComponent<Button>().interactable = true;
            graphicButtons[3].GetComponent<Button>().interactable = true;
        }
        else if (QualitySettings.GetQualityLevel() == 1)
        {
            graphicButtons[0].GetComponent<Button>().interactable = true;
            graphicButtons[1].GetComponent<Button>().interactable = false;
            graphicButtons[2].GetComponent<Button>().interactable = true;
            graphicButtons[3].GetComponent<Button>().interactable = true;
        }
        else if (QualitySettings.GetQualityLevel() == 2)
        {
            graphicButtons[0].GetComponent<Button>().interactable = true;
            graphicButtons[1].GetComponent<Button>().interactable = true;
            graphicButtons[2].GetComponent<Button>().interactable = false;
            graphicButtons[3].GetComponent<Button>().interactable = true;
        }
        else if (QualitySettings.GetQualityLevel() == 3)
        {
            graphicButtons[0].GetComponent<Button>().interactable = true;
            graphicButtons[1].GetComponent<Button>().interactable = true;
            graphicButtons[2].GetComponent<Button>().interactable = true;
            graphicButtons[3].GetComponent<Button>().interactable = false;
        }
    }
}
