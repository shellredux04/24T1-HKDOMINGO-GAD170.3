using UnityEngine;
using UnityEngine.SceneManagement;

public class PlatformWinScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Check if 'other' is not null
        if (other != null)
        {
            // Call the WinLevel method when the player enters the trigger
            WinLevel();
        }
    }

    public void WinLevel()
    {
        Debug.Log("You Win!");
        // Reset the scene
        SceneManager.LoadScene("Lvl1");
    }
}