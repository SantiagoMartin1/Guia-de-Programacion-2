using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioenClase : MonoBehaviour
{
    public int num1;
    public int num2;
    // Start is called before the first frame update
    void Start()
    {

        if (num1 != num2 && num1 > num2)
        {
            while (num1 >= num2)
            {
                Debug.Log(num1);
                num1--;
            }
        }

        else if(num1 < num2)
        {
            Debug.Log("Num 2 debe ser menor a Num1 ");
        }
        
        else if (num1 == num2)
        {
            Debug.Log("Ambos numeros no pueden ser iguales");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
