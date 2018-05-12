using UnityEngine;
using UnityEngine.UI;


public class ScoreText : MonoBehaviour {

    public static int playerScore = 0;
    Text scoreVar;

	// Use this for initialization
	void Start () {

        scoreVar = GetComponent<Text> ();
		
	}
	
	// Update is called once per frame
	void Update () {

        scoreVar.text = "Score : " + playerScore;
		
	}
}
