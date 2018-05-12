using UnityEngine;

public class PlayerMovment : MonoBehaviour {

    public float sideSpeed = 500f;
    private Rigidbody PlayerRb;

    public float floorWidth = 7f;

	// Use this for initialization
	void Start () {
        PlayerRb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        float x = Input.GetAxis("Horizontal") * Time.deltaTime * sideSpeed;

        Vector3 newPosition = PlayerRb.position + Vector3.right * x;

        newPosition.x = Mathf.Clamp(newPosition.x, -floorWidth, floorWidth);

        PlayerRb.MovePosition(newPosition);

    }
}
