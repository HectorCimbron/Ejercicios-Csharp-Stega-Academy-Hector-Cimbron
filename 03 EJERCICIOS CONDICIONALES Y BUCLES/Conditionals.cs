using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals : MonoBehaviour
{

    public int numberEntered;
    public int secondNumberEntered;
    public char letterEntered;
    // Start is called before the first frame update
    void Start()
    {
        PositiveOrNegative();
        OddOrEven();
        AscendingCount();
        VowelOrNot();
        WhatDayOfTheWeek();
        WhatMonth();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void PositiveOrNegative()
    {
        if (numberEntered >= 0) Debug.Log("el número " + numberEntered + " es positivo");

        else Debug.Log("el número " + numberEntered + " es negativo");
        

    }
    private void OddOrEven()
    {
        bool IsEvenNumber  = numberEntered % 2 == 0;
        
        if (IsEvenNumber) Debug.Log("el número " + numberEntered + " es par");

        else Debug.Log("el número " + numberEntered + " es impar");
    }

    private void AscendingCount()
    {
        if (numberEntered > secondNumberEntered)
        {
            Debug.Log(secondNumberEntered);
            Debug.Log(numberEntered);
        }
        else
        {
            Debug.Log(numberEntered);
            Debug.Log(secondNumberEntered);
        }

    }
    private void VowelOrNot() 
        
        // DUDA: ¿Cómo se podría hacer que sólo fuese posible introducir una letra sin poner de excepción TODO el resto de caracteres?
    {
        switch (letterEntered)
        {

            case 'a':
                Debug.Log(letterEntered + " es una vocal");
                break;

            case 'e':
                Debug.Log(letterEntered + " es una vocal");
                break;

            case 'i':
                Debug.Log(letterEntered + " es una vocal");
                break;

            case 'o':
                Debug.Log(letterEntered + " es una vocal");
                break;

            case 'u':
                Debug.Log(letterEntered + " es una vocal");
                break;

            case 'A':
                Debug.Log(letterEntered + " es una vocal");
                break;

            case 'E':
                Debug.Log(letterEntered + " es una vocal");
                break;

            case 'I':
                Debug.Log(letterEntered + " es una vocal");
                break;

            case 'O':
                Debug.Log(letterEntered + " es una vocal");
                break;

            case 'U':
                Debug.Log(letterEntered + " es una vocal");
                break;

            default:
                Debug.Log(letterEntered + " no es una vocal");
                break;
        }
       
     }

    private void WhatDayOfTheWeek()
    {
        switch (numberEntered)
        {

            case 1:
                Debug.Log("Es lunes");
                break;

            case 2:
                Debug.Log("Es martes");
                break;

            case 3:
                Debug.Log("Es miércoles");
                break;

            case 4:
                Debug.Log("Es jueves");
                break;

            case 5:
                Debug.Log("Es viernes");
                break;

            case 6:
                Debug.Log("Es sábado");
                break;

            case 7:
                Debug.Log("Es domingo");
                break;

            default:
                Debug.Log("Introduce un número entre 1 y 7");
                break;
        }

    }


    private void WhatMonth()
    {
        switch (numberEntered)
        {

            case 1:
                Debug.Log("Es enero");
                break;

            case 2:
                Debug.Log("Es febrero");
                break;

            case 3:
                Debug.Log("Es marzo");
                break;

            case 4:
                Debug.Log("Es abril");
                break;

            case 5:
                Debug.Log("Es mayo");
                break;

            case 6:
                Debug.Log("Es junio");
                break;

            case 7:
                Debug.Log("Es julio");
                break;

            case 8:
                Debug.Log("Es agosto");
                break;

            case 9:
                Debug.Log("Es septiembre");
                break;

            case 10:
                Debug.Log("Es octubre");
                break;

            case 11:
                Debug.Log("Es noviembre");
                break;

            case 12:
                Debug.Log("Es diciembre");
                break;
                
            default:
                Debug.Log("Introduce un número entre 1 y 12");
                break;
        }

    }
}
