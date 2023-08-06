using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Terraria;
using Terraria.ModLoader.Config;

namespace BetterExtractinator
{
	[Label("Better Extractinator Configurations")]
	public class ModConfigsai : ModConfig
	{
		public override ConfigScope Mode => ConfigScope.ServerSide;

		[Range(1f, 15f)]
		[Increment(1f)]
		[DefaultValue(1f)]
		[Slider]
		[Label("Extractinator Speed Multiplier")]
		public float ExSpeeed;

		[Range(1f, 50f)]
		[Increment(1f)]
		[DefaultValue(1f)]
		[Slider]
		[Label("Amount of Items Used Per Use of Extractinator")]
		public float BlockAmount;
	}
}
