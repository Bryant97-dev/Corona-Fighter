using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Text highScore;
    //public GameAlien gameku;
    int score ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ScoreFinal (int finalscore){
         score = finalscore;

        //tampilkan di UI
        highScore.text = score + "";
    }

    public void OnBackToMenu()
    {
        SceneManager.LoadSceneAsync("MenuAwal");
    }
}
