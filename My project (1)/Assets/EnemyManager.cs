using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyManager : MonoBehaviour
{
    public static EnemyManager instance;
    public List<enemy> enemies;
    public UnityEvent onChanged;

    public void AddEnemy(enemy enemy)
    {
        enemies.Add(enemy);
        onChanged.Invoke();
    }
    public void RemoveEnemy(enemy enemy)
    {
        enemies.Remove(enemy);
        onChanged.Invoke();
    }
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
    
}
