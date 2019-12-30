using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject canvas; 
    public GameObject player_object;
    private GameSystem game_system;

    private Player player;

    [SerializeField] Slider player_health_bar; 
    void Awake(){
        game_system = canvas.GetComponent<GameSystem>();
        player = player_object.GetComponent<Player>();
    }
    public float player_current_health; 
    void Start()
    {
        player_current_health = 3f;
        player_health_bar.value = player_current_health;
    }

    // Update is called once per frame
    void Update()
    {
        if (game_system.enemy_countdown == 0){
            Enemy_attck();
        }
    }

    void Enemy_attck(){
        if (player.is_blocking){
            player.is_blocking = false;
        }
        else{
            player_current_health -= 1; 
            player_health_bar.value = player_current_health;
        }
    

    }
 
}
