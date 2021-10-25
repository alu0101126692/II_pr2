using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cilindroAlejar : MonoBehaviour
{
    
    public float cantidadAlejar;

    public void alejar(Vector3 direcion) {
		transform.Translate(direcion * Time.deltaTime * cantidadAlejar);

    }
}
