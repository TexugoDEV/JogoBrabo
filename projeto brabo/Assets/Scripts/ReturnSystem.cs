using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnSystem : MonoBehaviour
{
    // Start is called before the first frame update
    
        private bool isPaused = false;
        public GameObject img;
        public GameObject audio;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                Pause();
            }
        }

    }
    void Pause()
    {
        Time.timeScale = 0f;
        isPaused = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        img.SetActive(true);
        audio.SetActive(false);
    }
    void ResumeGame()
    {
        Time.timeScale = 1f;
        isPaused = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        img.SetActive(false);
        audio.SetActive(true);
    }
}

// Update is called once per frame
