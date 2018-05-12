
using UnityEngine;

public class StarMove : MonoBehaviour
{

    public Rigidbody StarRb;

    public float starSpeed = 850f;

    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void FixedUpdate()
    {

        StarRb.AddForce(0, 0, -starSpeed * Time.deltaTime);


    }
}
