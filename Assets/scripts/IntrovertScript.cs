using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntrovertScript : MonoBehaviour {

    private int inPersSpace;
    private int inSocSpace;
    private bool isComfy;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("check1");
        inPersSpace++;
        inSocSpace++;
    }



   

    // Use this for initialization
    void Start () {
	
    }
	
	// Update is called once per frame
	void Update () {
		
    if (inPersSpace > 0 || inSocSpace > 1)
        {
            //Color.red;
            isComfy = false;
        }
    else if (inSocSpace > 1)
        {
            //Color.red;
            isComfy = false;
        }

	}
}
