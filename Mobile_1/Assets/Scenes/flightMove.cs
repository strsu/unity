using UnityEngine;

public class flightMove : MonoBehaviour {

    private float moveSpeed = 10f;
    private Pad pad = null;

    private void Start() {
        pad = FindObjectOfType<Pad>();
    }

    private void FixedUpdate() {
        transform.Translate( pad.axis * pad.fPower * moveSpeed * Time.fixedDeltaTime );
    }
}
