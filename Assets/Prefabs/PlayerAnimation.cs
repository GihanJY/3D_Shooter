/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] private Animator PlayerAnimator;
    [SerializeField] private float vInput, hInput;

    private bool isSprint = false;

    void Update()
    {
        GetInputs();

        RunOrSprintForward();
        RunOrSprintBackward();
        RunOrSprintRight();
        RunOrSprintLeft();
        RunOrSprintRight_Fw_Bw();
        RunOrSprintLeft_Fw_Bw();
    }

    private void GetInputs()
    {
        vInput = Input.GetAxis("Vertical");
        hInput = Input.GetAxis("Horizontal");

        if (Input.GetKey(KeyCode.LeftShift))
            isSprint = true;
        else
            isSprint = false;
    }// Input method

    private void RunOrSprintLeft()
    {
        if (hInput < 0 && vInput == 0)
        {
            PlayerAnimator.SetBool("IsRunLeft", true);
            if (isSprint)
            {
                PlayerAnimator.SetBool("IsSprintLeft", true);
            }
            else
            {
                PlayerAnimator.SetBool("IsSprintLeft", false);
            }
        }
        else
        {
            PlayerAnimator.SetBool("IsRunLeft", false);
        }
    }// Run or sprint left

    private void RunOrSprintRight()
    {
        if (hInput > 0 && vInput == 0)
        {
            PlayerAnimator.SetBool("IsRunRight", true);
            if (isSprint)
            {
                PlayerAnimator.SetBool("IsSprintRight", true);
            }
            else
            {
                PlayerAnimator.SetBool("IsSprintRight", false);
            }
        }
        else
        {
            PlayerAnimator.SetBool("IsRunRight", false);
        }
    }// Run or sprint Right

    private void RunOrSprintBackward()
    {
        if (vInput < 0 && hInput == 0)
        {
            PlayerAnimator.SetBool("IsRunBackward", true);
            if (isSprint)
            {
                PlayerAnimator.SetBool("IsSprintBackward", true);
            }
            else
            {
                PlayerAnimator.SetBool("IsSprintBackward", false);
            }
        }
        else
        {
            PlayerAnimator.SetBool("IsRunBackward", false);
        }
    }// Run or sprint Backward

    private void RunOrSprintForward()
    {
        if (vInput > 0 && hInput == 0)
        {
            PlayerAnimator.SetBool("IsRunForward", true);
            if (isSprint)
            {
                PlayerAnimator.SetBool("IsSprintForward", true);
            }
            else
            {
                PlayerAnimator.SetBool("IsSprintForward", false);
            }
        }
        else
        {
            PlayerAnimator.SetBool("IsRunForward", false);
        }
    }// Run or sprint Forward
    
    private void RunOrSprintRight_Fw_Bw()
    {
        if (hInput > 0)
        {
            if (vInput > 0) // Forward and Right
            {
                PlayerAnimator.SetBool("IsRunForwardRight", true);
                if (isSprint)
                {
                    PlayerAnimator.SetBool("IsSprintForwardRight", true);
                }
                else
                {
                    PlayerAnimator.SetBool("IsSprintForwardRight", false);
                }
            }
            else
            {
                PlayerAnimator.SetBool("IsRunForwardRight", false);
            }

            if (vInput < 0) // Backward and Right
            {
                PlayerAnimator.SetBool("IsRunBackwardRight", true);
                if (isSprint)
                {
                    PlayerAnimator.SetBool("IsSprintBackwardRight", true);
                }
                else
                {
                    PlayerAnimator.SetBool("IsSprintBackwardRight", false);
                }
            }
            else
            {
                PlayerAnimator.SetBool("IsRunBackwardRight", false);
            }
        }
    }// Run or sprint ForwardRight / BackwardRight
    
    private void RunOrSprintLeft_Fw_Bw()
    {
        if (hInput < 0)
        {
            if (vInput > 0) // Forward and Left
            {
                PlayerAnimator.SetBool("IsRunForwardLeft", true);
                if (isSprint)
                {
                    PlayerAnimator.SetBool("IsSprintForwardLeft", true);
                }
                else
                {
                    PlayerAnimator.SetBool("IsSprintForwardLeft", false);
                }
            }
            else
            {
                PlayerAnimator.SetBool("IsRunForwardLeft", false);
            }

            if (vInput < 0) // Backward and Left
            {
                PlayerAnimator.SetBool("IsRunBackwardLeft", true);
                if (isSprint)
                {
                    PlayerAnimator.SetBool("IsSprintBackwardLeft", true);
                }
                else
                {
                    PlayerAnimator.SetBool("IsSprintBackwardLeft", false);
                }
            }
            else
            {
                PlayerAnimator.SetBool("IsRunBackwardLeft", false);
            }
        }
    }// Run or sprint ForwardLeft / BackwardLeft
}// Class*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] private Animator PlayerAnimator;
    [SerializeField] private float vInput, hInput;

    void Update()
    {
        GetInputs();

        RunOrSprintForward();
        RunOrSprintBackward();
        RunOrSprintRight();
        RunOrSprintLeft();
        RunOrSprintRight_Fw_Bw();
        RunOrSprintLeft_Fw_Bw();
    }

    private void GetInputs()
    {
        vInput = Input.GetAxis("Vertical");
        hInput = Input.GetAxis("Horizontal");
    }

    private void RunOrSprintLeft()
    {
        if (hInput < 0 && vInput == 0)
        {
            PlayerAnimator.SetBool("IsRunLeft", true);
            PlayerAnimator.SetBool("IsSprintLeft", Input.GetKey(KeyCode.LeftShift));
        }
        else
        {
            PlayerAnimator.SetBool("IsRunLeft", false);
        }
    }

    private void RunOrSprintRight()
    {
        if (hInput > 0 && vInput == 0)
        {
            PlayerAnimator.SetBool("IsRunRight", true);
            PlayerAnimator.SetBool("IsSprintRight", Input.GetKey(KeyCode.LeftShift));
        }
        else
        {
            PlayerAnimator.SetBool("IsRunRight", false);
        }
    }

    private void RunOrSprintBackward()
    {
        if (vInput < 0 && hInput == 0)
        {
            PlayerAnimator.SetBool("IsRunBackward", true);
            PlayerAnimator.SetBool("IsSprintBackward", Input.GetKey(KeyCode.LeftShift));
        }
        else
        {
            PlayerAnimator.SetBool("IsRunBackward", false);
        }
    }

    private void RunOrSprintForward()
    {
        if (vInput > 0 && hInput == 0)
        {
            PlayerAnimator.SetBool("IsRunForward", true);
            PlayerAnimator.SetBool("IsSprintForward", Input.GetKey(KeyCode.LeftShift));
        }
        else
        {
            PlayerAnimator.SetBool("IsRunForward", false);
        }
    }

    private void RunOrSprintRight_Fw_Bw()
    {
        if (hInput > 0)
        {
            if (vInput > 0) // Forward and Right
            {
                PlayerAnimator.SetBool("IsRunForwardRight", true);
                PlayerAnimator.SetBool("IsSprintForwardRight", Input.GetKey(KeyCode.LeftShift));
            }
            else
            {
                PlayerAnimator.SetBool("IsRunForwardRight", false);
            }

            if (vInput < 0) // Backward and Right
            {
                PlayerAnimator.SetBool("IsRunBackwardRight", true);
                PlayerAnimator.SetBool("IsSprintBackwardRight", Input.GetKey(KeyCode.LeftShift));
            }
            else
            {
                PlayerAnimator.SetBool("IsRunBackwardRight", false);
            }
        }
    }

    private void RunOrSprintLeft_Fw_Bw()
    {
        if (hInput < 0)
        {
            if (vInput > 0) // Forward and Left
            {
                PlayerAnimator.SetBool("IsRunForwardLeft", true);
                PlayerAnimator.SetBool("IsSprintForwardLeft", Input.GetKey(KeyCode.LeftShift));
            }
            else
            {
                PlayerAnimator.SetBool("IsRunForwardLeft", false);
            }

            if (vInput < 0) // Backward and Left
            {
                PlayerAnimator.SetBool("IsRunBackwardLeft", true);
                PlayerAnimator.SetBool("IsSprintBackwardLeft", Input.GetKey(KeyCode.LeftShift));
            }
            else
            {
                PlayerAnimator.SetBool("IsRunBackwardLeft", false);
            }
        }
    }
}

