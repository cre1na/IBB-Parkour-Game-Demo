using UnityEngine;
using UnityEngine.SceneManagement;

public class AutoMove : MonoBehaviour
{
    public float moveSpeed = 5f;
    public string nextScene = "scene0";
    private bool startMoving = false;

    void Update()
    {
        if (startMoving)
        {
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
        }
    }

    public void BeginMovement()
    {
        startMoving = true;

        Animator anim = GetComponent<Animator>();
        if (anim != null)
        {
            anim.SetBool("isRunning", true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("GoalItem"))
        {
            SceneManager.LoadScene(nextScene);
        }
    }
}

