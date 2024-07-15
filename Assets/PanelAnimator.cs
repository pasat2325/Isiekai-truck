using UnityEngine;
using DG.Tweening;
using TMPro;
using System.Collections;

public class PanelAnimator : MonoBehaviour
{

    public RectTransform[] panelRectTransforms; // 패널 배열
    public TextMeshProUGUI[] textArray; // 텍스트 배열

    public float panelAnimationDuration = 1.0f; // 패널 애니메이션 지속 시간
    public float delayBetweenPanels = 0.5f; // 각 패널 사이의 지연 시간
    public float scoreAnimationDuration = 0.5f;
    public float dis = -2000; //슬라이드 거리

    public int targetscore = 1000; // 획득 점수 설정
    void Start()
    {
        StartCoroutine(ShowPanelsSequentially());
    }

    private IEnumerator ShowPanelsSequentially() //패널이 순서대로 날아오는 애니메이션
    {
        for (int i = 0; i < panelRectTransforms.Length; i++)
        {
            var panelRectTransform = panelRectTransforms[i];
            var scoreText = textArray[i];

            // 패널을 화면 밖으로 이동
            panelRectTransform.anchoredPosition = new Vector2(Screen.width, panelRectTransform.anchoredPosition.y);

            // 패널을 화면 안으로 슬라이드 인
            panelRectTransform.DOAnchorPosX(dis, panelAnimationDuration).SetEase(Ease.OutCubic);
            yield return new WaitForSeconds(panelAnimationDuration); // 패널 애니메이션 완료 후 지연

            // 점수 증가 애니메이션 시작
            if (scoreText != null)
            {
                StartCoroutine(AnimateScore(scoreText, targetscore, scoreAnimationDuration));
            }

            yield return new WaitForSeconds(scoreAnimationDuration + delayBetweenPanels); // 점수 증가 애니메이션 완료 후 지연
        }
    }
    private IEnumerator AnimateScore(TextMeshProUGUI scoreText, int targetScore, float duration)
    {
        int currentScore = 0;
        float elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            float percentage = elapsedTime / duration;
            currentScore = Mathf.RoundToInt(Mathf.Lerp(0, targetScore, percentage));
            scoreText.text = string.Format("{0,5}",currentScore.ToString())+"G";
            yield return null;
        }

        // 애니메이션이 끝난 후 최종 점수 설정
        scoreText.text = targetScore.ToString() + "G";
    }
}
