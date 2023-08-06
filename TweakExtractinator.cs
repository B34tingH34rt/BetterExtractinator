using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.ModLoader.Core;
using Terraria.GameContent.Creative;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.Localization;
using Terraria.ModLoader.IO;
using Terraria.UI;
using Terraria.Utilities;

namespace BetterExtractinator
{
    internal class TweakExtractinator : GlobalItem
    {
        public void extUse(int inputItemID, ref int outputItemID, ref int outputStackSize)
        {
			int num = 5000;
			int num2 = 25;
			int num3 = 50;
			int num4 = -1;
			if (inputItemID == 3347)
			{
				num /= 3;
				num2 *= 2;
				num3 = 20;
				num4 = 10;
			}
			int num5 = -1;
			int num6 = 1;
			if (num4 != -1 && Main.rand.Next(num4) == 0)
			{
				num5 = 3380;
				if (Main.rand.Next(5) == 0)
				{
					num6 += Main.rand.Next(2);
				}
				if (Main.rand.Next(10) == 0)
				{
					num6 += Main.rand.Next(3);
				}
				if (Main.rand.Next(15) == 0)
				{
					num6 += Main.rand.Next(4);
				}
			}
			else if (Main.rand.Next(2) == 0)
			{
				if (Main.rand.Next(12000) == 0)
				{
					num5 = 74;
					if (Main.rand.Next(14) == 0)
					{
						num6 += Main.rand.Next(0, 2);
					}
					if (Main.rand.Next(14) == 0)
					{
						num6 += Main.rand.Next(0, 2);
					}
					if (Main.rand.Next(14) == 0)
					{
						num6 += Main.rand.Next(0, 2);
					}
				}
				else if (Main.rand.Next(800) == 0)
				{
					num5 = 73;
					if (Main.rand.Next(6) == 0)
					{
						num6 += Main.rand.Next(1, 21);
					}
					if (Main.rand.Next(6) == 0)
					{
						num6 += Main.rand.Next(1, 21);
					}
					if (Main.rand.Next(6) == 0)
					{
						num6 += Main.rand.Next(1, 21);
					}
					if (Main.rand.Next(6) == 0)
					{
						num6 += Main.rand.Next(1, 21);
					}
					if (Main.rand.Next(6) == 0)
					{
						num6 += Main.rand.Next(1, 20);
					}
				}
				else if (Main.rand.Next(60) == 0)
				{
					num5 = 72;
					if (Main.rand.Next(4) == 0)
					{
						num6 += Main.rand.Next(5, 26);
					}
					if (Main.rand.Next(4) == 0)
					{
						num6 += Main.rand.Next(5, 26);
					}
					if (Main.rand.Next(4) == 0)
					{
						num6 += Main.rand.Next(5, 26);
					}
					if (Main.rand.Next(4) == 0)
					{
						num6 += Main.rand.Next(5, 25);
					}
				}
				else
				{
					num5 = 71;
					if (Main.rand.Next(3) == 0)
					{
						num6 += Main.rand.Next(10, 26);
					}
					if (Main.rand.Next(3) == 0)
					{
						num6 += Main.rand.Next(10, 26);
					}
					if (Main.rand.Next(3) == 0)
					{
						num6 += Main.rand.Next(10, 26);
					}
					if (Main.rand.Next(3) == 0)
					{
						num6 += Main.rand.Next(10, 25);
					}
				}
			}
			else if (num != -1 && Main.rand.Next(num) == 0)
			{
				num5 = 1242;
			}
			else if (num2 != -1 && Main.rand.Next(num2) == 0)
			{
				num5 = Main.rand.Next(6) switch
				{
					0 => 181,
					1 => 180,
					2 => 177,
					3 => 179,
					4 => 178,
					_ => 182,
				};
				if (Main.rand.Next(20) == 0)
				{
					num6 += Main.rand.Next(0, 2);
				}
				if (Main.rand.Next(30) == 0)
				{
					num6 += Main.rand.Next(0, 3);
				}
				if (Main.rand.Next(40) == 0)
				{
					num6 += Main.rand.Next(0, 4);
				}
				if (Main.rand.Next(50) == 0)
				{
					num6 += Main.rand.Next(0, 5);
				}
				if (Main.rand.Next(60) == 0)
				{
					num6 += Main.rand.Next(0, 6);
				}
			}
			else if (num3 != -1 && Main.rand.Next(num3) == 0)
			{
				num5 = 999;
				if (Main.rand.Next(20) == 0)
				{
					num6 += Main.rand.Next(0, 2);
				}
				if (Main.rand.Next(30) == 0)
				{
					num6 += Main.rand.Next(0, 3);
				}
				if (Main.rand.Next(40) == 0)
				{
					num6 += Main.rand.Next(0, 4);
				}
				if (Main.rand.Next(50) == 0)
				{
					num6 += Main.rand.Next(0, 5);
				}
				if (Main.rand.Next(60) == 0)
				{
					num6 += Main.rand.Next(0, 6);
				}
			}
			else if (Main.rand.Next(3) == 0)
			{
				if (Main.rand.Next(5000) == 0)
				{
					num5 = 74;
					if (Main.rand.Next(10) == 0)
					{
						num6 += Main.rand.Next(0, 3);
					}
					if (Main.rand.Next(10) == 0)
					{
						num6 += Main.rand.Next(0, 3);
					}
					if (Main.rand.Next(10) == 0)
					{
						num6 += Main.rand.Next(0, 3);
					}
					if (Main.rand.Next(10) == 0)
					{
						num6 += Main.rand.Next(0, 3);
					}
					if (Main.rand.Next(10) == 0)
					{
						num6 += Main.rand.Next(0, 3);
					}
				}
				else if (Main.rand.Next(400) == 0)
				{
					num5 = 73;
					if (Main.rand.Next(5) == 0)
					{
						num6 += Main.rand.Next(1, 21);
					}
					if (Main.rand.Next(5) == 0)
					{
						num6 += Main.rand.Next(1, 21);
					}
					if (Main.rand.Next(5) == 0)
					{
						num6 += Main.rand.Next(1, 21);
					}
					if (Main.rand.Next(5) == 0)
					{
						num6 += Main.rand.Next(1, 21);
					}
					if (Main.rand.Next(5) == 0)
					{
						num6 += Main.rand.Next(1, 20);
					}
				}
				else if (Main.rand.Next(30) == 0)
				{
					num5 = 72;
					if (Main.rand.Next(3) == 0)
					{
						num6 += Main.rand.Next(5, 26);
					}
					if (Main.rand.Next(3) == 0)
					{
						num6 += Main.rand.Next(5, 26);
					}
					if (Main.rand.Next(3) == 0)
					{
						num6 += Main.rand.Next(5, 26);
					}
					if (Main.rand.Next(3) == 0)
					{
						num6 += Main.rand.Next(5, 25);
					}
				}
				else
				{
					num5 = 71;
					if (Main.rand.Next(2) == 0)
					{
						num6 += Main.rand.Next(10, 26);
					}
					if (Main.rand.Next(2) == 0)
					{
						num6 += Main.rand.Next(10, 26);
					}
					if (Main.rand.Next(2) == 0)
					{
						num6 += Main.rand.Next(10, 26);
					}
					if (Main.rand.Next(2) == 0)
					{
						num6 += Main.rand.Next(10, 25);
					}
				}
			}
			else
			{
				num5 = Main.rand.Next(8) switch
				{
					0 => 12,
					1 => 11,
					2 => 14,
					3 => 13,
					4 => 699,
					5 => 700,
					6 => 701,
					_ => 702,
				};
				if (Main.rand.Next(20) == 0)
				{
					num6 += Main.rand.Next(0, 2);
				}
				if (Main.rand.Next(30) == 0)
				{
					num6 += Main.rand.Next(0, 3);
				}
				if (Main.rand.Next(40) == 0)
				{
					num6 += Main.rand.Next(0, 4);
				}
				if (Main.rand.Next(50) == 0)
				{
					num6 += Main.rand.Next(0, 5);
				}
				if (Main.rand.Next(60) == 0)
				{
					num6 += Main.rand.Next(0, 6);
				}
			}
			outputItemID = num5;
			outputStackSize = num6;
		}
        public override bool? UseItem(Item item, Player player)
        {
            Vector2 mousePosition = Main.MouseWorld;
            int tileX = (int)(mousePosition.X / 16f);
            int tileY = (int)(mousePosition.Y / 16f);
            Tile cursorTile = Main.tile[tileX, tileY];

            if (cursorTile.TileType == TileID.Extractinator && player.cursorItemIconEnabled) // If mouse is over extractinator
            {
                if (item.type == ItemID.SiltBlock || item.type == ItemID.SlushBlock || item.type == ItemID.DesertFossil) // if selected item is silt/slush/fossil
                {
					if (ModContent.GetInstance<ModConfigsai>().BlockAmount > 1) // if extraction amount set to more than 1
                    {
						if (player.inventory[player.selectedItem].stack >= ModContent.GetInstance<ModConfigsai>().BlockAmount) // if enough blocks in inventory to use mass extract
                        {
							if (Main.mouseLeft) // if mouse pressed
							{
								player.inventory[player.selectedItem].stack -= (int)ModContent.GetInstance<ModConfigsai>().BlockAmount - 1;


								List<int> ItemList = new List<int>();
								List<int> AmountList = new List<int>();


								for (int i = 0; i < ModContent.GetInstance<ModConfigsai>().BlockAmount - 1; i++)
                                {


									int resultItem = -1;
									int resultStack = 1;
									extUse(item.type, ref resultItem, ref resultStack);

                                    if (!ItemList.Contains(resultItem))
                                    {
										ItemList.Append(resultItem);
										AmountList.Append(resultStack);

										Main.NewText("appended " + resultItem.ToString() + " " + resultStack.ToString());

                                    }
                                    else
                                    {
										int index = ItemList.IndexOf(resultItem);
										Main.NewText("added to " + ItemList[index].ToString() + " from: " + AmountList[index].ToString() + " to: " + (AmountList[index] + resultStack).ToString());
										AmountList[index] += resultStack;
										Main.NewText(AmountList[index]);
										

									}


									//int resultItem = -1;
									//int resultStack = 1;
									//extUse(item.type, ref resultItem, ref resultStack);
									//int number = Item.NewItem(null, tileX * 16, tileY * 16, 32, 32, resultItem, Stack: resultStack);

									//if(Main.netMode == NetmodeID.MultiplayerClient)
									//                           {
									//	NetMessage.SendData(MessageID.SyncItem, -1, -1, null, number, 1f);
									//}
								}
								return base.UseItem(item, player);
							}
						}
                    }
                }
            }
            return base.UseItem(item, player);
        }
        public override float UseSpeedMultiplier(Item item, Player player)
        {
			Vector2 mousePosition = Main.MouseWorld;
			int tileX = (int)(mousePosition.X / 16f);
			int tileY = (int)(mousePosition.Y / 16f);
			Tile cursorTile = Main.tile[tileX, tileY];

			if (cursorTile.TileType == TileID.Extractinator && player.cursorItemIconEnabled)
			{
				return base.UseSpeedMultiplier(item, player) * ModContent.GetInstance<ModConfigsai>().ExSpeeed;
			}
			return base.UseSpeedMultiplier(item, player);
		}
	}
}
