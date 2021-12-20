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
        if (weapon != null)
        {
            Attack();
        }

    }

    private void Attack()
    {
        if (!m_animator.GetCurrentAnimatorStateInfo(0).IsName("Attack") && Input.GetButton("Fire1"))
        {
            isAttacking = true;
            m_animator.SetTrigger("Attack");
        }
        else if(!m_animator.GetCurrentAnimatorStateInfo(0).IsName("Attack"))
        {
            isAttacking = false;
        }

    }
}
