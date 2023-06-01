using UnityEngine;

public class PipeTriggerScript : MonoBehaviour
{
    private LogicManager logicManager;
    private SoundManager soundManager;

    private void Start()
    {
        logicManager = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
        soundManager = GameObject.FindGameObjectWithTag("Sound Manager").GetComponent<SoundManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            logicManager.AddScore(1);
            // Play point sfx
            soundManager.PlayPointSound();
        }
    }
}
