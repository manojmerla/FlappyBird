using UnityEngine;

public class RetryButton : MonoBehaviour
{
    public GameOverManager gameOverManager;

    public void Retry()
    {
        Time.timeScale = 1f;

        movepipe.speed = 3f;

        // Reset current score
        ScoreManager.instance.ResetScore();

        // ✅ Reload saved high score (important fix)
        ScoreManager.instance.ReloadHighScore();

        // Hide panel
        gameOverManager.gameOverPanel.SetActive(false);

        // Reset bird
        Bird bird = FindObjectOfType<Bird>();

        if (bird != null)
        {
            Rigidbody2D rb = bird.GetComponent<Rigidbody2D>();
            rb.velocity = Vector2.zero;

            bird.transform.position = new Vector3(-2, 0, 0);
        }
    }
}