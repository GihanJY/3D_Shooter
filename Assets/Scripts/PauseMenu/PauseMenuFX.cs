using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuFX : MonoBehaviour
{
    [Header("Audio source components")]
    [SerializeField] private AudioSource clickSound;
    [SerializeField] private AudioSource hoverSound;

    [Header("Audio clips")]
    [SerializeField] private AudioClip click;
    [SerializeField] private AudioClip hover;
    
    public void ClickSound()
    {
        clickSound.PlayOneShot(click);
    }
    public void HoverSound()
    {
        hoverSound.PlayOneShot(hover);
    }
}
