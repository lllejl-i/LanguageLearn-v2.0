using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Zenject;

public class TopPanelUiController : MonoBehaviour
{
	private UserController _userController;

	private void Start()
	{
		ChangeCurrency();
	}

	[Inject]
	private void Construct(UserController userController)
	{
		_userController = userController;
	}

	private void ChangeCurrency()
	{
		if (_userController != null)
		{
			var root = GetComponent<UIDocument>().rootVisualElement;
			root.Q<Label>("currencyLabel").text = _userController.User.Currency.ToString();
		}
	}
}
