using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //variaveis e tipos de dados
        int pontos = 10;
        float peso = 42.35f;
        double medida = 30.999999;
        bool ativada = true;//false
        string texto = "change da world, my final messange goodbye";

        Debug.Log("inteiro:" + pontos);
        Debug.Log("Float:" + peso);
        Debug.Log("Double:" + medida);
        Debug.Log("Booleana:" + ativada);
        Debug.Log("String:" + texto);

        //operadores aritimeticos
        int soma = 2 + 2;
        int subtracao = 10 - 2;
        int multiplicacao = 10 * 5;
        float divisao = 22f / 2f;
        int resto = 30 % 3;
       
        Debug.Log("Soma:" + soma);
        Debug.Log("Subtração:" + subtracao);
        Debug.Log("Multiplicação:" + multiplicacao);
        Debug.Log("Divisão:" + divisao);
        Debug.Log("Resto:" + resto);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
