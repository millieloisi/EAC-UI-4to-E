using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ComidaDeAnimalitosUI : MonoBehaviour
{

    public TextMeshProUGUI txtResultado;
    public TMP_InputField inputCodigo;
    public TMP_InputField inputCantDias;
    string codigo;
    int cantDias;
    int comidaPerrosPeq = 400;
    int comidaPerrosGrandes = 700;
    int comidasGatos = 300;
    int comidaAnimalIndicado; 
  

    // Start is called before the first frame update
    void Start()
    {
        txtResultado.text = string.Empty;
    }

    // Update is called once per frame
    public void CalcularComida()
    {
        if (inputCantDias.text == string.Empty)
        {
            txtResultado.text = "Debe ingresar cantidad de dias";
            return;
        }

        if (inputCantDias.text == string.Empty)
        {
            txtResultado.text = "Debe ingresar un codigo";
            return;
        }

        codigo = inputCodigo.text;
        cantDias = int.Parse(inputCantDias.text);

        if (cantDias < 3)
        {
            txtResultado.text = "La cantidad no puede ser menor a 3";
            return;
        }



        if (codigo == "G")
        {
            txtResultado.text = "La cantidad de gramos necesitados es " + 

        }

        else if (codigo == "PP")
        {
        }


        else if (codigo == "PG")
        {

        }

        else
        {
            txtResultado.text = "Valor no valido";
            return;
        }


    }
}
