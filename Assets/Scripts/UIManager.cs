using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TMP_InputField inputNumero;
    public TextMeshProUGUI outputNumero;
    public int numCalculo;
    public TextMeshProUGUI advertenciaCartel;
    public int tempNum;


    void Start()
    {
        advertenciaCartel.gameObject.SetActive(false);
        outputNumero.gameObject.SetActive(false);
        tempNum = 0;
    }

    public void RestarUno() 
    {
        if (tempNum < 1) {
            numCalculo = int.Parse(inputNumero.text);
        }
        if (numCalculo > 0) 
        {
            tempNum = tempNum + 1;
            advertenciaCartel.gameObject.SetActive(false);
            outputNumero.gameObject.SetActive(true);

            numCalculo = numCalculo - 1;
            
            outputNumero.text = numCalculo.ToString();
        }
        else 
        {
            advertenciaCartel.gameObject.SetActive(true);
        }
        if ((numCalculo + tempNum) != int.Parse(inputNumero.text)) {
            numCalculo = 0;
            tempNum = 0;
        }
        Debug.Log(numCalculo + tempNum);
    }
}