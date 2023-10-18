using System.Collections.Generic;
using UnityEngine;

public class User
{
	public string GoogleId { get; set; }
	public string Name { get; set; }
	public Texture2D Image { get; set; }
	public int Currency { get; set; }
	public List<LanguageData> Languages { get; set; }
	public int CurrentLanguage { get; set; }
	public List<GameInfo> LastGames { get; set; }
	public bool IsPremium { get; set; }

	/// To Do: Create statistic for player
	//public Dictionary<StatisticType, Statistic> Statistic { get; private set; }
}