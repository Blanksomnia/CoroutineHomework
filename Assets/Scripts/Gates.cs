using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Gates : MonoBehaviour
{
    [SerializeField]
    private int Score = 0;
   

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "ball") { return; } 
        Score += 1;
        Destroy(other.gameObject);
        Debug.Log($"Score: {Score}");
    }
    private void OnDestroy()
    {
        Score = 0;
    }

}
