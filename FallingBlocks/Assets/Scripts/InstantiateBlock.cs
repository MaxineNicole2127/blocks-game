using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstantiateBlock : MonoBehaviour
{
    [SerializeField] private GameObject block;
    [SerializeField] private float maxX;
    //[SerializeField] private float minX;
    [SerializeField] private float spawnRate;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private GameObject tapToStartText;


    private bool gameStarted = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && !gameStarted)
        {
            StartFallingBlocks();
            gameStarted = true;
            tapToStartText.SetActive(false);
        }
    }

    private void StartFallingBlocks()
    {
        InvokeRepeating("SpawnFallingBlock", 0.5f, spawnRate);
    }

    private void SpawnFallingBlock()
    {
        Vector3 spawnPos = spawnPoint.position;

        spawnPos.x = Random.Range(-maxX, maxX);
        Instantiate(block, spawnPos, Quaternion.identity);
        AddScore();
        
    }



    [SerializeField] private Text scoreText;

    private int score = 0;
    public void AddScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

}
