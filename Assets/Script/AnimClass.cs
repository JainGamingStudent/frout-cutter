using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimClass : MonoBehaviour
{

    public GameObject _parent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void fruitcut()
    {
        Debug.Log("");
    }

    public void fruitAnimEnd()
    {
        _parent.SendMessage("cutEnd");
    }
}
