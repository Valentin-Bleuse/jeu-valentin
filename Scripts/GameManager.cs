
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
        Pause(); // On met le jeu en pause au démarrage pour que le joueur le lance lui même
    }
    public void Play()
    {
        score = 0;
        scoreText.text = score.ToString();
        playButton.SetActive(false);
        gameOver.SetActive(false);
        Time.timeScale = 1; //on remet le temps à 1 pour que le jeu se lance
        player.enabled = true;
        Pipes[] pipes = FindObjectsOfType<Pipes>();//destroy all of the pipes
        for (int i = 0; i < pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject);
        }
    }

    public void Pause()
    {
        Time.timeScale = 0; //si le temps est à zéro, notre fonction Update est à l'arrêt
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
