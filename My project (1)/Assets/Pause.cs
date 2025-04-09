using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{   public GameObject pauseMenu;
    public Button resumeButton;
    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
        resumeButton.onClick.AddListener(OnResumePressed);
        print("here");
    }

    // Update is called once per frame
    void Update()
    {
       if (Keyboard.current != null && Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            Time.timeScale = 0;
            pauseMenu.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

        }
        
    }
    void OnResumePressed(){
        print("resume pressed");
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    private void OnDestroy() {
        Time.timeScale = 1;
    }
}
