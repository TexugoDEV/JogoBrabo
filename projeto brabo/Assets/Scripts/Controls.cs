using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Controls : MonoBehaviour
{
    // Start is called before the first frame update

    private Rigidbody2D rb;
    public Animator movement;
    public float velocidade = 5f;
    public float staminaInicial = 100f;
    public float taxaDeDecrementoStamina = 1f;
    public float taxaRecuperacaoStamina = 1f;
    public float staminaAtual;
    public Slider sliderStamina;
    bool IsWalking = false;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        staminaAtual = staminaInicial;
        AtualizarSlideStamina();
        IsWalking = false;
    }

    // Update is called once per frame
    void Update()
    {
        float eixoX = Input.GetAxisRaw("Horizontal") * velocidade;
        float eixoY = Input.GetAxisRaw("Vertical") * velocidade;
        IsWalking = eixoX != 0 || eixoY != 0;


        rb.velocity = new Vector2(eixoX, eixoY);
        //Debug.Log($"Horizontal: {eixoX}, Vertical: {eixoY}");

        if (eixoX !=0 || eixoY != 0)
        {
            staminaAtual -= taxaDeDecrementoStamina * Time.deltaTime;
            if(staminaAtual <= 0)
            {
                staminaAtual = 0;
                SceneManager.LoadScene(2);
            }
            movement.SetFloat("eixoX", eixoX);
            movement.SetFloat("eixoY", eixoY);

            AtualizarSlideStamina();
        }
        movement.SetBool("IsWalking", IsWalking);
        if (Input.GetKeyDown(KeyCode.Z))
        {
            movement.SetTrigger("Attack");
            Debug.Log("deu certo dog");
        }
       
    }
    

    void AtualizarSlideStamina()
    {
        sliderStamina.value = staminaAtual / staminaInicial;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Recover"))
        {
            Debug.Log("colidi legal dog");
            StartCoroutine(recuperarStamina());
        }
        
    }

    IEnumerator recuperarStamina()
    {
        while (staminaAtual < staminaInicial)
        {
            staminaAtual += taxaRecuperacaoStamina * Time.deltaTime;
            AtualizarSlideStamina();
            yield return null;
        }
    }
}
