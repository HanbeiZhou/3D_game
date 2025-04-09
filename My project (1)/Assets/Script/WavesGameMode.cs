using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WavesGameMode : MonoBehaviour
{
    [SerializeField] private Life playerLife;
    [SerializeField] private Life playerBaseLife;
    void Start()
    {
        playerLife.onDeath.AddListener(OnPlayerOrBaseDied);
        playerBaseLife.onDeath.AddListener(OnPlayerOrBaseDied);
        EnemyManager.instance.onChanged.AddListener(CheckWinCondition);
        WaveManager.instance.onChanged.AddListener(CheckWinCondition);
    }
   
    void OnPlayerOrBaseDied()
    {
        SceneManager.LoadScene("lose scene");
    }
    void CheckWinCondition()
    {
        
        if (EnemyManager.instance.enemies.Count <= 0 &&
            WaveManager.instance.waves.Count <= 0)
        {   SceneManager.LoadScene("win scene");
            SceneManager.LoadScene("win scene");
        }
    }

}
