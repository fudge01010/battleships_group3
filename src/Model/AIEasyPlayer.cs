

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

public class AIEasyPlayer : AIPlayer
{
	public AIEasyPlayer (BattleShipsGame controller) : base(controller)
	{
	}
	/// <summary>
	/// Generates the coords.
	/// </summary>
	/// <param name="row">Row.</param>
	/// <param name="column">Column.</param>
	protected override void GenerateCoords(ref int row, ref int column)
	{
		row = _Random.Next(0, EnemyGrid.Height);
		column = _Random.Next(0, EnemyGrid.Width);
	}

	protected override void ProcessShot(int row, int col, AttackResult result)
	{
		if (result.Value == ResultOfAttack.Hit)
			GenerateCoords ();
	}
}


