using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMoving : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] int speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
            rb.velocity = new Vector3(-1f, 0, 0) * speed;
        if (Input.GetKey(KeyCode.RightArrow))
            rb.velocity = new Vector3(1f, 0, 0) * speed;
        if (Input.GetKey(KeyCode.UpArrow))
            rb.velocity = new Vector3(0, 0, 1f) * speed;
        if (Input.GetKey(KeyCode.DownArrow))
            rb.velocity = new Vector3(0, 0, -1f) * speed;
    }
}
