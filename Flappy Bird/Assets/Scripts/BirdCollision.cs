using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdCollision : MonoBehaviour
{
    [SerializeField] string _deathTag = "Death"; // Tag for objects that will "kill" player
    [SerializeField] string _deathSceneName = "DeathScene"; // Scene for game over

    // Checks if collided with an object that ends game
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag(_deathTag))
        {
            Death();
        }
    }

    // Checks if triggered an object that ends game
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(_deathTag))
        {
            Death();
        }
    }

    // Loads the game over scene
    void Death()
    {
        SceneManager.LoadScene(_deathSceneName);
    }
}
