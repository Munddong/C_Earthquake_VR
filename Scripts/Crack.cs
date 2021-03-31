using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Crack : MonoBehaviour {
    public Image crackImage1;
    public Image crackImage2;
    public Image crackImage3;
    public Image crackImage4;
    private float gaugeTimer = 0.0f;
    private float gazeTime = 2.0f;
    private bool time = false;

    // Use this for initialization
    void Start ()
    {
        crackImage1.fillAmount = gaugeTimer;
        crackImage2.fillAmount = gaugeTimer;
        crackImage3.fillAmount = gaugeTimer;
        crackImage4.fillAmount = gaugeTimer;
        StartCoroutine(Cracking());

    }
	
	// Update is called once per frame
	void Update ()
    {
        if (time == true)
        {
            crackImage1.fillAmount += 1.0f / gazeTime * Time.deltaTime;
            crackImage2.fillAmount += 1.0f / 3.0f * Time.deltaTime;
            crackImage3.fillAmount += 1.0f / 3.0f * Time.deltaTime;
            crackImage4.fillAmount += 1.0f / 5.0f * Time.deltaTime;
        }
    }

    IEnumerator Cracking()
    {
        yield return new WaitForSeconds(4.5f);
        time = true;
    }
}
