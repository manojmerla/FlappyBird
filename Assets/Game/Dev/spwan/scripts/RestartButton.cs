using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    public void RestartGame()
    {
        Time.timeScale = 1f;

        
        movepipe.speed = 3f;

    
        ScoreManager.instance.ResetHighScore();

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}