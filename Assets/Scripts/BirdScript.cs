using UnityEngine;

public class BirdScript : MonoBehaviour
{
    [Header("References")]
    public Rigidbody2D myRigidbody;
    public SoundManager soundManager;
    public CircleCollider2D circleCollider;
    [Header("Properties")]
    public float flapStrength;
    public float lowerLimit = -14.0f;
    public bool birdIsAlive = true;

    private LogicManager logicManager;

    public void Start()
    {
        logicManager = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }

        // Check if the bird is very low on screen
        if (transform.position.y < lowerLimit)
        {
            KillBird();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            KillBird();
            // Play hit sound
            soundManager.PlayHitSound();
        }
    }

    public void KillBird()
    {
        logicManager.GameOver();
        birdIsAlive = false;
        // Remove collisions
        circleCollider.enabled = false;
    }
}
