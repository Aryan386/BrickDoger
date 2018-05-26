
using UnityEngine;

public class ObstacleMovement : MonoBehaviour {

    public Rigidbody obstacleRb;

    public const float obstacleSpeed = 3000f;
	public float blockSpeed;
    public float speedRun;
    
	// Use this for initialization
	void Start () {

       speedRun += Time.timeSinceLevelLoad / 20f;
       
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		blockSpeed = obstacleSpeed + speedRun + ScoreText.playerScore;
		obstacleRb.AddForce(0, 0, -blockSpeed * Time.deltaTime);
        // obstacleRb.AddForce(0 , 0 , -obstacleSpeed +speedRun * Time.deltaTime);
       Debug.Log(blockSpeed);

        
	}
}
