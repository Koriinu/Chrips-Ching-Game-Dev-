using UnityEngine;

public class BirdController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float flapStrength = 5f;
    private bool isAlive = true;

    void Update()
    {
        // Listen for Spacebar or Mouse Click, ensuring the bird is alive
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) && isAlive)
        {
            rb.linearVelocity = Vector2.up * flapStrength; // Reset and push upward
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Triggered when hitting a pipe or the ground
        isAlive = false;
        //FindObjectOfType<GameManager>().GameOver();
    }
}