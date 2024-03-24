using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{

    public int numberEntered;

    // Start is called before the first frame update
    void Start()
    {
       //Dejo comentados los métodos para activar o desactivar el que interese probar en cada momento

       //LoopFrom0To100WhithFor();
       //LoopFrom0To100WhithWhile();
       //LoopFrom100To0WhithFor();
       //LoopFrom100To0WhithWhile();
       //LoopFrom1ToEnteredNumberWithFor();
       //LoopFrom1ToEnteredNumberWithWhile();
       //LoopOddNumbersFrom0To100WithFor();
       //LoopOddNumbersFrom0To100WithWhile();
       //LoopEvenNumbersFrom0To100WithFor();
       //LoopEvenNumbersFrom0To100WithWhile();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LoopFrom0To100WhithFor()
    {

        for (int vueltas = 0; vueltas <= 100; vueltas++)
        {
            Debug.Log(vueltas);
        }
       
    }
    private void LoopFrom0To100WhithWhile()
    {

        int vueltas = 0;
        while (vueltas <= 100)
        {
            Debug.Log(vueltas);
            vueltas++;
        }
    }
    private void LoopFrom100To0WhithFor()
    {

        for (int vueltas = 100; vueltas >= 0; vueltas--)
        {
            Debug.Log(vueltas);
        }
    }
        private void LoopFrom100To0WhithWhile()
    {

        int vueltas = 100;
        while (vueltas > -1)
        {
            Debug.Log(vueltas);
            vueltas--;
        }
       
    }
    private void LoopFrom1ToEnteredNumberWithFor()
    {
        for (int vueltas = 1; vueltas <= numberEntered; vueltas++)
        {
            Debug.Log(vueltas);
        }
    }
    private void LoopFrom1ToEnteredNumberWithWhile()
    {
        int vueltas = 1;
        while (vueltas <= numberEntered)
        {
            Debug.Log(vueltas);
            vueltas++;
        }
    }

    private void LoopOddNumbersFrom0To100WithFor()
    {

        for (int vueltas = 0; vueltas <= 100; vueltas++)
        {

            bool IsNumberOdd = vueltas % 2 != 0; // los números impares siempre nos darán un resto distinto a 0 a la hora de dividirlos por 2
            if (IsNumberOdd) Debug.Log(vueltas);

        }

    }
    private void LoopOddNumbersFrom0To100WithWhile()
    {
        int vueltas = 0;

        while (vueltas <= 100)
        {
            bool IsNumberOdd = vueltas % 2 != 0;

            if (IsNumberOdd) Debug.Log(vueltas);

            vueltas++;
        }

    }
    private void LoopEvenNumbersFrom0To100WithFor()
    {
        
        for (int vueltas = 0; vueltas <= 100; vueltas++)
        {
            
            bool IsNumberEven = vueltas % 2 == 0; // // los números pares siempre nos darán un resto de 0 a la hora de dividirlos por 2
            if (IsNumberEven) Debug.Log(vueltas);

        }

    }
    private void LoopEvenNumbersFrom0To100WithWhile()
    {
        int vueltas = 0;
        
        while (vueltas <= 100)
        {
            bool IsNumberEven = vueltas % 2 == 0;

            if (IsNumberEven) Debug.Log(vueltas);

            vueltas++;
        }

    }

}
