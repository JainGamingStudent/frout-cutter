using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    int score = 0;
    public TextMeshProUGUI score_txt;
    int lifecout = 3;
    public GameObject[] lifeicon;
    public GameObject fruitObj;
    public GameObject bompObj;
    GameObject sponObj;

    public GameObject _over;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(sponeObj());
    }


    IEnumerator sponeObj()
    {
        yield return new WaitForSeconds(Random.Range(2, 4));
        float rand = Random.Range(0, 10);
        int limit = 1;
        if(rand>7)
        {
            limit = 3;
        }
        else if(rand >5)
        {
            limit = 2;
        }
        for (int i = 0;i< limit;i++)
        {
            if(Random.Range(0,10)>7)
            {
                sponObj = Instantiate(bompObj) as GameObject;
            }
            else
            {
                sponObj = Instantiate(fruitObj) as GameObject;
            }
        }
        StartCoroutine(sponeObj());
    }
    public void updateScore(int val)
    {
        score += val;
        score_txt.text = "Score : " + score;
    }


    public void looseLife()
    {
        lifecout--;
        lifeicon[lifecout].SetActive(false);
        if(lifecout<=0)
        {
            _over.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void restartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("SampleScene");
    }
}
