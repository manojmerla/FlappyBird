using UnityEngine;
using TMPro;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverPanel;

    public TextMeshProUGUI gameOverScoreText;
    public TextMeshProUGUI gameOverHighScoreText;

    void Start()
    {
        gameOverPanel.SetActive(false);
    }

    public void GameOver()
    {
        
        ScoreManager.instance.SaveHighScore();

        
        gameOverScoreText.text = "Score : " + ScoreManager.instance.score;
        gameOverHighScoreText.text = "High Score : " + ScoreManager.instance.GetHighScore();

        
        gameOverPanel.SetActive(true);

        
        Time.timeScale = 0f;
    }


}