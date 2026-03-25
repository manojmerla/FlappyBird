using UnityEngine;
using System.Collections.Generic;

public class PoollManager : MonoBehaviour
{
    [SerializeField] private GameObject Bulletperfab;
    [SerializeField]private int poolsize = 10;
    List<GameObject>pool = new List<GameObject>();
    void Start()
    {
        for(int i =0; i<poolsize;i++)
        {
            GameObject obj = Instantiate(Bulletperfab);
            obj. SetActive(false);
            pool.Add(obj);
        }
    }

     public GameObject getbullet()
    {
        foreach(GameObject obj in pool)
        {
            if(!obj.activeInHierarchy)
            return obj;
        }
        return null;
    }
}
