using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Game : MonoBehaviour
{
    [SerializeField]
    private Button _Start, _Quit;
    [SerializeField]
    private GameObject _StartScreen, _GameOverScreen, _Win, _Lose, _GameScreen;

    void Awake()
    {
        _Start.onClick.AddListener(OnStart);
        _Quit.onClick.AddListener(OnQuit);

        _GameOverScreen.SetActive(false);
    }

    private void Start()
    {
        DOTween.Init();
    }

    private void OnStart()
    {
        _StartScreen.gameObject.SetActive(false);
    }

    private void OnQuit()
    {
        Application.Quit();
    }

    private void OnGameOver(bool hasWon)
    {
        _GameOverScreen.SetActive(true);
        _GameScreen.SetActive(false);

        if(hasWon) 
        { 
            _Win.SetActive(true);
        }
        else
        {
            _Lose.SetActive(true);
        }
    }
}
