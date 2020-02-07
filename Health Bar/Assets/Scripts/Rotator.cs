using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
	public float speed = 50f;

    // Update is called once per frame
    void Update()
    {
		transform.Rotate(0f, speed * Time.deltaTime, 0f);
    }
}
