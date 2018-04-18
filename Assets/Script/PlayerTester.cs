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

        if (Input.GetMouseButton(0))
        {
            Vector3 pos = gameObject.transform.position;

            pos.z += speed;

            gameObject.transform.position=pos;

        }
		
	}
}
