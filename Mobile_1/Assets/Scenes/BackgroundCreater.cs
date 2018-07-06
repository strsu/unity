using UnityEngine.UI;
using UnityEngine;

public class BackgroundCreater : MonoBehaviour {

    private Vector3 dsfaultPosition = Vector3.zero;
    private Transform canvasTransform = null;
    public GameObject backgroundPref = null;

    private void Start()
    {
        // 초기화
        canvasTransform = FindObjectOfType<Canvas>().transform;

        // 첫 생성 위치값 설정
        dsfaultPosition = new Vector3(0f, -Screen.height / 2f, 0f);

        // prefab 생성 및 배치
        GameObject go = Instantiate(backgroundPref, canvasTransform);
        go.GetComponent<RectTransform>().position += dsfaultPosition;
        go.GetComponent<RectTransform>().SetAsFirstSibling();
    }
}
