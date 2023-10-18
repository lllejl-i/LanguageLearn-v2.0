using UnityEngine;
using UnityEngine.UIElements;
using Zenject;

public class ProfileUiController : MonoBehaviour
{
	private UserController _userController;
	[SerializeField]
	private VisualTreeAsset _clearGamesPanel;

	public void OnEnable()
	{
		OutputUserData();
	}

	[Inject]
	public void SetUserController(UserController userController)
	{
		_userController = userController;
	}

	private void OutputUserData()
	{
		if (_userController != null && _userController.User != null)
		{
			var root = GetComponent<UIDocument>().rootVisualElement;
			root.Q<VisualElement>("image").style.backgroundImage = _userController.User.Image;
			root.Q<Label>("name").text = _userController.User.Name;
			var currentLanguage = _userController.User.Languages[_userController.User.CurrentLanguage];
			root.Q<VisualElement>("flag").style.backgroundImage = currentLanguage.Flag;
			root.Q<Label>("ratio").text = currentLanguage.Ratio.ToString();
			
			GetComponent<UIDocument>().rootVisualElement.Q<ScrollView>("games").Add(_clearGamesPanel.CloneTree());
		}
	}
}
