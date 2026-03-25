using UnityEngine;

public class RetryButton : MonoBehaviour
{
    public GameOverManager gameOverManager;

    public void Retry()
    {
        Time.timeScale = 1f;

    
        movepipe.speed = 3f;

        ScoreManager.instance.ResetScore();

        gameOverManager.gameOverPanel.SetActive(false);

        Bird bird = FindObjectOfType<Bird>();

        if (bird != null)
        {
            Rigidbody2D rb = bird.GetComponent<Rigidbody2D>();
            rb.linearVelocity = Vector2.zero;

            bird.transform.position = new Vector3(-2, 0, 0);
        }
    }
}