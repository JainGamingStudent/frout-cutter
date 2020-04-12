using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyObj : MonoBehaviour
{
    public GameManager _manager;
    private void OnTriggerEnter2D(Collider other)
    {
        if(other.gameObject.tag=="fruit")
        {
            _manager.looseLife();
        }
    }
}
