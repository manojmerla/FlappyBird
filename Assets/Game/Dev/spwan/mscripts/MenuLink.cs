using UnityEngine;
using UnityEngine.UI;

public class MenuLink : MonoBehaviour
{
    public Slider slider;

    void Start()
    {
        if (AudioManager.instance != null)
        {
            AudioManager.instance.SetSlider(slider);
        }
    }
}