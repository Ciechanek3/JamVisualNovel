using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogueController : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _text;
    [SerializeField]
    private TextMeshProUGUI _ownerName;
    [SerializeField]
    private List<DIalogueAsset> dialogueBank;

    [SerializeField]
    private bool isInitial = false;

    private int _currentIndex = 0;
    private float _currentTimer = 0;
    private void Awake()
    {
        if (isInitial)
            PlayDialogue(0);
    }

    public void PlayDialogue(int index)
    {
        var asset = dialogueBank[index];
        if (_currentIndex < asset.Texts.Count)
            StartCoroutine(DisplayDialogueForTime(asset.Texts[_currentIndex], PlayDialogue, asset, index));
        else
            DisableDialogue();
    }

    private IEnumerator DisplayDialogueForTime(DIalogueAsset.TimedText text, Action<int> onFinish, DIalogueAsset asset, int index)
    {
        _text.text = text.Text;
        _text.gameObject.SetActive(true);
        _ownerName.text = text.OwnerName;

        text.EventToPlay?.Invoke();

        _currentTimer = 0;
        while (_currentTimer < text.DisplayTime)
        {
            _currentTimer += Time.deltaTime;
            yield return null;
        }

        _currentIndex++;
        onFinish?.Invoke(index);
    }

    private void DisableDialogue()
    {
        _currentIndex = 0;
        _text.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            _currentTimer = 999;
        }
    }
}
