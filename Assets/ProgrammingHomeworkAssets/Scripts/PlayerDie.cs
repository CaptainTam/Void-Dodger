using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDie : MonoBehaviour
{
    // Tag 
    private string Enemy = "Enemy";

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Checks if the collsion is with an enemy 
        if(collision.gameObject.tag == Enemy)
        {
            // Turn on the canvas and turn off the player game object 
            gameObject.SetActive(false);
            SceneManager.LoadScene("EndGame");

        }
    }

}
