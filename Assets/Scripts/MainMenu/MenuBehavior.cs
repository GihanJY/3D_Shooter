using UnityEngine;

public class MenuBehavior : MonoBehaviour
{
    [SerializeField] private GameObject warningPanel;
    [SerializeField] private GameObject devPanel;
    static public int prevScene = 0;
    void Start()
    {
        Time.timeScale = 1;
        if (prevScene == 0)
        {
           warningPanel.SetActive(true);  
            Invoke("stopWarning", 6);
        }
        else
        {
            GetComponent<Animator>().SetTrigger("ButtonsIn");
        }
    }
    private void stopWarning()
    {
        warningPanel.SetActive(false);
        startDev();
    }
    private void startDev()
    {
        devPanel.SetActive(true);
        Invoke("stopDev",4);
    }
    private void stopDev()
    {
        devPanel.SetActive(false);
        GetComponent<Animator>().SetTrigger("ButtonsIn");
    }
}
