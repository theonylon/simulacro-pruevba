using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tp2 : MonoBehaviour
{
    public float precio1;
    public float precio2;
    public float precio3;
    public float monto;
    
    // Start is called before the first frame update
    void Start()
    {
      float suma = precio1 + precio2 + precio3;

        if (suma > monto)
        {
            Debug.Log("el monto es menor al precio de los tres productos");
        }
        else if (suma == monto)
        {
            Debug.Log("el monto es igual a el precio de los tres productos");
        }

        else
        {
            Debug.Log(" el monto es mayor al precio de los tres productos");
        }

       float resto = monto - suma;

        if (resto < 0)
        {
            Debug.Log("no a sobrado dinero ");
        }

        else
        {
            Debug.Log(" sobraron " + resto + "pesos ");
        } 


        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
