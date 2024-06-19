using UnityEngine;
using System.Collections;

public class PlayerRespawn : MonoBehaviour
{
	//A reference to the game manager
	public GameManager gameManager; 

	// Triggers when the player enters the water
	void OnTriggerEnter(Collider other)
	{
        // Moves the player to the spawn point
        gameManager.PositionPlayer();
        gameManager.ResetGame();
        /*
		gameManager.PositionPlayer();
        gameManager.fpsController.enabled = false;
        StartCoroutine(Start(0.1f));
        IEnumerator Start(float time)
        {
           yield return new WaitForSeconds(time);
            gameManager.fpsController.enabled = true;
        
        }*/


	}
}
