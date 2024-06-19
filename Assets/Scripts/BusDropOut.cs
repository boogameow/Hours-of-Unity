using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine;

public class BusDropOut : MonoBehaviour
{
    public GameObject player;
    public FirstPersonController fpsController;

    // Use this for initialization
    void Start()
    {
        // Finds the First Person Controller script on the Player
        fpsController = player.GetComponent<FirstPersonController>();
    }

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        fpsController.m_WalkSpeed = 20;
        fpsController.m_RunSpeed = 35;
        fpsController.m_JumpSpeed = 50;
    }
}
