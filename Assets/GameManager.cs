
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;


public class GameManager : MonoBehaviour {

    public float slowDown = 10f;
    public Text highScore;


    // Use this for gameover, gamewins, scores, restart and gameplay tweak.

    public void Start()
    {
        highScore.text = "HighScore: " + PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    public void EndGame()

    {
        
        StartCoroutine(RestartLevel());
    }

    IEnumerator RestartLevel()
    {
        
        //ObstacleMovement.obstacleSpeed = 4000;
        //StarMove.starSpeed = 3400;

        
            if (ScoreText.playerScore > PlayerPrefs.GetInt("HighScore", 0))

            {
                PlayerPrefs.SetInt("HighScore", ScoreText.playerScore);
                highScore.text = ScoreText.playerScore.ToString();
            }

        ScoreText.playerScore = 0;
        Time.timeScale = 1f / slowDown;
        Time.fixedDeltaTime = Time.fixedDeltaTime / slowDown;
        yield return new WaitForSecondsRealtime(3f / slowDown);
        Time.fixedDeltaTime = Time.fixedDeltaTime * slowDown;
        Time.timeScale = 1f;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    
}
