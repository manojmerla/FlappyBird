using UnityEngine;

public class Score : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bird"))
        {
            ScoreManager.instance.AddScore(1);
        
        }
    }
}