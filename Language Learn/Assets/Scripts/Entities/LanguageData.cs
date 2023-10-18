using System.Collections.Generic;
using UnityEngine;

public class LanguageData
{
	[SerializeField]
	private Language _language;
	public string Name => _language?.Name;
	public Texture2D Flag => _language?.Flag;
	public  int Ratio { get; set; }
	public LanguageLevel Level { get; set; }
	public List<GameInfo> Games { get; set; }

	public LanguageData(string code, int ratio, int level)
	{
		_language = Resources.Load<Language>($"{Pathes.Languages}/{code}");
		Ratio = ratio;
		Level = (LanguageLevel)level;
	}
}
