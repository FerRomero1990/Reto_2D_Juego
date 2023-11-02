using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        //Debug.Log("Movimiento personaje");
        if (col.gameObject.CompareTag("Player"))
        {
            col.gameObject.GetComponent<MovimientoPersonaje>().posicionInicio = transform.position;
            print("Colisono");
            
        }
            
    }
}
