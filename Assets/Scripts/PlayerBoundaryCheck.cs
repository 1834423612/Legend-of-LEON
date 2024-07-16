/*
    * PlayerBoundaryCheck.cs
    *
    * This script is used to check if the player is within the boundary of the game.
    * If the player goes out of bounds, the player is moved back within the boundary.
    *
*/

using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBoundaryCheck : MonoBehaviour
{
    public float minY = -10f; // The Y position that defines the bottom boundary

    private void Update()
    {
        if (transform.position.y < minY)
        {
            RestartLevel();
        }
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
