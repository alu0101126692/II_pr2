using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CharController : MonoBehaviour
{	

	public float speed;
	public float rotationSpeed;
	public int puntuacion = 0;
	private Vector3 movimiento;
	public Text texto;

    // Start is called before the first frame update
    void Start()
    {	
        texto.text = "Puntuacion: " + puntuacion;
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



	// Colisiones y colliders del jugador
	void OnCollisionEnter(Collision col) {
        if (col.gameObject.tag == "Cilindro1") {
            
						col.gameObject.transform.localScale += Vector3.one;
						puntuacion += 1;

        		texto.text = "Puntuacion: " + puntuacion;

				} 
    }


	void OnTriggerStay(Collider col) {
		Vector3 direccion = (col.gameObject.transform.position - transform.position).normalized;
		direccion.y = 0;
		if (col.gameObject.tag == "Cilindro2") {
			col.gameObject.GetComponent<cilindroAlejar>().alejar(direccion);
		}


		if (col.gameObject.tag == "CilindroA" && Input.GetAxis("Espacio") > 0) {
			col.gameObject.GetComponent<cilindroAlejar>().alejar(direccion);
		}
	}

}