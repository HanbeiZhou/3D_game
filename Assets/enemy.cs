using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        EnemyManager.instance.AddEnemy(this);
    }

    // Update is called once per frame
    void OnDestroy()
    {
        EnemyManager.instance.RemoveEnemy(this);
    }
}
