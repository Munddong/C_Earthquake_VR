using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {
    public GameObject tree1;
    public GameObject tree2;
    public GameObject bus;
    public GameObject cameraAngle;
    public GameObject mainCamera;
    public GameObject smoke;
    public GameObject etc;
    public GameObject narrationbox1;

    // Use this for initialization
    void Start ()
    {
        StartCoroutine(treeMove());
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    IEnumerator treeMove()
    {
        yield return new WaitForSeconds(23.0f);
        etc.SetActive(false);
        //cameraMove.transform.position = new Vector3(-3.41f, -0.55f, -26.64f);
        cameraAngle.SetActive(true);
        narrationbox1.SetActive(true);
        mainCamera.SetActive(false);
        yield return new WaitForSeconds(5.0f);
        narrationbox1.SetActive(false);
        //tree1.transform.rotation = Quaternion.Euler(-0.6711f, 1.080029e-09f, 18.89541f);
        StartCoroutine(objectRotate(tree1, Quaternion.Euler(-0.6711f, 1.080029e-09f, 18.89541f)));
        smoke.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        StartCoroutine(objectRotate(bus, Quaternion.Euler(21.22481f, 141.9539f, 4.579509e-07f)));
        //tree2.transform.rotation = Quaternion.Euler(-21.5f, 0f, 0f);
        StartCoroutine(objectRotate(tree2, Quaternion.Euler(-21.5f, 0f, 0f)));
        yield return new WaitForSeconds(7.0f);
        cameraAngle.SetActive(false);
        mainCamera.SetActive(true);
        etc.SetActive(true);
        smoke.SetActive(false);
    }

    IEnumerator objectRotate(GameObject move, Quaternion dir)
    {
        while (true)
        {
            move.transform.rotation = Quaternion.Lerp(move.transform.rotation, dir, 1.0f * Time.deltaTime);
            yield return null;
        }
        yield return null;
    }
}
