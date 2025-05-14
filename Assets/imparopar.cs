using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class imparopar : MonoBehaviour
{
    public int num1;
    public TMP_InputField numero;
    public TextMeshProUGUI textResultado;
    
    // Start is called before the first frame update
    void Start()
    {
        textResultado.text = "";


    }

    public void EsParOimpar()
    {
        if (numero.text == "") 
        {
            textResultado.text = "El campo esta vacio";
            return;
        }
        num1 = int.Parse(numero.text);

        if (num1 <= 0)
        {
            textResultado.text = "El nomero debe ser mayor que 0";
            return;
        }

        if (num1 % 2 == 0)
        {
            textResultado.text = "El numero es par";
            
        }

        else
        {
            textResultado.text = "El numero es impar";
            
        }
    }
   

}
