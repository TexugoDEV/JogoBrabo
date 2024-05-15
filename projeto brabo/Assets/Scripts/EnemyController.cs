using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform WaypointA;
    public Transform WaypointB;
    public float moveSpeed = 3f;
    private Animator animator;
    private bool isWalking = false;

    private Rigidbody2D rb;
    private Transform currentTarget;
    private Vector3 scale;

    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        currentTarget = WaypointA;
        scale = transform.localScale;

    }

    // Update is called once per frame
    void Update()
    {
        MoveTowardsTarget();
    }

    private void MoveTowardsTarget()
    {
        Vector3 curTargetHorizontal = new Vector2(currentTarget.position.x, transform.position.y);
        Vector2 direction = (curTargetHorizontal - transform.position).normalized;

        transform.position += (Vector3)direction * moveSpeed * Time.deltaTime;

        if (Vector2.Distance(curTargetHorizontal, transform.position) <= 0.2f)
        {
            SwitchTarget();
        }
        UpdateAnimation();
    }

    private void SwitchTarget()
    {
        if (currentTarget == WaypointA)
        {
            currentTarget = WaypointB;
            Flip();
        }
        else
        {
            currentTarget = WaypointA;
            transform.localScale = scale;

        }
    }
    
    private void UpdateAnimation()
    {
        isWalking = (Vector2.Distance(transform.position, currentTarget.position) > 0.1f);
        animator.SetBool("isWalking", isWalking);
    }

    private void Flip()
    {
        Vector3 flippedScale = scale;
        flippedScale.x *= -1;
        transform.localScale = flippedScale;
    }
}
