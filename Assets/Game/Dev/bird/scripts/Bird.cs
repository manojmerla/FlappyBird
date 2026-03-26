using UnityEngine;

public class Bird : MonoBehaviour
{
    public float jumpForce = 5f;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private GameObject rocket;

    [SerializeField] private AudioSource audioSource; 
    [SerializeField] private AudioClip jumpSound;     
     [SerializeField] private AudioClip Out;   

     void Start()
    {
        Invoke(nameof(Jump),3f);
    }


    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space) || 
            Input.GetMouseButtonDown(1) || 
            Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Jump();
        }

        if (rb.linearVelocity.y < 0)
        {
            rocket.SetActive(false);
        }
    }

    void Jump()
    {
        rb.linearVelocity = Vector2.zero;
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);

        rocket.SetActive(true);

        audioSource.PlayOneShot(jumpSound);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Out"))
        {
            audioSource.PlayOneShot(Out);
            FindObjectOfType<GameOverManager>().GameOver();
        }
    }
}