using UnityEngine;
using UnityEngine.SceneManagement;

public class PlatformLoseScript : MonoBehaviour
{
    public GameObject particlePrefab; // Reference to the particle effect prefab
    private int lossCounter = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player collided with platform."); // Check if collision with player is detected
            
            // Increment the loss counter
            lossCounter++;

            // Call the LoseLevel method
            LoseLevel();
        }
    }

    public void LoseLevel()
    {
        Debug.Log("You Lose!");

        // Check if the loss counter reaches a certain threshold
        if (lossCounter >= 3)
        {
            // Perform actions when the player loses three times
            // For example, reload the current scene
            SceneManager.LoadScene("Lvl1");
        }
    }
}
