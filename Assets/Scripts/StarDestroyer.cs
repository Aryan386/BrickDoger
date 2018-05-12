
using UnityEngine;

public class StarDestroyer : MonoBehaviour {

    public StarMove starMove1;
    // Use this for initialization
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Star" || transform.position.z < -40)
        {
            starMove1.enabled = false;
            Destroy(gameObject);
            ScoreText.playerScore += 10;
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
