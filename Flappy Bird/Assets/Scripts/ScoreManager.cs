using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    // Singleton to prevent multiple score managers in the game
    public static ScoreManager instance { get; private set; }

    // Reference to UI score text
    [SerializeField] TextMeshProUGUI _scoreText;

    // Current score of player
    private int _score = 0;

    private void Awake()
    {
        // Destroys instance if it already exists
        if (instance != null && instance != this)
        {
            Destroy(instance.gameObject);
        }

        instance = this;
        DontDestroyOnLoad(gameObject); // Doesn't destroy object when loading new scenes
    }

    // Increases the score when called
    public void IncreaseScore(int score)
    {
        _score += score;
        _scoreText.text = "Score: " + _score.ToString(); // Changes the UI to match new score
    }

    // Gets the current score
    public int GetScore()
    { return _score; }
}
