using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void Change()
    {
        Time.timeScale = 1f;

        
        Bird bird = FindObjectOfType<Bird>();
        if (bird != null)
        {
            Destroy(bird.gameObject);
        }

        SceneManager.LoadScene("Game"); 
    }

    public void BackToMenu()
    {
        Time.timeScale = 1f;

        
        Bird bird = FindObjectOfType<Bird>();
        if (bird != null)
        {
            Destroy(bird.gameObject);
        }

        SceneManager.LoadScene("MainMenu"); 
    }
}