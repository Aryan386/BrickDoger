
using UnityEngine;

public class ObstacleMovement : MonoBehaviour {

    public Rigidbody obstacleRb;

    public float obstacleSpeed = 1000f;
    
	// Use this for initialization
	void Start () {

       
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        obstacleRb.AddForce(0 , 0 , -obstacleSpeed * Time.deltaTime);

        
	}
}
