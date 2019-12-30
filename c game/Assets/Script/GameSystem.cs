using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameSystem : MonoBehaviour
{
    // Start is called before the first frame update


    private Player ply;
    [SerializeField] float currentTime;

    [SerializeField] float  units_digit_Time;
    [SerializeField] Text countdownText;

    [SerializeField] Image tempoDisplay; 

    public bool can_input;

    public int enemy_countdown;
    public float player_health;

    public float enemy_health;
    void Awake(){
        
    }
    void Start(){
        currentTime = 0f;
        enemy_countdown = 7;
        player_health = 3f;
    }

    void Update(){
        currentTime += 10 * Time.deltaTime;
        units_digit_Time = currentTime % 10;
        
        if (enemy_countdown == 0){
            enemy_countdown = 7;
        }
        if (units_digit_Time >= 5f){
            if (!can_input){
                enemy_countdown -= 1;

            }  
            can_input = true;
            tempoDisplay.enabled = true; 
        }
        else if (units_digit_Time < 5f){
            tempoDisplay.enabled = false;
            can_input = false; 
        }
        countdownText.text = enemy_countdown.ToString();

       
    }

}
