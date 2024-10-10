using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleToAttackAndReverse : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator characterAnimator;
    public GameObject otherCharacter;
    public float attackDistance = 0.40f;

    void Start()
    {
        characterAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (characterAnimator != null && otherCharacter != null)
        {
            float distance = Vector3.Distance(transform.position, otherCharacter.transform.position);
            Debug.Log("Distance between characters:" + distance);

            if (distance < attackDistance)
            {
                characterAnimator.SetTrigger("Attack");
            }
            else
            {
                characterAnimator.SetTrigger("Idle");
            }

            ///Using buttons
            if (Input.GetKeyUp(KeyCode.I))
            {
                characterAnimator.SetTrigger("Idle");
            }
            if (Input.GetKeyUp(KeyCode.A))
            {
                characterAnimator.SetTrigger("Attack");
            }

        }


    }
}
