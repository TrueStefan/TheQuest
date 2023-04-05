using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    Animator animator;
    SpriteRenderer spriteRenderer;
    public SwordAttack swordAttack;

    public ContactFilter2D contactFilter;
    List<RaycastHit2D> castCollisions = new List<RaycastHit2D>();
    Vector2 moveInput;

    public float moveSpeed = 1f;
    public float collisionOffset = 0.05f;
    public bool canMove = true;
    public float health = 10;

    public float Health
    {
        set
        {
            health = value;
            print("Player health:" + health);

            if (health <= 0)
            {
                Defeated();
            }
        }

        get
        {
            return health;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Defeated()
    {
        canMove = false;
        animator.SetBool("isMoving", false);
        animator.SetBool("isDead", true);
    }

    public void SwitchToMainMenu()
    {
        Destroy(gameObject);
        SceneManager.LoadScene("DeathScreen");
    }

    private void FixedUpdate()
    {
        if (canMove)
        {
            if (moveInput != Vector2.zero)
            {
                // check potential collisions
                bool success = TryMove(moveInput);

                if (!success)
                {
                    success = TryMove(new Vector2(moveInput.x, 0));
                }

                if (!success)
                {
                    success = TryMove(new Vector2(0, moveInput.y));
                }

                animator.SetBool("isMoving", true);
            }
            else
            {
                animator.SetBool("isMoving", false);
            }

            if (moveInput.x < 0)
            {
                spriteRenderer.flipX = true;

            }
            else if (moveInput.x > 0)
            {
                spriteRenderer.flipX = false;
            }
        }
    }

    public void SwordAttack()
    {

        if (spriteRenderer.flipX == true)
        {
            swordAttack.AttackRight();
        }
        else
        {
            swordAttack.AttackRight();
        }
    }

    public void EndSwordAttack()
    {
        swordAttack.StopAttack();
    }

    public void TakeDamage(float damage)
    {
        Health -= damage;
    }

    private void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    private bool TryMove(Vector2 direction)
    {
        if (direction != Vector2.zero)
        {
            int count = rb.Cast(direction, contactFilter, castCollisions, moveSpeed * Time.fixedDeltaTime + collisionOffset);

            if (count == 0)
            {
                rb.MovePosition(rb.position + direction * moveSpeed * Time.fixedDeltaTime);
                return true;
            }

            return false;
        }

        return false;
    }

    private void OnFire()
    {
        animator.SetTrigger("swordAttack");
    }
}