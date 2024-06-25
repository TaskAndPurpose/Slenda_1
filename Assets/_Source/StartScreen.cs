using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    [SerializeField] private AudioClip mainBackgroundClip; // Assign your main background audio clip in the Unity Editor
    private AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>(); // Add AudioSource component dynamically

        if (mainBackgroundClip != null)
        {
            // Start playing the main background clip
            StartMainBackground();
        }
        else
        {
            Debug.LogError("Main background clip is not assigned!");
        }
    }

    void Update()
    {
        // Check if any key is pressed
        if (Input.anyKeyDown)
        {
            // Call method to load the MainMenu scene
            LoadMainMenu();
        }
    }

    // Method to start playing the main background clip
    private void StartMainBackground()
    {
        audioSource.clip = mainBackgroundClip;
        audioSource.loop = true;
        audioSource.Play();
    }

    // Method to load the MainMenu scene
    private void LoadMainMenu()
    {
        // Load the MainMenu scene
        SceneManager.LoadScene("MainMenu");
    }
}
