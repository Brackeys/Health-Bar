using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public float speed = 2f;

	Vector3 move;

    // Update is called once per frame
    void Update()
    {
		move.x = Input.GetAxis("Horizontal");
		move.z = Input.GetAxis("Vertical");
    }

	void FixedUpdate()
	{
		transform.Translate(move * Time.fixedDeltaTime * speed);
	}
}
