
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    private int score;

    public void GameOver()
    {
        Debug.Log("Game Over");
    }
    public void IncreaseScore()
    {
        score++;
        // Debug.Log(score);
    }


}
