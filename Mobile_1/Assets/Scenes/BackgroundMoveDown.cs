using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMoveDown : MonoBehaviour {

    public float moveSpeed = 5f;

    private void FixedUpdate()
    {
        // 화면만 움직임
        Vector3 velocity = new Vector3(0f, moveSpeed, 0f);
        transform.position -= velocity * Time.fixedDeltaTime;

        // 사라짐 체크 (y값만 체크)
        var rectTransform = GetComponent<RectTransform>();
        var topY = rectTransform.position.y + rectTransform.sizeDelta.y;
        var screenBottomY = 0f - FindObjectOfType<Canvas>().GetComponent<RectTransform>().sizeDelta.y / 2;
        Debug.Log(rectTransform.position.y);
        Debug.Log(rectTransform.sizeDelta.y);
        Debug.Log(topY);
        if(screenBottomY > topY)
        {
            Destroy(gameObject);
        }
    }
}
