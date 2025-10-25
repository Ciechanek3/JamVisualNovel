using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterChanger : MonoBehaviour
{
    [SerializeField] private RawImage _image;
    [SerializeField] private List<CharacterChanger> allCharacters;

    public void ChangeCharacterTexture(Texture texture)
    {
        if (texture == null)
        {
            this.gameObject.SetActive(false); 
            return;
        }
        this.gameObject.SetActive(true);
        _image.texture = texture;
    }

    public void Disable()
    {
        this.gameObject.SetActive(false);
    }

    public void DisableAll()
    {
        foreach (var character in allCharacters)
        {
            character.gameObject.SetActive(false);
        }
    }
}
