using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSound : MonoBehaviour {


    public AudioClip sound;

    int blockSound;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}



    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if(collision.gameObject.tag == "groundTag")
        {
            AudioSource.PlayClipAtPoint(sound, transform.position);

        }else if (collision.gameObject.tag == "cubeTag")
        {
            AudioSource.PlayClipAtPoint(sound, transform.position);
        }

    }

}
