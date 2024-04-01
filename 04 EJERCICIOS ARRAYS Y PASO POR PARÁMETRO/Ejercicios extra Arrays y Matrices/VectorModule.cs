using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorModule : MonoBehaviour
{
  
    
    [Header("Vectors")]
    [SerializeField] private int dimensionVector = 3;
    [SerializeField] private int[] vector1;
    // Start is called before the first frame update
    void Start()
    {
        vector1 = new int [dimensionVector];
        FillRandomArray(vector1); PrintArray(vector1);
        
        //primero hacer un for que vaya sacando el elevado al cuadrado de cada número
        //luego sumarlos 
        //luego un tercer método que sea el cálculo de la raíz cuadrada de la suma total y ese SÍ es el resultado a printear
        
        SumModule (VectorModulePow(vector1));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FillRandomArray(int[] arrayRef)
    {
        for (int i = 0; i < arrayRef.Length; i++)
        {
            arrayRef[i] = Random.Range(0, 100);

        }

    }
    void PrintArray(int[] numbers)
    {
        string arrayString = " ";
        for (int i = 0; i < numbers.Length; i++)
        {
            arrayString += numbers[i] + " ";

        }
        Debug.Log(arrayString);

    }

    int[] VectorModulePow(int[] vector1) //método que eleva al cuadrado los componentes del vector
    {

        int[] resultModulePow = new int [vector1.Length];
        for (int i = 0; i < vector1.Length; i++)
        {
            Mathf.Pow(vector1[i], 2f);
            Debug.Log(Mathf.Pow(vector1[i], 2f));

        }

        return resultModulePow;
        
        
        
    }
    
    private void SumModule(int[] resultModulePow)  //!!!!!ESTÁ FALLANDO ESTE MÉTODO. NO SUMA, SE QUEDA A 0. ALGO ESTÁ HACIENDO QUE SE MULTIPLIQUE POR CERO??
    {
        
        int sum = 0;
        for (int i = 0; i < resultModulePow.Length; i++)
        {
            sum += resultModulePow[i];
            Debug.Log("El resultado de la suma de los componentes del vector es: " + sum);

        }

        

    }
}
