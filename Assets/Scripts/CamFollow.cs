using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


public class CamFollow : MonoBehaviour
{
    public Transform playerTransform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Create a new Vector3 for the camera position
        Vector3 newPosition = new Vector3(transform.position.x, transform.position.y, playerTransform.position.z);

        // Set the camera's position to the new position
        transform.position = newPosition;
    }

}
