using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject prefab;
    public GameObject shootingPoint;
    private void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) {
            GameObject clone = Instantiate(prefab);
            clone.transform.position = shootingPoint.transform.position;
            clone.transform.rotation = shootingPoint.transform.rotation;
            
        }
        
    }
}
