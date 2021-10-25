using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class char2Controller : MonoBehaviour
{

    public float speed;
    void Update()
    {
        move();
    }
	
	private void move() {
		Vector3 movimiento = Vector3.zero;
		movimiento.x = (Input.GetAxis("Horizontal2") * speed * Time.deltaTime);
		movimiento.z = Vector3.forward.z *Input.GetAxis("Vertical2") * speed * Time.deltaTime;
		Debug.Log(movimiento);
		transform.Translate(movimiento);
		
	}
	
	
}
