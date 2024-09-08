using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    private string currentState = "IdleState";
    private Transform target;
    [SerializeField] private float chaseRange, attackRange, followRange, enemySpeed;
    public Animator animator;
    public Slider enemyHealthBar;
    public Gradient gradient;
    public Image fill;
    public GameObject canvasHealth;

    public int enemyHP, enemyMaxHP;
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        enemyHP = enemyMaxHP;
        enemyHealthBar.maxValue = enemyHealthBar.value = enemyHP;
        fill.color = gradient.Evaluate(1f);
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerManager.gameOver)
        {
            animator.ResetTrigger("chase");
            animator.SetBool("isAttacking", false);
            animator.SetBool("gameOver", true);
        }

        float distance = Vector3.Distance(transform.position, target.position);

        #region IdleRunAttackState

        if (currentState == "IdleState")
        {
            // karakter ve d��man uzakl��� belirtilen uzakl�ktan k���k ise "chase durumu" aktif olur. Yani karakter ve d��man birbirine yak�n demektir.
            if (distance < chaseRange)
                currentState = "ChaseState";
        }

        else if (currentState == "ChaseState" && (distance < followRange)) // "chase durumu" aktif ve d��man-oyuncu uzakl��� istenilen aral�kta ise bu ko�ul aktif olur
        {
            animator.SetTrigger("chase"); // chase yani d��man ko�ma animasyonu aktifle�tirildi.
            animator.SetBool("isAttacking", false);

            if (distance < attackRange)
            {
                currentState = "AttackState";
            }

            if (target.position.x > transform.position.x) // target'�n x de�eri(yatay eksende) d��mandan b�y�kse d��man solda karakter(target) sa�da demektir.
            {
                // d��man solda karakter(target) sa�da oldu�undan d��man�n y�n� sa�'a do�ru olmal�.
                transform.Translate(transform.right * enemySpeed * Time.deltaTime);
                transform.rotation = Quaternion.Euler(0, 180, 0);
            }
            else // target x de�eri d��man'dan k���kse d��man sa�da karakter(target) solda demektir.
            {
                // d��man sa�da karakter(target) solda oldu�undan d��man�n y�n� sol'a do�ru olmal�.
                transform.Translate(-transform.right * enemySpeed * Time.deltaTime); // transform.left olmad���nda "-transform.right" yapt�k.
                transform.rotation = Quaternion.Euler(0, 0, 0);
            }
        }

        else if (currentState == "AttackState" && (distance < attackRange))
        {
            animator.SetBool("isAttacking", true);
        }

        else
        {
            animator.ResetTrigger("chase");
            currentState = "IdleState";
            animator.SetTrigger("idle");
        }
        #endregion
    }

    public void TakeDamage(int damage)
    {
        enemyHP -= damage;
        enemyHealthBar.value = enemyHP;
        fill.color = gradient.Evaluate(enemyHealthBar.normalizedValue);
        currentState = "ChaseState";

        if (enemyHP < 0)
        {
            EnemyDie();
        }
    }

    private void EnemyDie()
    {
        animator.SetTrigger("isDead");
        GetComponent<CapsuleCollider>().enabled = false;
        GetComponent<Rigidbody>().useGravity = false;
        canvasHealth.SetActive(false);
        this.enabled = false;
        Destroy(gameObject, 3.5f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "DeathPoint")
        {
            Destroy(gameObject, 1.5f);
        }
    }
}
