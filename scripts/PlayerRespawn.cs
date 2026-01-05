using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    public Transform spawnPoint; 
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (transform.position.y < -10f)
        {
            Respawn();
        }
    }

    void Respawn()
    {
        rb.linearVelocity = Vector2.zero;
        transform.position = spawnPoint.position;
    }
}

