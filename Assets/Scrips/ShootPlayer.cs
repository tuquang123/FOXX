using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class ShootPlayer : MonoBehaviour
{
    public Transform point;
    public GameObject bulelt;

    public float attackRage = 0.5f;
    public float attackRate = 1f;
    float nextAttackTime = 0f;

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextAttackTime)
        {
            if (CrossPlatformInputManager.GetButton("Shoot"))
            {
                Instantiate(bulelt, point.position, point.rotation);

                nextAttackTime = Time.time + 1f / attackRate;

            }
        }
    }
}
