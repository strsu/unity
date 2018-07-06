using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneJump : MonoBehaviour {

    public string str_nextScene = "";

    public Button btn_start = null;
    public Button btn_quit = null;

    private bool isJumping = false;

    private void Start()
    {
        // 객체를 탐색해서 가져오는 방법, 드래그를통한 캐싱이 더 낫다.
        // btn_start = GameObject.Find("BTN_Start").GetComponent<Button>();
        btn_start.onClick.AddListener(() => {
            if (!isJumping) {
                isJumping = true;
                SceneManager.LoadScene(str_nextScene);
            }
        });

        btn_quit.onClick.AddListener(() => {
            Application.Quit();
        });

    }
}
