using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Pad : MonoBehaviour {

    private RectTransform stick = null;

    private float radius = 0f;
    private Vector3 stickOrigin = Vector3.zero;

    public Vector3 axis = Vector3.zero;
    public float fPower = 0f;

    private void Start() {
        stick            = transform.Find("Stick").GetComponent<RectTransform>();
        radius         = (GetComponent<RectTransform>().sizeDelta.x / 2f) * FindObjectOfType<Canvas>().transform.localScale.x;
        stickOrigin  = stick.position;
    }

    public void DragTouch(BaseEventData BED) {
        // 객체 이동 세기
        PointerEventData     PED            = (PointerEventData)BED;
        Vector3                     pTemp       = PED.position;
        float                          fDistance   = Vector3.Distance(pTemp, stickOrigin); // 스칼라

        // 객체의 방향
        axis = (pTemp - stickOrigin).normalized;    // 벡터의 스칼라를 1로 설정

        fPower = Mathf.Clamp(fDistance / radius, 0f, 1f);   // 스칼라

        // stick이 pad를 벗어나지 못하게 처리

        if(fDistance > radius) {
            stick.position = stickOrigin + axis * radius;
        } else {
            stick.position = pTemp;
        }

    }

    public void EndTouch(BaseEventData BED) {
        stick.position = stickOrigin;
        axis = Vector3.zero;
        fPower = 0f;
    }

}
