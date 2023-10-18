using System;

public class GameInfo
{
	public Guid Id { get; private set; }
	public DateTime Date { get; private set; }
	public Guid WinnerId { get; private set; }
}