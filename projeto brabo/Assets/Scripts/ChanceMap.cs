using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChanceMap : MonoBehaviour
{
    public string fase1;
    public string fase3;
    public string fase4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(fase1);
        SceneManager.LoadScene(fase3);
        SceneManager.LoadScene(fase4);
    }

    private void CarregarNovaFase()
    {
        SceneManager.LoadScene(fase1);
        SceneManager.LoadScene(fase3);
        SceneManager.LoadScene(fase4);
    }

}
