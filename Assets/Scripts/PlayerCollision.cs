using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovment movment;

    void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "Obstacles" )
        {
            movment.enabled = false;

            FindObjectOfType<GameManager>().EndGame();
        }
    }   

}
