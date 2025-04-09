using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WaveManager : MonoBehaviour
{
    public static WaveManager instance;
    public List<WaveSprawer> waves;
    public UnityEvent onChanged;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.LogError("Duplicated ScoreManager, ignore this one", gameObject);
        }
    }
    public void addWave(WaveSprawer wavesprawer)
    {
        waves.Add(wavesprawer);
        onChanged.Invoke();
    }
    public void removeWave(WaveSprawer wavesprawer)
    {
        waves.Remove(wavesprawer);
        onChanged.Invoke();
    }
    
}
