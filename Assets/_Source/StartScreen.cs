// Import necessary Unity Engine libraries
using UnityEngine;
using UnityEngine.SceneManagement;

// Define the StartScreen class
public class StartScreen : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Check if any key is pressed
        if (Input.anyKeyDown)
        {
            // Call method to load the MainGame scene
            LoadMainGame();
        }
    }
    // Method to load the MainGame scene
    private void LoadMainGame()
    {
        // Load the MainGame scene
        SceneManager.LoadScene("MainMenu");
    }
}
