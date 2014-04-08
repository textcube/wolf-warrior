using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

	void Start () {
	
	}

    public void RotateLeft()
    {
        transform.localRotation = Quaternion.Slerp(transform.localRotation, transform.localRotation * Quaternion.Euler(0f, 10f, 0f), 4f * Time.deltaTime);
    }	

    void Update () {
        RotateLeft();
	}
}
