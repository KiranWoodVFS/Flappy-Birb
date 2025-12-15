using System.Collections;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    [SerializeField] float _pipeSpeed = 0.1f; // Speed of movement
    [SerializeField] float _lifetime = 10f; // How long until pipe is destroyed

    private void Start()
    {
        StartCoroutine(Death());
    }

    private void Update()
    {
        // Moves the pipe a steady speed
        transform.position = new Vector3(transform.position.x - (_pipeSpeed * Time.deltaTime), transform.position.y, transform.position.z);
    }

    // Destroys pipe after set timnes
    IEnumerator Death()
    {
        yield return new WaitForSeconds(_lifetime);
        Destroy(gameObject);
    }
}
