using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Button startGameButton;

    [SerializeField] private AudioClip backgroundMusicClip;
    [SerializeField] private AudioClip backgroundOneShotClip;

    private AudioSource musicAudioSource;
    private AudioSource oneShotAudioSource;

    void Start()
    {
        startGameButton.onClick.AddListener(OnClickStartGame);

        // Set up audio source components
        musicAudioSource = gameObject.AddComponent<AudioSource>();
        musicAudioSource.playOnAwake = false; // Ensure music doesn't start playing immediately

        oneShotAudioSource = gameObject.AddComponent<AudioSource>();
        oneShotAudioSource.playOnAwake = false; // Ensure one-shot sound doesn't play immediately

        // Play background music clip
        PlayAudio(backgroundMusicClip, musicAudioSource);

        // Play one-shot sound clip
        PlayAudio(backgroundOneShotClip, oneShotAudioSource);
    }

    void Update()
    {
        // Check for Escape key press to return to start screen
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ReturnToStartScreen();
        }
    }

    public void OnClickStartGame()
    {
        // Load the "MainGame" scene
        SceneManager.LoadScene("MainGame");
    }

    public void ReturnToStartScreen()
    {
        // Load the "StartScreen" scene
        SceneManager.LoadScene("StartScreen");
    }

    void PlayAudio(AudioClip clip, AudioSource source)
    {
        // Check if audio source and clip are valid
        if (source != null && clip != null)
        {
            source.clip = clip;
            source.Play();
        }
    }
}
