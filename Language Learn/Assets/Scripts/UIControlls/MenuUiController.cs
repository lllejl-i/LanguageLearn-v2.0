using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Zenject;

public class MenuUiController : MonoBehaviour
{
    [SerializeField]
    private List<UIDocument> _panels = new List<UIDocument>();
	private List<Button> _buttons;

	private int _selectedIndex = 0;
	private UserController _user;
	private void Start()
	{
		var root = GetComponent<UIDocument>().rootVisualElement;
		_buttons = root.Query<Button>().ToList();
		for (int i = 0; i < _buttons.Count; i++)
		{
			if (_buttons[i] != null)
			{
				var index = i;
				_buttons[i].RegisterCallback<ClickEvent>(
				(ClickEvent e) =>
				{
					ChangePanel(index);
				});
			}
		}
	}

	[Inject]
	private void Construct(UserController user)
	{
		_user = user;
	}

	private void ChangePanel(int index)
	{
		if (index < _panels.Count &&
			index >= 0 &&
			index != _selectedIndex)
		{
			_panels[_selectedIndex].gameObject.SetActive(false);
			_selectedIndex = index;
			_panels[_selectedIndex].gameObject.SetActive(true);
		}
	}
}
