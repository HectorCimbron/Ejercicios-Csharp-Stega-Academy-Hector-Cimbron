using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayTenNumbers : MonoBehaviour
{
    public int firstN, secondN, thirdN, fourthN, fifthN, sixthN, seventhN, eighthN, ninthN, tenthN;
    
    
    // Start is called before the first frame update
    void Start()
    {
        // Comento los métodos para activar o desactivar el que interese a la hora de probarlos desde el Start

        //PositiveNumbers(); // muestra los números positivos introducidos por le usuarie
        //NegativeNumbers(); // muestra los números negativos introducidos por le usuarie
        
        //RandomPositiveNumbers(); // Crea 10 números y muestra los positivos
        //RandomNegativeNumbers(); // Crea 10 números y muestra los negativos
        RandomPositiveAndNegativeNumbers(); // Crea 10 números y muestra los positivos y negativos
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void PositiveNumbers()
    {
        int[] arrayTenNumbers = { firstN, secondN, thirdN, fourthN, fifthN, sixthN, seventhN, eighthN, ninthN, tenthN };

        for (int i = 0; i < arrayTenNumbers.Length; i++)
        {
            if (arrayTenNumbers[i] > 0)
            {
                Debug.Log("Número positivo: " + arrayTenNumbers[i]);
            }

        }

    }

    private void NegativeNumbers()
    {
        int[] arrayTenNumbers = { firstN, secondN, thirdN, fourthN, fifthN, sixthN, seventhN, eighthN, ninthN, tenthN };
        
        for (int i = 0; i < arrayTenNumbers.Length; i++)
        {
            if (arrayTenNumbers[i] < 0)
            {
                Debug.Log("Número negativo: " + arrayTenNumbers[i]);
            }

        }
    }

    private void RandomPositiveNumbers()
    {

        int[] arrayRandomNum = new int[10];
        for (int i = 0; i < arrayRandomNum.Length; i++)
        {
            arrayRandomNum[i] = Random.Range(-10000, 10000);
        }

        for (int i = 0; i < arrayRandomNum.Length; i++)
        {
            if (arrayRandomNum [i] > 0)
            {
                Debug.Log("Número positivo: " + arrayRandomNum[i]);
            }

        }

    }
    private void  RandomNegativeNumbers()
    {
          int[] arrayRandomNum = new int[10];
        for (int i = 0; i < arrayRandomNum.Length; i++)
        {
            arrayRandomNum[i] = Random.Range(-10000, 10000);
        }

        for (int i = 0; i < arrayRandomNum.Length; i++)
        {
            if (arrayRandomNum [i] < 0)
            {
                Debug.Log("Número negativo: " + arrayRandomNum[i]);
            }

        }
        
    }

    private void RandomPositiveAndNegativeNumbers()
    {
        int[] arrayRandomNum = new int[10];
        for (int i = 0; i < arrayRandomNum.Length; i++)
        {
            arrayRandomNum[i] = Random.Range(-10000, 10000); // rango de -10000 a 10000, por poner algo
            Debug.Log(arrayRandomNum[i]); //lista indiscriminada de números creados
        }

        for (int i = 0; i < arrayRandomNum.Length; i++)
        {
            if (arrayRandomNum [i] < 0)
            {
                Debug.Log("Número negativo: " + arrayRandomNum[i]);
            }
            else if (arrayRandomNum [i] > 0)
            {
                Debug.Log("Número positivo: " + arrayRandomNum[i]);
            }

        }
        
    }

}
