using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    public float timeAlive;
    // Start is called before the first frame update
    void Start()
    {
       // Invoke("SelfDestruct", timeAlive);
    }

    // Update is called once per frame
    void Update()
    {
         
    }

    private void SelfDestruct()
    {
        Destroy(gameObject);
    }
}
