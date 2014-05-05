using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
    public GameObject prefab;
    public int speed;
    public AudioClip[] clips;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        Vector3 trans = transform.position;
        transform.position = new Vector3(trans.x, trans.y - speed * Time.deltaTime, trans.z);
        transform.Rotate(0, 0, Time.deltaTime * -500);
        if (trans.y < -4)
        {
            ResetPosition();
        }
	}

    public void ResetPosition()
    {
        transform.position = new Vector3(Random.Range(-11, 68), 71, 0);
        rigidbody.velocity = Vector3.zero;
    }

    public void Explode(Vector3 pos)
    {
        audio.PlayOneShot(clips[Random.Range(0, clips.Length)]);
        Instantiate(prefab, pos, Quaternion.identity);
    }

    public void OnCollisionEnter(Collision other)
    {
        Explode(other.collider.gameObject.transform.position);
        ResetPosition();
        if (other.collider.tag.CompareTo("bullet") == 0)
        {
            Destroy(other.gameObject);
        }
        else if (other.collider.tag.CompareTo("hero") == 0)
        {

        }
    }
}
