using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;

    void Start()
    {
        Instantiate(enemyPrefab, transform.position, transform.rotation);
    }

    void Update()
    {
        
    }
}
