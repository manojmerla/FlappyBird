using UnityEngine;

public class spwan : MonoBehaviour
{
    [SerializeField] private int maxheight = 4;
    [SerializeField] private int minheight = -1;
    public int spwanrate = 3;

    [SerializeField] private PoollManager pool; 

    void Start()
    {
        if (pool == null)
            pool = FindObjectOfType<PoollManager>();
    }

    void OnEnable()
    {
        InvokeRepeating(nameof(Spawn), spwanrate, spwanrate);
    }

    void Spawn()
    {
        GameObject newPipe = pool.getbullet(); 

        if (newPipe == null) return;

        newPipe.transform.position = transform.position + Vector3.up * Random.Range(minheight, maxheight);
        newPipe.SetActive(true);
    }

    void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }
}