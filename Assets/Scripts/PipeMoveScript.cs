using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    [Header("Properties")]
    public float moveSpeed = 5.0f;
    public float deadZone = -30.0f;

    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            Debug.Log("Pipe deleted");
            Destroy(gameObject);
        }
    }
}
