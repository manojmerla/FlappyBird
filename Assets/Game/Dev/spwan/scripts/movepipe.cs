using UnityEngine;

public class movepipe : MonoBehaviour
{
    public static float speed = 3f;
    public float increaseRate = 30f;

    private float leftEdge;

    private GameObject scorePanel;

    void Start()
    {
        
        scorePanel = GameObject.Find("gameoverpannel");
    }

    void OnEnable()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f;
    }

    void Update()
    {
        if (scorePanel != null && scorePanel.activeSelf)
        {
            speed = 3f;
            return;
        }

        speed += increaseRate * Time.deltaTime;

        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x < leftEdge)
        {
            gameObject.SetActive(false);
        }
    }
}