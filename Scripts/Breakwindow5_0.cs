using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakwindow5_0 : MonoBehaviour
{
    public GameObject[] Windows = new GameObject[4];
    private int randomCount, i;
    private AudioSource audioSource;
    public AudioClip breakingSound;

    // Use this for initialization
    void Start()
    {
        audioSource = this.GetComponent<AudioSource>();
        i = 0;
        StartCoroutine(Break());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Break()
    {
        yield return new WaitForSeconds(5.0f);
        while (i < 4)
        {
            randomCount = Random.Range(5, 10);
            yield return new WaitForSeconds(randomCount);
            Windows[i].GetComponent<BreakableWindow>().enabled = true;
            audioSource.PlayOneShot(breakingSound);
            i++;
        }
    }
}
