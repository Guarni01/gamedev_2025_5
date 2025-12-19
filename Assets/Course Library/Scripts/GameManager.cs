using System.Collections;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score = 0;
    public GameObject[] targets;
    public float spawnInterval = 1.0f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SpawnTarget());
        UpdateScore(0);
    }

    IEnumerator SpawnTarget() 
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnInterval);
            int index = Random.Range(0, targets.Length);
            Instantiate(targets[index]);
            UpdateScore(100);
        }

    }

    private void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
