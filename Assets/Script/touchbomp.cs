using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchbomp : MonoBehaviour
{
    public GameObject bomp;
    public GameObject cutbomp;
    public GameManager _manager;
    private void Awake()
    {
        _manager = GameObject.Find("Manager").GetComponent<GameManager>();
        gameObject.transform.position = new Vector3(Random.Range(-1.2f, 1.1f), -5, 0);
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-200, 200), Random.Range(600, 700)));
    }
    private void OnMouseOver()
    {
        bomp.SetActive(false);
        cutbomp.SetActive(true);
    }

    public void cutEnd()
    {
        _manager.looseLife();
        Destroy(gameObject);
    }
    private void Update()
    {
        if (gameObject.transform.position.y < -6)
        {
            _manager.updateScore(5);
            Destroy(gameObject);

        }
    }
}
