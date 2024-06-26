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

    public int playerHealth = 100;
    public Slider lifeSlider;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        staminaAtual = staminaInicial;
        AtualizarSlideStamina();
        IsWalking = false;
        Debug.Log("Life do Player" + playerHealth);
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
        lifeSlider.value = playerHealth * 0.01f;

        if (Input.GetKeyDown(KeyCode.M))
        {
            SceneManager.LoadScene(0);
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

    public void TakeDamage(int damage)
    {
        playerHealth -= damage;
        Debug.Log("Player tomou" + damage + "de dano, saude restante:" + playerHealth);
   
        if (playerHealth <=0) {

            Debug.Log("morre");
            SceneManager.LoadScene(2);
        
        }

    
    }
}
