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
    private Vector3 _startPosition;
    private List<RectTransform> _allDuplicates = new List<RectTransform>();

    private void Start()
    {
        _startPosition = objectToDuplicate.position;
    }

    private void Update()
    {
       // duplicate();
    }

    public void DuplicateOnClick(bool mirror)
    {
        _allDuplicates.Add(Instantiate(objectToDuplicate, parent));
        positoinPreviousDuplicates();
            
        _currentText = textChange.text;

        float defaultWidth = 1600;

        if (mirror)
        {
            currentDialogueImage.sprite = mirroredDialogueBox;
            objectToDuplicate.position = new Vector3(objectToDuplicate.position.x + (offsetX * (Screen.width / defaultWidth)), objectToDuplicate.position.y);
            _pressedButton = true;
        }
        else
        {
            objectToDuplicate.position = _startPosition;
            currentDialogueImage.sprite = defaultDialogueBox;
        }

    }

    private void duplicate()
    {
        if (_currentText != textChange.text && Input.GetButtonDown("Fire1") && _pressedButton)
        {
            _allDuplicates.Add(Instantiate(objectToDuplicate, parent));
            positoinPreviousDuplicates();
            objectToDuplicate.position = _startPosition;
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
                float defaultHeight =  1600;
                _allDuplicates[i].transform.position = new Vector3(_allDuplicates[i].transform.position.x, _allDuplicates[i].transform.position.y + (offsetY * Screen.height / defaultHeight) +(_allDuplicates[i+1].rect.height * Screen.height / defaultHeight), _allDuplicates[i].transform.position.z);

            }
            else
            {
                float defaultWidth = 1600;
                float newX = 0;
                if (_pressedButton)
                {
                    //newX = offsetX * (Screen.width/defaultWidth);
                    _pressedButton = false;
                }
                _allDuplicates[i].transform.position = new Vector3(_allDuplicates[i].transform.position.x+newX, _allDuplicates[i].transform.position.y + offsetY, _allDuplicates[i].transform.position.z);
            }


        }
    }


}
