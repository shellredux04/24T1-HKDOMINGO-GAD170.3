using UnityEngine;
using UnityEngine.SceneManagement;

public class LavaScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        
            // Restart game if player falls into lava
            SceneManager.LoadScene("Lvl1");
        
    }
}