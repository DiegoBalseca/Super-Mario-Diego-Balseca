using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimerScript : MonoBehaviour
{
    // Variables
    
    public int numeroEntero = 5; // para numeros enteros
    
    private float numeroDecimal = 7.5f; // para numeros decimales

    bool boleana = true;

    string cadenaTexto = "Hola mundo";



    // Start is called before the first frame update
    void Start()
        
    {   
        Calculos();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Calculos()
    {
         Debug.Log(numeroEntero);
        numeroEntero = 17;
        Debug.Log(numeroEntero);

        numeroEntero = 7 + 5;

        numeroEntero++;

        numeroEntero += 2;
    }
}

    

