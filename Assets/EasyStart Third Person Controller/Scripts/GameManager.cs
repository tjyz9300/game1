using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;    
    public static GameManager Instance
    {
        get { return instance; } 
    }

    public Text textScore;
    public GameObject startPanel;
    public GameObject overPanel;

    public Flowchart flowchart;

    private int score;

    private void Awake()
    {
        instance = this;
        startPanel.SetActive(true);
        overPanel.SetActive(false);
        score = 0;
        flowchart.gameObject.SetActive(false);

    }


    public void AddScore(int num)
    {
        score += num;
        textScore.text = "获得自救资源：" + score;
        if(score >= 100)
        {
            overPanel.SetActive(true);
        }
    }

    public void ClickStart()
    {
        startPanel.SetActive(false);
        flowchart.gameObject.SetActive(true);
    }

    private void Update()
    {
        if (startPanel.activeInHierarchy)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

}
