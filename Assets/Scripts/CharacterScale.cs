using UnityEngine;
using UnityEngine.UI;

public class CharacterScaler : MonoBehaviour
{
    public RectTransform characterTransform;
    public Slider heightSlider;
    public Slider widthSlider;

    public void UpdateScale()
    {
        characterTransform.localScale = new Vector3(widthSlider.value, heightSlider.value, 1f);
    }
}