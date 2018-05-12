using UnityEngine;

public class BlockDestroyer : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
		if(transform.position.y < 0)
        {
            Destroy(gameObject);
        }
	}
}
