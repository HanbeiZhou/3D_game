using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreOnDeath : MonoBehaviour
{
    public int amount;
    private void Awake()
    {
        var life = GetComponent<Life>();
        life.onDeath.AddListener(GivePoints);
    }
    void GivePoints()
    {
        ScoreManager.instance.amount += amount;
    }

    void OnDestroy()
    {
        //ScoreManager.instance.amount += amount;
        var life = GetComponent<Life>();
        life.onDeath.RemoveListener(GivePoints);
    }
}
