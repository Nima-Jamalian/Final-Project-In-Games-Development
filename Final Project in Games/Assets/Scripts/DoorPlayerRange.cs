using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorPlayerRange : MonoBehaviour
{
    [SerializeField] UIManager UIManager;
    public bool isPlayerInRange = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isPlayerInRange = true;
            UIManager.DoorTextInstruction(true);
        } 
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isPlayerInRange = false;
            UIManager.DoorTextInstruction(false);
        }
    }
}
