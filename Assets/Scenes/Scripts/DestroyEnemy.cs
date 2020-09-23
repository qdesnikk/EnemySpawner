using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    void OnEnable()
    {
        Destroy(gameObject, 5f);
    }
}
