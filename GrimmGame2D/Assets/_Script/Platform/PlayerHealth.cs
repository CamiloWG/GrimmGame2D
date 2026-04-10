using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth;
    [HideInInspector] public int currentHealth;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        animator = GetComponent<Animator>();
    }

    IEnumerator ReceiveDamage()
    {
        Physics2D.IgnoreLayerCollision(3, 6, true);
        currentHealth--;
        animator.SetBool("IsDamaged", true);
        yield return new WaitForSeconds(2);
        Physics2D.IgnoreLayerCollision(3, 6, false);
        animator.SetBool("IsDamaged", false);
    }
    

    public void Damage()
    {
        if(currentHealth > 1)
        {
            StartCoroutine(ReceiveDamage());
        } else
        {
            Destroy(gameObject);
        }
    }
}
