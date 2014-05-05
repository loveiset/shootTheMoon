using UnityEngine;
using System.Collections;

public class Hero : MonoBehaviour {
    //float lastX;
    //bool isMoving = false;
    public GameObject explosion;
    public GameObject bullet;
    public AudioClip pew;



	// Use this for initialization
	void Start () 
    {

	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 trans = transform.position;
        transform.position = new Vector3((Input.mousePosition.x) / 20, trans.y, trans.z);
        if (Input.GetMouseButtonDown(0))
        {
            audio.PlayOneShot(pew);
            Instantiate(bullet, trans + new Vector3(0, 3, 0), Quaternion.identity);
        }
	}

    //void OnCollisionEnter(Collision other)
    //{
    //    Vector3 trans = other.gameObject.transform.position;
    //    if (other.gameObject.tag == "bomb")
    //    {
    //        Instantiate(explosion, trans, Quaternion.identity);
    //    }

    //    if (other.gameObject.GetComponent<Enemy>())
    //    {
    //        other.gameObject.GetComponent<Enemy>().ResetPosition();
    //    }
    //}


}
