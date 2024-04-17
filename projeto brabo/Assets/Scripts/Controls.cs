using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controls : MonoBehaviour
{
    // Start is called before the first frame update

    private Rigidbody2D rb;
    public float velocidade = 5f;
    public float staminaInicial = 100f;
    public float taxaDeDecrementoStamina = 1f;
    public float staminaAtual;
    public Slider sliderStamina;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        staminaAtual = staminaInicial;
        AtualizarSlideStamina();

    }

    // Update is called once per frame
    void Update()
    {
        float eixoX = Input.GetAxisRaw("Horizontal") * velocidade;
        float eixoY = Input.GetAxisRaw("Vertical") * velocidade;
        
        rb.velocity = new Vector2(eixoX, eixoY);
        //Debug.Log($"Horizontal: {eixoX}, Vertical: {eixoY}");
    }

    void AtualizarSlideStamina()
    {
        sliderStamina.value = staminaAtual / staminaInicial;
    }
}
