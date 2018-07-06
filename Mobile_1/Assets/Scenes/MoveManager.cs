
using UnityEngine;
using UnityEngine.UI;

public class MoveManager : MonoBehaviour {
        
    // Transform 은 자기 개체의 컴포넌트이다.
    public Transform target = null;

    [SerializeField]
    private float moveSpeed = 50f;

	// Use this for initialization
	public void LeftMove () {
        target.position += new Vector3(-1, 0, 0) * moveSpeed;//* Time.deltaTime;
	}
	
	// Update is called once per frame
	public void RightMove () {
        target.position += new Vector3(1, 0, 0) * moveSpeed;// * Time.deltaTime;
	}
}
