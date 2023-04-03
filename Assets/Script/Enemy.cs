using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    GameObject target;
    float speed = 1f;

    void Start()
    {
        target = GameObject.Find("Player");
    }

    void Update()
    {
        // targetに向かって進むコード
        if (target != null)
        {
            transform.position += (target.transform.position - transform.position).normalized * speed * Time.deltaTime;
        }
    }
}
