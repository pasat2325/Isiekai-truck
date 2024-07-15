using UnityEngine;
using TMPro;
using System.Collections;

public class ScoreAnimator : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    private int targetScore;
    
    public int gainedscore = 50000;
    void Start()
    {
        // 예시: 시작 시점에 기본 점수를 설정
        SetScore(2000);
    }

    public void SetScore(int newScore)
    {
        targetScore = newScore;
    }

    public void StartScoreAnimation(float animationDuration)
    {
        StartCoroutine(AnimateScore(animationDuration));
    }

    private IEnumerator AnimateScore(float animationDuration)
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
