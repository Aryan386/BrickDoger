
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;



public class GameManager : MonoBehaviour {

    public float slowDown = 10f;
    
    
    // Use this for gameover, gamewins, scores, restart and gameplay tweak.

    public void EndGame()

    {
        StartCoroutine(RestartLevel());
    }

    IEnumerator RestartLevel()
    {
        Time.timeScale = 1f / slowDown;
        Time.fixedDeltaTime = Time.fixedDeltaTime / slowDown;

        yield return new WaitForSecondsRealtime(2f / slowDown);

        Time.timeScale = 1f;
        Time.fixedDeltaTime = Time.fixedDeltaTime * slowDown;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
}
