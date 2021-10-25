using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CharControllerFirst : MonoBehaviour
{	

	public float speed;
	public float rotationSpeed;
	private Vector3 movimiento;

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
		movimiento = Vector3.zero;
		movimiento.x = (Input.GetAxis("Horizontal") * speed * Time.deltaTime);
		movimiento.z = Vector3.forward.z *Input.GetAxis("Vertical") * speed * Time.deltaTime;
		
		transform.Translate(movimiento);
		
	}
	
	private void rotacion() {
		float direccion = 0;
		direccion = Input.GetAxis("Fire1") * rotationSpeed;
		
		transform.Rotate(0, direccion * Time.deltaTime, 0);
	}




}