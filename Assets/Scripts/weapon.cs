using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    [SerializeField] private int damage = 50;
    [SerializeField] private int uses = 500;
    [SerializeField] private GameObject player = null;
    [SerializeField] private bool isAttacking = false;
    [SerializeField] public bool alreadyAttacked = false;
    private GameObject enemy = null;
    private Animator m_animator = null;

    // Start is called before the first frame update
    void Start()
    {
        isAttacking = player.GetComponent<Fighting>().isAttacking;
        m_animator = player.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (uses <= 0)
        {
            //TODO - make it break instead of destroy it
            Destroy(this);
        }
    }

    public void Attack()
    {
        if (enemy.tag == "enemy")
        {
            enemy.GetComponent<Health>().setHealth(enemy.GetComponent<Health>().getHealth() - damage);
            enemy.GetComponent<Animator>().SetTrigger("Take Damage");
            uses--;
            
        }
    }

    void OnTriggerEnter(Collider collision)
    {
        enemy = collision.gameObject.transform.root.gameObject;
    }
}
