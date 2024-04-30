using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatrixOperations : MonoBehaviour
{
    [Header("Array2D")]
    [SerializeField]  private int array2Ddim1;
    [SerializeField]  private int array2Ddim2;
    [SerializeField]  private int[,] multiDimensionalArray2D1;
    [SerializeField]  private int[,] multiDimensionalArray2D2;
    
    
    [Header("Array3D")]
    public int array3Ddim1;
    public int array3Ddim2;
    public int array3Ddim3;
    [SerializeField]  private int[,,] multiDimensionalArray3D1;
    [SerializeField]  private int[,,] multiDimensionalArray3D2;
    
  
    
    // Start is called before the first frame update
    void Start()
    {
        int[,] multiDimensionalArray2D1 = FillMatrix();
        int[,] multiDimensionalArray2D2 = FillMatrix();
        PrintMatrixOp(MatrixSum(multiDimensionalArray2D1, multiDimensionalArray2D2)); // suma de las dos matrices (array 2D)
        PrintMatrixOp(MatrixSub(multiDimensionalArray2D1, multiDimensionalArray2D2)); // resta de las dos matrices (array 2D)
        // int[,,] multiDimensionalArray3D1 = Fill3DMatrix();
        // int[,,] multiDimensionalArray3D2 = Fill3DMatrix();
        // Print3DMatrixOp(Matrix3DSum(multiDimensionalArray3D1, multiDimensionalArray3D2)); // suma de las dos matrices 3D
        // Print3DMatrixOp(Matrix3DSub(multiDimensionalArray3D1, multiDimensionalArray3D2)); // resta de las dos matrices 3D
        
        
    }

    // Update is called once per frame
    void Update()
    {
    
        
    }

    int[,] FillMatrix()
    {
        
        int[,] randomMultiDimArray = new int [array2Ddim1, array2Ddim2];
        for (int i = 0; i < randomMultiDimArray.GetLength(0); i++)
        {
            for (int j = 0; j < randomMultiDimArray.GetLength(1); j++)
            {
                randomMultiDimArray[i,j] = Random.Range(0, 100);
                Debug.Log(randomMultiDimArray[i,j]); // muestra por consola todos los valores de las matrices, por separado
            }
            

        }

        return randomMultiDimArray;
    }
    int[,,] Fill3DMatrix()
    {
        
        int[,,] randomMultiDimArray = new int [array3Ddim1, array3Ddim2, array3Ddim3];
        for (int i = 0; i < randomMultiDimArray.GetLength(0); i++)
        {
            for (int j = 0; j < randomMultiDimArray.GetLength(1); j++)
            {
                for (int k = 0; k < randomMultiDimArray.GetLength(2); k++)
                {
                    randomMultiDimArray[i, j, k] = Random.Range(0, 100);
                    Debug.Log(randomMultiDimArray[i, j,k]); // muestra por consola todos los valores de las matrices, por separado
                }
            }


        }

        return randomMultiDimArray;
    }
    
    int[,] MatrixSum(int[,] firstMatrix, int[,] secondMatrix)
    {
        int[,] resultSum = new int [array2Ddim1, array2Ddim2];
        
        for (int i = 0; i < firstMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < firstMatrix.GetLength(1); j++)

            {
                
                resultSum[i,j] = firstMatrix[i,j] + secondMatrix[i,j];

            }
           
        }

        return resultSum;
        
    }
    int[,] MatrixSub(int[,] firstMatrix, int[,] secondMatrix)
    {
        int[,] resultSum = new int [array2Ddim1, array2Ddim2];
        
        for (int i = 0; i < firstMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < firstMatrix.GetLength(1); j++)

            {
                
                resultSum[i,j] = firstMatrix[i,j] - secondMatrix[i,j];

            }
           
        }

        return resultSum;
        
    }
    private void PrintMatrixOp(int[,] number)
    {

        string arrayString = " ";
        for (int i = 0; i < number.GetLength(0); i++)
        {
            for (int j = 0; j < number.GetLength(1); j++)
            {
                arrayString += number[i,j] + " ";
                
                
            }
        }
        Debug.Log(arrayString);
    }
    
    int[,,] Matrix3DSum(int[,,] firstMatrix, int[,,] secondMatrix)
    {
        int[,,] resultSum = new int [array3Ddim1, array3Ddim2, array3Ddim3];
        
        for (int i = 0; i < firstMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < firstMatrix.GetLength(1); j++)

            {
                for (int k = 0; k < firstMatrix.GetLength(2); k++)
                {

                    resultSum[i,j,k] = firstMatrix[i, j, k] + secondMatrix[i, j, k];

                }
            }

        }

        return resultSum;
        
    }
    int[,,] Matrix3DSub(int[,,] firstMatrix, int[,,] secondMatrix)
    {
        int[,,] resultSum = new int [array3Ddim1, array3Ddim2, array3Ddim3];
        
        for (int i = 0; i < firstMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < firstMatrix.GetLength(1); j++)

            {
                for (int k = 0; k < firstMatrix.GetLength(2); k++)
                {

                    resultSum[i, j, k] = firstMatrix[i, j, k] - secondMatrix[i, j, k];
                }

            }
           
        }

        return resultSum;
        
    }
    private void Print3DMatrixOp(int[,,] number)
    {

        string arrayString = " ";
        for (int i = 0; i < number.GetLength(0); i++)
        {
            for (int j = 0; j < number.GetLength(1); j++)
            {
                for (int k = 0;k < number.GetLength(2); k++)
                {
                    arrayString += number[i, j, k] + " ";

                }
            }
        }
        Debug.Log(arrayString);
    }
}
