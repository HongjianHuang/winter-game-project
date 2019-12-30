using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Player : MonoBehaviour
{
    
    public int att_count;
    public int def_count;
    
    public GameObject canvas; 
    public bool attck;
    public bool is_blocking; 

    private GameSystem game_system;

    public float enemy_current_health;
    

    [SerializeField] private Text input_text;
    [SerializeField] private Text def_input_text;
    [SerializeField] private bool can_input;
    [SerializeField] Slider enemy_health_bar; 

    void Awake(){
        game_system = canvas.GetComponent<GameSystem>();
        can_input = game_system.can_input;
    }
    void Start(){
        att_count = 0;
        def_count = 0;
        game_system.enemy_health = 3f;
        enemy_current_health = 3f;
        enemy_health_bar.value = 3f;
        is_blocking = false;
        input_text.text = "";
    }
    private void Update(){
        can_input = game_system.can_input;
        att_arrow_text(att_count);
        def_arrow_text(def_count);

        if (att_count == 6){
            
            Attck();
            Debug.Log("attck!");
            att_count = 0;
        }
        if (def_count == 6){
            Defence();
            Debug.Log("defence!");
            def_count = 0;
        }
    }
    public void Att_Input(){
        if (can_input){
            input_text.text = "";
            att_count += 1;
            def_count = 0;

        }
    }
    
    public void Def_Input(){
        if (can_input){
            input_text.text = "";
            def_count += 1;
            att_count = 0;
        }
    }

    public void Attck(){
        enemy_health_bar.value -= 1f; 
        enemy_current_health -= 1f;
    }
    public void Defence(){
        is_blocking = true;
    }
    private void att_arrow_text(int att_count){
        if (att_count == 2){
            input_text.text = "→";
        }
        if (att_count == 4){
            input_text.text = "→→";
        }
        if (att_count == 6){
            input_text.text = "→→→";
        }
    }
    private void def_arrow_text(int def_count){
        if (def_count == 2){
            input_text.text = "↑";
        }
        if (def_count == 4){
            input_text.text = "↑ ↑";
        }
        if (def_count == 6){
            input_text.text = "↑ ↑ ↑";
        }
    }
}
