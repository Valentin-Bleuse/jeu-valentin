
using UnityEngine;
using UnityEngine.UI; // import des éléments UI
public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Player player;
    public Text scoreText;
    public GameObject playButton;
    public GameObject gameOver;
    private int score;

    private void Awake()
    {
        Application.targetFrameRate = 60;
        Pause(); //we put the game on pause at the start so the player can start it himself
    }
    public void Play()
    {
        score = 0;
        scoreText.text = score.ToString();
        playButton.SetActive(false);
        gameOver.SetActive(false);
        Time.timeScale = 1; //we set the time to 1 so the game starts
        player.enabled = true;
        Pipes[] pipes = FindObjectsOfType<Pipes>();//destroy all of the pipes
        for (int i = 0; i < pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject);
        }
    }

    public void Pause()
    {
        Time.timeScale = 0; //if the time is 0, our Update function is stopped
        player.enabled = false;
    }
    public void GameOver()
    {
        gameOver.SetActive(true);
        playButton.SetActive(true);
        Pause();

    }
    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString(); //convert our value to a string
    }


}
