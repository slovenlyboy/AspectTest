using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTester : MonoBehaviour {

    [SerializeField]
    private float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        TouchInfo info = AppUtil.GetTouch();
        if (info == TouchInfo.Moved)
        {
            // タッチ開始
            Vector3 pos = gameObject.transform.position;

            pos.z += speed;

            gameObject.transform.position = pos;
        }
   
		
	}
}
