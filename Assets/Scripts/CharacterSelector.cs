using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CharacterSelector : MonoBehaviour
{
    public TMP_Dropdown characterDropdown;
    public Image characterImage;
    public Sprite[] characterSprites;
    public TMP_Text descriptionText;

    [TextArea(3, 10)]
    public string[] descriptions;

    public void ChangeCharacter(int index)
    {
        if (index >= 0 && index < characterSprites.Length)
            characterImage.sprite = characterSprites[index];

        if (index >= 0 && index < descriptions.Length)
            descriptionText.text = descriptions[index];
    }
}