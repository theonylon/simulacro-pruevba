using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tp1 : MonoBehaviour
{
    public int num1;
    public int num2;
    // Start is called before the first frame update
    void Start()
    {
        if (num1 == num2)
        {
            Debug.Log("los dos valores son iguales");
        }

        else
        {
            Debug.Log(" los valores no son iguales ");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
