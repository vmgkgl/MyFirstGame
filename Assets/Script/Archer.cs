using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : MonoBehaviour
{
    Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void ShootBtn()
    {
        float hp = animator.GetFloat("Hp_f");

        if (hp > 0) 
        {
            animator.SetTrigger("shoot_t");
            hp -= 10;
            animator.SetFloat("Hp_f", hp);
        }
        else
        {
            animator.SetTrigger("die_t");
        }
    }
}
