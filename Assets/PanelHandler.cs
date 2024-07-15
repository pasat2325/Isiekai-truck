using UnityEngine;
using DG.Tweening;

public class PanelHandler : MonoBehaviour
{
    public RectTransform panel; // 패널 RectTransform
    public float duration = 1f; // 애니메이션 지속 시간

    [SerializeField]
    public float dis = 200;

    void Start()
    {
        // 패널의 초기 위치를 화면 오른쪽 밖으로 설정
        panel.anchoredPosition = new Vector2(Screen.width, panel.anchoredPosition.y);
        
        // 패널이 오른쪽에서 튀어나오는 애니메이션 실행
        SlideIn();
    }

    public void SlideIn()
    {
        // 패널을 오른쪽에서 부드럽게 슬라이드 인
        panel.DOAnchorPosX(dis, duration).SetEase(Ease.OutCubic);
    }
}
