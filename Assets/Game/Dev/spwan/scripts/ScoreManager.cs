using UnityEngine;
using TMPro;
using System.IO;

[System.Serializable]
public class HighScoreData
{
    public int highScore;
}

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public int score = 0;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;

    string path;
    HighScoreData data = new HighScoreData();

    void Awake()
    {
        instance = this;

        path = Application.persistentDataPath + "/highscore.json";
        LoadHighScore();
    }

    public void AddScore(int value)
    {
        score += value;
        scoreText.text = "Score : " + score;
    }

    public void SaveHighScore()
    {
        if (score > data.highScore)
        {
            data.highScore = score;

            string json = JsonUtility.ToJson(data, true);
            File.WriteAllText(path, json);
        }
    }

    void LoadHighScore()
    {
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            data = JsonUtility.FromJson<HighScoreData>(json);
        }
        else
        {
            data.highScore = 0;
        }

        highScoreText.text = "High Score : " + data.highScore;
    }

    public int GetHighScore()
    {
        return data.highScore;
    }

    // 🔹 RESET SCORE
    public void ResetScore()
    {
        score = 0;
        scoreText.text = "Score : 0";
    }

    // 🔹 RESET HIGH SCORE
    public void ResetHighScore()
    {
        data.highScore = 0;

        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(path, json);

        highScoreText.text = "High Score : 0";
    }
}