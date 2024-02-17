using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal_Open : MonoBehaviour
{
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        //Invoke("AppearPortal", 1.5f);
        Invoke("DisappearPortal", 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void AppearPortal()
    {
        animator.SetBool("isOpen", true);

        Invoke("DisappearPortal", 5f);
    }

    private void DisappearPortal()
    {
        animator.SetBool("isClose", true);

        Invoke("DisableObject", 1.5f);
    }

    private void DisableObject()
    {
        Destroy(gameObject);
    }
}
