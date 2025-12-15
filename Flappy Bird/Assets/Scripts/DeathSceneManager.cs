using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathSceneManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _scoreText; // Score text
    [SerializeField] string _menuSceneName = "MenuScene";

    ScoreManager _scoreManager;

    private void Start()
    {
        // Gets score to add to text
        _scoreManager = GameObject.FindAnyObjectByType<ScoreManager>();
        _scoreText.text = "Score: " + _scoreManager.GetScore().ToString();
        Destroy(_scoreManager.gameObject); // Destroys manager as game is over
    }

    // Loads main menu when button is pressed
    public void LoadMainMenu()
    {
        SceneManager.LoadScene(_menuSceneName);
    }
}
