using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Count : MonoBehaviour
{
   public Text numberText; // UI에 표시될 텍스트
    public int targetNumber = 100; // 목표 숫자
    public float startingSpeed = 1f; // 초기 상승 속도
    public float accelerationRate = 0.1f; // 가속도

    private int currentNumber = 0; // 현재 숫자
    private float incrementSpeed; // 상승 속도

    void Start()
    {
        incrementSpeed = startingSpeed;
    }

    void Update()
    {
        if (currentNumber < targetNumber)
        {
            // 일정 시간마다 현재 숫자를 증가시킴
            currentNumber++;
            UpdateNumberText();
            incrementSpeed += accelerationRate;
        }
    }
    void UpdateNumberText()
    {
        numberText.text = currentNumber.ToString();
    }
}
