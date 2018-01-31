using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcidPuddle : MonoBehaviour
{
void OnTriggerEnter(Collider other)
    {
        var attempt = other.GetComponent<IDamageable>();
        if(attempt != null)
        {

        }
    }
