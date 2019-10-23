using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour{
    
    /*##publicSettings##*/
    //score
    public Text countText;
    //players
    public GameObject playerYellow;
    public GameObject playerRed;
    public GameObject playerBlue;

    /*##privateSettings##*/
    //score
    private float score = 0f;
    private float nextActionTime = 0.0f;
    private float period = 0.25f;

    private void Start(){
        score = 0f;
        countText.text = "";
        Time.timeScale = 1f;

        //InstancePlayer
        playerYellow.SetActive(false);
        playerRed.SetActive(false);
        playerBlue.SetActive(false);

        switch (Random.Range(0,3)){
            case 0:
                playerYellow.SetActive(true);
                break;
            case 1:
                playerRed.SetActive(true);
                break;
            case 2:
                playerBlue.SetActive(true);
                break;
        }
    }

    private void Update(){
        if (Time.time > nextActionTime ) {
            nextActionTime += period;
            SetCountText ();
        }
    }

    void SetCountText (){
        score++;
        countText.text = "Score: " + score.ToString ();
    }

    public void RestartGame(){
        var currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
    }
}
