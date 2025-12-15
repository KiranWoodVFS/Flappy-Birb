using UnityEngine;

public class TriggerScore : MonoBehaviour
{
    [SerializeField] int _scoreAmount = 1; // Amount of score gained when triggered

    ScoreManager _scoreManager;
    string _playerTag = "Player";

    private void Start()
    {
        // Gets score manager
        _scoreManager = GameObject.FindAnyObjectByType<ScoreManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        // Checks that if it was player
        if (other.CompareTag(_playerTag))
        {
            // Increases score
            _scoreManager.IncreaseScore(_scoreAmount);
        }
    }
}
