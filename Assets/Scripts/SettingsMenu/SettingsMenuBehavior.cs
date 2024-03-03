using UnityEngine;

public class SettingsMenuBehavior : MonoBehaviour
{
    public int menuIndex;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void settingsOpened()
    {
        menuIndex = 1;
    }
    public void settingsClosed()
    {
        menuIndex = 0;
    }
}
