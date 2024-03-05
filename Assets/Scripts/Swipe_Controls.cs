using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe_Controls : MonoBehaviour
{
    public float laneWidth = 15f;


    public float moveSpeed = 5f;

    private int currentLane = 2;

    // Start is called before the first frame update
    void Start()
    {
       MoveToLane(currentLane);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow) && currentLane < 3 ){
            currentLane++;
            MoveToLane(currentLane);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) && currentLane > 0 ){
            currentLane--;
            MoveToLane(currentLane);
        }

        

    }

    void MoveToLane (int targetLane){
        float targetPositionX = (targetLane-1.5f) * laneWidth;
        transform.position= new Vector3(targetPositionX, transform.position.y, transform.position.z);
        

}}
