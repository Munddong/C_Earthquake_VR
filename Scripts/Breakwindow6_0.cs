using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakwindow6_0 : MonoBehaviour
{
    public GameObject[] Windows = new GameObject[7];
    private int randomCount, i;
    private AudioSource audioSource;
    public AudioClip breakingSound;

    // Use this for initialization
    void Start()
    {
        audioSource = this.GetComponent<AudioSource>();
        i = 0;
        StartCoroutine(Broken());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Broken()
    {
        yield return new WaitForSeconds(5.0f);
        while (i < 7)
        {
            randomCount = Random.Range(5, 7);
            yield return new WaitForSeconds(randomCount);
            Windows[i].GetComponent<BreakableWindow>().enabled = true;
            audioSource.PlayOneShot(breakingSound);
            i++;
        }
    }
}
