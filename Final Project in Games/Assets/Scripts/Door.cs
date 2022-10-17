using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] Animator doorAnimator;
    [SerializeField] DoorPlayerRange DoorPlayerRange;
    [SerializeField] AudioSource openDoorAudioSource;
    [SerializeField] AudioSource closeDoorAudioSource;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (DoorPlayerRange.isPlayerInRange == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                //Check status of the door
                if (doorAnimator.GetBool("openDoor") == true)
                {
                    //Play close door animation
                    doorAnimator.SetBool("openDoor", false);
                    openDoorAudioSource.Play();
                }
                else
                {
                    //Play open door animation
                    doorAnimator.SetBool("openDoor", true);
                    closeDoorAudioSource.Play();
                }
            }
        }
    }
}
