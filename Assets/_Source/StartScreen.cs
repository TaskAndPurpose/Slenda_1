// Import necessary Unity Engine libraries
using UnityEngine;
using UnityEngine.SceneManagement;

// Define the StartScreen class
public class StartScreen : MonoBehaviour
{
    // Serialized field for the button GameObject in the Unity Editor
    [SerializeField] private GameObject buttonObject; // Serialized field for the button GameObject

    // Start is called before the first frame update
    void Start()
    {
        // Ensure the button object is active at the start
        buttonObject.SetActive(true); // Activate the button GameObject
    }

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

    // Method to be called by the button click event
    public void OnButtonClick()
    {
        // Call method to load the MainGame scene
        LoadMainGame();
    }

    // Method to load the MainGame scene
    private void LoadMainGame()
    {
        // Load the MainGame scene
        SceneManager.LoadScene("MainGame");
    }
}
