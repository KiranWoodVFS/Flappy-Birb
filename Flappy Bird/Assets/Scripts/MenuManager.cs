using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class MenuManager : MonoBehaviour
{
    [SerializeField] string _gameSceneName = "GameScene";

    // Loads the game scene when button is pressed
    public void LoadGame()
    {
        SceneManager.LoadScene(_gameSceneName);
    }
}
