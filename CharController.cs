using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour
{	

	public float speed;
	public float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {	
        
    }

    // Update is called once per frame
    void Update()
    {
        move();
		rotacion();
    }
	
	private void move() {
		Vector3 movimiento = Vector3.zero;
		movimiento.x = (Input.GetAxis("Horizontal") * speed * Time.deltaTime);
		movimiento.z = Vector3.forward.z *Input.GetAxis("Vertical") * speed * Time.deltaTime;
		
		Debug.Log(movimiento);
		transform.Translate(movimiento);
		
	}
	
	private void rotacion() {
		float direccion = 0;
		if (Input.GetKey(KeyCode.Q)) {
			direccion = -1 * rotationSpeed;
		} else if (Input.GetKey(KeyCode.E)){
			direccion = 1 * rotationSpeed;
		}
		
		transform.Rotate(0, direccion * Time.deltaTime, 0);
	}
}
