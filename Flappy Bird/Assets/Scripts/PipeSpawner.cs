using System.Collections;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] GameObject _pipePrefab;

    [SerializeField] float _spawnDelay = 50000f; // Time between spawning pipes

    // Range for where pipes can spawn
    [SerializeField] float _minPipeHeight = -2.35f; 
    [SerializeField] float _maxPipeHeight = 3.95f;

    private void OnEnable()
    {
        // Starts spawning pipes
        StartCoroutine(SpawnLoop());
    }

    IEnumerator SpawnLoop()
    {
        // Spawns pipes until disabled
        while (enabled)
        {
            float Ypos = GetRandomYPos();

            // Makes new position using the random y pos
            Vector3 newPos = new Vector3(transform.position.x, Ypos, transform.position.z);

            // Creates pipe
            GameObject pipe = Instantiate(_pipePrefab, newPos, Quaternion.identity);

            // Waits to repeat
            yield return new WaitForSeconds(_spawnDelay);
        }
    }

    // Gets a random Y pos within a range
    float GetRandomYPos()
    {
        return Random.Range(_minPipeHeight, _maxPipeHeight);
    }
}
