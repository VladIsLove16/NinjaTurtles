using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeChanger : MonoBehaviour
{
    [SerializeField] bool sizeup;
    public void OnTriggerEnter2D(Collider2D other)
    {
        CharacterController character = other.GetComponent<CharacterController>();
        if (character != null)
        {
            Use(character);
        }
    }
    private void Use(CharacterController character)
    {
        if (sizeup)
        {
            if (character.GetSize() < Size.huge)
            {
                character.IncreaseSize();
                SetDisabled();
            }
        }
        else
        {
            if (character.GetSize() > Size.small)
            {
                character.DecreaseSize();
                SetDisabled();
            }
        }

        
    }
    private void SetDisabled()
    {
        gameObject.SetActive(false);
    }
}
