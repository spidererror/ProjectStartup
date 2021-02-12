using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.UI;
public class DuplicatePanel : MonoBehaviour
{
    public Text textChange;
    public Sprite defaultDialogueBox;
    public Sprite mirroredDialogueBox;
    public Image currentDialogueImage;
    public GameObject gameObjectInactive;
    public RectTransform objectToDuplicate;
    public Transform parent;
    public float offsetY = 20;
    public float offsetX = 50;
    private string _currentText;
    private bool _pressedButton;
    private List<RectTransform> _allDuplicates = new List<RectTransform>();

    private void Update()
    {
        duplicate();
    }

    public void DuplicateOnClick()
    {

        _allDuplicates.Add(Instantiate(objectToDuplicate, parent));
        positoinPreviousDuplicates();

        _currentText = textChange.text;
        _pressedButton = true;
        currentDialogueImage.sprite = mirroredDialogueBox;

    }

    private void duplicate()
    {
        if (_currentText != textChange.text && Input.GetButtonDown("Fire1") && !gameObjectInactive.activeSelf)
        {
            _allDuplicates.Add(Instantiate(objectToDuplicate, parent));
            positoinPreviousDuplicates();

            _currentText = textChange.text;
            currentDialogueImage.sprite = defaultDialogueBox;

        }
    }

    private void positoinPreviousDuplicates()
    {
        
        for (int i = 0; i < _allDuplicates.Count; i++)
        {
            if (i<_allDuplicates.Count-1)
            {
                _allDuplicates[i].transform.position = new Vector3(_allDuplicates[i].transform.position.x, _allDuplicates[i].transform.position.y + offsetY+(_allDuplicates[i+1].rect.height/5), _allDuplicates[i].transform.position.z);

            }
            else
            {
                float newX = 0;
                if (_pressedButton)
                {
                    newX = offsetX;
                    _pressedButton = false;
                }
                _allDuplicates[i].transform.position = new Vector3(_allDuplicates[i].transform.position.x+newX, _allDuplicates[i].transform.position.y + offsetY, _allDuplicates[i].transform.position.z);
            }


        }
    }


}
