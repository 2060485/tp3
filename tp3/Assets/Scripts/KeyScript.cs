using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    public Animator doorAnimator;

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Player")
        {
            int currentKeyCount = doorAnimator.GetInteger("keyCount");
            doorAnimator.SetInteger("keyCount", currentKeyCount + 1);

            Destroy(gameObject);
            Debug.Log("Key collected!");
        }
    }
}
