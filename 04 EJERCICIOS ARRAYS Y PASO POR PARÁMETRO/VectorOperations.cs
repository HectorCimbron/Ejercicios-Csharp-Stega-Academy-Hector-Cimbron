using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class VectorOperations : MonoBehaviour
{
    public int tupleNumber; // tupla de los vectores, común a ambos, a introducir por le usuarie
    private int[] firstVector;
    private int[] secondVector;
   
    
    // Start is called before the first frame update
    void Start()
    {
        firstVector =  FillRandomVector();
        secondVector = FillRandomVector();
      
        PrintVectorOp (VectorSum(firstVector, secondVector)); // métodos de Miguel Palencia, vistos en clase. No pude llegar a esta conclusión por mi mismo : (
        PrintVectorOp (VectorSub(firstVector, secondVector));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int[] FillRandomVector()
    {
        
        int[] arrayRandomVector = new int[tupleNumber];
        for (int i = 0; i < arrayRandomVector.Length; i++)
        {
            arrayRandomVector[i] = Random.Range(0, 100);
            Debug.Log(arrayRandomVector[i]); // muestra por consola datos de componentes vector
        }

        return arrayRandomVector;
    }
    
     int[] VectorSum(int[] firstVector, int[] secondVector)
     {
         int[] resultSum = new int [firstVector.Length];
         
         
        for (int i = 0; i < firstVector.Length; i++)
        {
            resultSum[i] = firstVector[i] + secondVector[i];

        }
        return resultSum;
     }

     int[] VectorSub(int[] firstVector, int[] secondVector)
     {
         int[] resultSub = new int [firstVector.Length];
         
         
         for (int i = 0; i < firstVector.Length; i++)
         {
             resultSub[i] = firstVector[i] - secondVector[i];

         }
         return resultSub;
     }

    
    private void PrintVectorOp(int[] number) // fusilado de Miguel P... gracias Miguel
    {
         
        string arrayString = " ";
        for (int i = 0; i < number.Length; i++)
        {
            arrayString += number[i] + " ";

        }
        Debug.Log(arrayString);
    }
}
