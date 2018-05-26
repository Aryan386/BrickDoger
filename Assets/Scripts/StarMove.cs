
using UnityEngine;

public class StarMove : MonoBehaviour
{

    public Rigidbody StarRb;

    public const float starSpeed = 3000f;
    public float chnageSpeed;
    public float finalSpeed;

    // Use this for initialization
    void Start()
    {
        chnageSpeed += Time.timeSinceLevelLoad / 20f;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        finalSpeed = starSpeed + chnageSpeed + ScoreText.playerScore;

        StarRb.AddForce(0, 0, -finalSpeed * Time.deltaTime);
        


    }
}
