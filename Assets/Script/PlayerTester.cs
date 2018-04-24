using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTester : MonoBehaviour {

    [SerializeField]
    private float speed;

    [SerializeField]
    private Vector3[] _positions;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        TouchInfo info = AppUtil.GetTouch();
        _positions = AppUtil.GetTouchPosition();
        if (info != TouchInfo.None)
        {
            // タッチ開始
            Vector3 pos = gameObject.transform.position;

            pos.z += speed;

            gameObject.transform.position = pos;
        }
   
		
	}
}
