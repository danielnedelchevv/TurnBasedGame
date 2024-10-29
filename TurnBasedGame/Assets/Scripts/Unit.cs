using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    private Vector3 targetPositon;

    private void Update()
    {
        float stoppingDistance = .1f;
        if (Vector3.Distance(transform.position, targetPositon) > stoppingDistance)
        {
            Vector3 moveDirection = (targetPositon - transform.position).normalized;
            float moveSpeed = 4f;
            transform.position += moveDirection * moveSpeed * Time.deltaTime;
        }
        if(Input.GetKeyDown(KeyCode.T))
        {
            Move(new Vector3(4, 0, 4));
        }
    }

    private void Move(Vector3 targetPosition)
    {
        this.targetPositon = targetPosition;
    }
}
