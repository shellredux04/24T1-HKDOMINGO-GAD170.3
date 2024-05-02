using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformCollider : MonoBehaviour
{  
    public GameObject[] blocks; // Array of blocks to check collision with
    public GameObject particlePrefab; // Particle prefab to instantiate upon collision

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the blocks array and particlePrefab are assigned
        if (blocks != null && particlePrefab != null)
        {
            foreach (GameObject block in blocks)
            {
                if (block != null && collision.gameObject == block)
                {
                    // Collision with a block detected
                    Debug.Log("Collision with block detected");

                    // Instantiate particles at the collision point
                    Instantiate(particlePrefab, collision.contacts[0].point, Quaternion.identity);

                    // Destroy the block
                    Destroy(block);

                    // You can add more actions here, such as triggering other events upon collision
                }
            }
        }
        else
        {
            Debug.LogWarning("Blocks array or particle prefab is not assigned.");
        }
    }
}
