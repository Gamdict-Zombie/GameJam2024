using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public enum Infotype{Exp, Level, Kill, Time, Health};
    public Infotype type;

    Text myText;
    Slider mySlider;

    void Awake(){
        myText = GetComponent<Text>();
        mySlider = GetComponent<Slider>();
    }

    void LateUpdate(){
        switch(type){
            case Infotype.Exp:
                break;
            case Infotype.Level:
                break;
            case Infotype.Kill:
                break;
            case Infotype.Time:
                break;
            case Infotype.Health:
                break;
        }
    }
}
