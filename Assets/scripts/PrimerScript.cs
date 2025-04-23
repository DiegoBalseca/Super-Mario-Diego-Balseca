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

    private int [] numeros = {75,1,3};
    
    public int [] numeros2;

    private int[ , ] numeros3; = {{7, 8, 98},{9, 22, 45}, {74, 5, 6}};

    List<int> listaDeNumeros = new List<int> {3, 5, 8, 9, 88, 12};


    // Start is called before the first frame update
    void Start()
        
    {   
        foreach(int numeor in listaDeNumeros)
        {
            Debug.Log(numero);
        }

        listaDeNumeros.Add(22); //añadir un numero a la lista
        listaDeNumeros.Remove(); //borrar algun numero de la lista
        listaDeNumeros.RemoveAt(0); //para borrar el primer numero de la lista 
        listaDeNumeros.RemoveAt (listaDeNumeros.Count - 1); //para eliminar el utlimo numero de la lista
         // listaDeNumeros.Clear(); // deja limpia la lista para poder hacer una nueva
        listaDeNumeros.Sort(); //ordena la lista de mas pequeño a mas grande
        listaDeNumeros.Reverse(); //Ordenea de mayor a menor

        foreach(int numeor in listaDeNumeros)
        {
            Debug.Log(numero);
        }

      


        Debug.Log(numeros[0]);
        Debug.Log(numeros3[1,2]);
        
        Calculos();

        foreach(int numero in numeros)
        {
            Debug.Log(numero);
;       }

        for(int = 0; i > 0; i++)
        {
            Debug.log(numeros (i));
            
        }

        int = 1 = 0;

        while(i < numeros.Lenght)
        {
            Debug.Log(numeros [1]);
            i++;
        }

        do
        {
            Debut.Log("asfafs");
        }
        while (i < numeros.Lenght);
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

    

