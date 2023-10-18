using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class TestLogin : MonoBehaviour
{
	[SerializeField]
	private string _testToken = "123456789";
	[SerializeField]
	private UserTestObject _userTestObject;
	[SerializeField]
	private List<Language> _languages = new List<Language>();
	private UserController _user;
	private void Awake()
	{
		var languageData = new List<LanguageData>();
		languageData.Add(new LanguageData("en-gb", 500, 2));

		User user = new User() {
			GoogleId = _testToken,
			Name = "Say my name",
			Currency = 6969,
			Image = _userTestObject.Image,
			Languages = languageData,
			CurrentLanguage = 0,
			IsPremium = true,
			LastGames = null
		};
		_user.AuthorizeUser(user);
		gameObject.SetActive(false);
	}

	[Inject]
	private void Construct(UserController user)
	{
		_user = user;
	}
}
