using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cuboTamanio : MonoBehaviour
{
void OnTriggerEnter(Collider col) {
		if (col.gameObject.tag == "Player") {
			transform.localScale -= new Vector3(0.2f, 0.2f, 0.2f);
		} 
    if (col.gameObject.tag == "Esfera") {
			transform.localScale += Vector3.one;
      Debug.Log("Disminuir tamaño");
    }
	}
}
