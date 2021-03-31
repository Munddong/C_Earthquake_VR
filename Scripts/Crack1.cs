using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Crack1 : MonoBehaviour {
    public Image realcrackImage;
    private float gaugeTimer = 0.0f;
    private float gazeTime = 2.0f;
    private bool time = false;

    // Use this for initialization
    void Start ()
    {
        realcrackImage.fillAmount = gaugeTimer;
        StartCoroutine(RealCracking());

    }
	
	// Update is called once per frame
	void Update ()
    {
        if (time == true)
        {
            realcrackImage.fillAmount += 1.0f / 5.0f * Time.deltaTime;
        }
    }

    IEnumerator RealCracking()
    {
        yield return new WaitForSeconds(28.0f);
        time = true;
    }
}
