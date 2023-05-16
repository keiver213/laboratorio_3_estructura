using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState{
    menu,
    inGame,
    gameOver
}
public class GameManager : MonoBehaviour
{
    public  GameState currentGameState = GameState.menu;
    public static GameManager sharedInstance;
    public pala textom;

    void Awake(){
        if(sharedInstance==null){
            sharedInstance = this;
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //inicio del juego
    public void StartGame(){
            SetGameState(GameState.inGame); 
    }
    //fin del juego
    public void GameOver(){
            SetGameState(GameState.gameOver);
    }
    //devolver al menu 
    public void BackToMenu(){
            SetGameState(GameState.menu);
    }

    private void SetGameState(GameState newGameSate){
        if(newGameSate == GameState.menu){
             //Todo: logica del menu
             MenuManager.sharedInstance.ShowMainMenu();

        }else if(newGameSate == GameState.inGame){
            //preparar la escena 
            MenuManager.sharedInstance.HideMainMenu();
        
        }else if(newGameSate == GameState.gameOver){
            //Que hacer en caso del game Over
            MenuManager.sharedInstance.ShowMainMenu();  
       }
        this.currentGameState=newGameSate;
    }

}
