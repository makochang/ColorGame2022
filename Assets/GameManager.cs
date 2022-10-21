using UnityEngine;

public class GameManager : MonoBehaviour
{
    int score = 0;
    public Spawner[] spawners;

    float timer=0f;

    public int GetScore()
    {
        return score;
    }

    public void AddScore(int s)
    {
        score += s;
        Debug.Log(score);
    }

    private void Start()
    {
        spawners = GameObject.FindObjectsOfType<Spawner>();
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer>=3f)
        {
            if (spawners[Random.Range(0,spawners.Length)].Spawn())
            {
                timer = 0f;
            }
        }
    }

}
