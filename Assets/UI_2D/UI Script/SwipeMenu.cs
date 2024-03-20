using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.AI;

public class SwipeMenu : MonoBehaviour
{
    private bool isMenuOpen = false;
    private Vector3 startPosition;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                startPosition = touch.position;
            }
            else if (touch.phase == TouchPhase.Moved)
            {
                if (Mathf.Abs(touch.position.x - startPosition.x) > 100)
                {
                    if (!isMenuOpen)
                    {
                        OpenMenu();
                    }
                    else 
                    {
                        CloseMenu();
                    }
                }
            }
        }
    }

    public void OpenMenu()
    {
        isMenuOpen = true;
        LeanTween.moveX(gameObject, -200f, 0.5f);
    }
    public void CloseMenu()
    {
        isMenuOpen = false;
        LeanTween.moveX(gameObject, 0f, 0.5f);
    }

}
