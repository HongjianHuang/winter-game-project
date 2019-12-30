using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float currentTime = 0f;
    [SerializeField] float startingTime = 5f;
    [SerializeField] Text countdownText;

    

    void Start(){
        currentTime = startingTime;
    }

    void Update(){
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");
        if (currentTime <= 0){
            currentTime = 5f;
        }
    }
}
