using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MenuChanger : MonoBehaviour
{
    [SerializeField]
    private List<UIDocument> _panels = new List<UIDocument>();
	private List<Button> _buttons = new List<Button>();

	private int _selectedIndex = 0;
	private void OnEnable()
	{
		_panels[_selectedIndex].gameObject.SetActive(true);
	}

	private void ChangePanel(int index)
	{
		if(index < _panels.Count)
		{
			_panels[_selectedIndex].gameObject.SetActive(false);
			_selectedIndex = index;
			_panels[_selectedIndex].gameObject.SetActive(true);
		}
	}
}
