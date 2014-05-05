using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	// Use this for initialization
	void Start () 
    {
        Vector3 temp = rigidbody.velocity;
        temp.y = 100;
        rigidbody.velocity = temp;
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (transform.position.y > 62)
        {
            Destroy(gameObject);
        }
	}
}
