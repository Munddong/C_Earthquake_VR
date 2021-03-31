using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthQuake_Sound : MonoBehaviour
{
    private AudioSource audioSource; // 카세트

	// Use this for initialization
	void Start ()
    {
        audioSource = this.GetComponent<AudioSource>();
        audioSource.Play();
    }
	
	// Update is called once per frame
	void Update ()
    {

    }
}
