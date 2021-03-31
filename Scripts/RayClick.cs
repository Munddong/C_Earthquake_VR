using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RayClick : MonoBehaviour
{
    public Image cursorGauge;
    private float gaugeTimer = 0.0f;
    private float gazeTime = 2.0f;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        RaycastHit hit;
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 1000;
        cursorGauge.fillAmount = gaugeTimer;
        //Debug.DrawRay(Camera.main.transform.position, Camera.main.transform.forward, Color.red, 10000, false);
        Debug.DrawRay(transform.position, forward, Color.green);

        if (Physics.Raycast(transform.position, forward, out hit))
        {
            if (hit.transform.tag.Equals("Strength")) // == 보다 Equals가 계산량이 빠름
            {
                gaugeTimer += 1.0f / gazeTime * Time.deltaTime;

                if (gaugeTimer >= 1.0f && hit.transform.name.Equals("EarthQuake_low"))
                {
                    hit.transform.GetComponent<Button>().onClick.Invoke();
                    Debug.Log("hit");
                    gaugeTimer = 0.0f;
                    SceneManager.LoadScene("4_0EarthQuake");
                }

                else if (gaugeTimer >= 1.0f && hit.transform.name.Equals("EarthQuake_middle"))
                {
                    hit.transform.GetComponent<Button>().onClick.Invoke();
                    Debug.Log("hit");
                    gaugeTimer = 0.0f;
                    SceneManager.LoadScene("5_0EarthQuake");
                }

                else if (gaugeTimer >= 1.0f && hit.transform.name.Equals("EarthQuake_high"))
                {
                    hit.transform.GetComponent<Button>().onClick.Invoke();
                    Debug.Log("hit");
                    gaugeTimer = 0.0f;
                    SceneManager.LoadScene("6_0EarthQuake");
                }

                else if (gaugeTimer >= 1.0f && hit.transform.name.Equals("EarthQuake_Quit"))
                {
                    hit.transform.GetComponent<Button>().onClick.Invoke();
                    gaugeTimer = 0.0f;
                    SceneManager.LoadScene("Re_Celect_DongJin_EarthQuake");
                }

                else if (gaugeTimer >= 1.0f && hit.transform.name.Equals("Application_Quit"))
                {
                    hit.transform.GetComponent<Button>().onClick.Invoke();
                    Application.Quit();
                    Debug.Log("Application_Quit");
                }
            }

            else
            {
                gaugeTimer = 0.0f;
            }
        }
	}
}
