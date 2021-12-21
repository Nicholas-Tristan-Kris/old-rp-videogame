using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighting : MonoBehaviour
{

    [SerializeField] private Animator m_animator = null;
    [SerializeField] private GameObject weapon = null;
    [SerializeField] private bool currentlyAttacking;
    public bool isAttacking = false;
    // Update is called once per frame
    void Update()
    {
        currentlyAttacking = weapon.GetComponent<weapon>().alreadyAttacked;
        isAttacking = m_animator.GetCurrentAnimatorStateInfo(0).IsName("Attack");

        if (weapon != null && Input.GetButton("Fire1") && !isAttacking)
        {
            Attack();
            weapon.GetComponent<weapon>().Attack();
        }

    }

    private void Attack()
    {
        m_animator.SetTrigger("Attack");

    }
}
