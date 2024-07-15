using UnityEngine;
using TMPro;
using System.Collections;

public class numIncrease : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public float animationDuration = 1.0f; // 애니메이션 지속 시간

    private int targetScore;

    void Start()
    {
        // 예시: 애니메이션을 테스트하기 위해 임시로 점수 설정
        SetScore(5000);
    }

    public void SetScore(int newScore)
    {
        targetScore = newScore;
        StartCoroutine(AnimateScore());
    }

    IEnumerator AnimateScore()
    {
        int currentScore = 0;
        float elapsedTime = 0f;

        while (elapsedTime < animationDuration)
        {
            elapsedTime += Time.deltaTime;
            float percentage = elapsedTime / animationDuration;
            currentScore = Mathf.RoundToInt(Mathf.Lerp(0, targetScore, percentage));
            scoreText.text = currentScore.ToString() + "G";
            yield return null;
        }

        // 애니메이션이 끝난 후 최종 점수 설정
        scoreText.text = targetScore.ToString() + "G";
    }
}
