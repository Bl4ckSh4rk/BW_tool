/*
 * Created by SharpDevelop.
 * User: suloku
 * Date: 03/03/2016
 * Time: 17:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

/* Data shown in trainer card info
 * 
Times Linked
Link Battles
Link Battle Wins
Link Battle Losses
Link Trades
Wild Pokémon encounters
Trainers Battled
Feeling checks


----Not on trainer records

People passed by
Usable Pass Powers
Musical Performances ? - Appears if not 0
Poké Transfer High Score ? - Appears if not 0
Battle Test High Score ? - Appears if not 0
Cleared Funfest missions
Movie Shoots ? - Appears if not 0
Wins at the PWT
Customers recommended to Join Avenue ? - Appears if not 0
*/

namespace BW_tool
{
	/// <summary>
	/// Description of TrainerRec.
	/// </summary>
	public partial class TrainerRec : Form
	{
		TR trainerrecords;
		public TrainerRec()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			if ( MainForm.save.B2W2)
			{
				trainerrecords =  new TR(MainForm.save.getBlockDec(38));
			}
            else
			{
				trainerrecords =  new TR(MainForm.save.getBlockDec(38));
			}

            //numericUpDown1.Value = (uint)(trainerrecords.LinkBattles + trainerrecords.LinkTrades);
            numericUpDown2.Value = (uint)trainerrecords.LinkBattles;
            numericUpDown3.Value = (uint)trainerrecords.LinkBattleWins;
            numericUpDown4.Value = (uint)trainerrecords.LinkBattleLoses;
            //numericUpDown5.Value = (uint)trainerrecords.LinkTrades;
            numericUpDown6.Value = (uint)trainerrecords.WildEncounters;
            numericUpDown7.Value = (uint)trainerrecords.TrainersBattled;
            //numericUpDown8.Value = (uint)trainerrecords.PeoplePassedBy;
            numericUpDown9.Value = (uint)trainerrecords.FeelingsChecked;
            numericUpDown11.Value = (uint)trainerrecords.MusicalPerformances;
            //numericUpDown12.Value = (uint)trainerrecords.BattleTestHighScore;
            //numericUpDown13.Value = (uint)trainerrecords.PokeTransferHighScore;
            //numericUpDown14.Value = (uint)trainerrecords.ClearedFunfestMissions;
            numericUpDown15.Value = (uint)trainerrecords.MovieShoots;
            //numericUpDown16.Value = (uint)trainerrecords.WinsAtThePWT;
            numericUpDown17.Value = (uint)trainerrecords.CustomersRecommendedToJoinAvenue;
        }

	    public class TR
	    {
		    internal int Size = MainForm.save.B2W2? MainForm.save.getBlockLength(38) : MainForm.save.getBlockLength(38); //Update with BW 1
	
	        public byte[] Data;
	        public TR(byte[] data = null)
	        {
	            Data = data ?? new byte[Size];
	        }
	
	        // General Card Properties
            public uint LinkBattles
            {
                get { return BitConverter.ToUInt32(Data, 0x34); }
                set { BitConverter.GetBytes((uint)value).CopyTo(Data, 0x34); }
            }
            public UInt16 LinkBattleWins
            {
                get { return BitConverter.ToUInt16(Data, 0x48); }
                set { BitConverter.GetBytes((UInt16)value).CopyTo(Data, 0x48); }
            }
            public UInt16 LinkBattleLoses
            {
                get { return BitConverter.ToUInt16(Data, 0x4C); }
                set { BitConverter.GetBytes((UInt16)value).CopyTo(Data, 0x4C); }
            }
            public uint LinkTrades
            {
                get { return BitConverter.ToUInt32(Data, 0x40); }
                set { BitConverter.GetBytes((uint)value).CopyTo(Data, 0x40); }
            }
            public uint WildEncounters
            {
                get { return BitConverter.ToUInt32(Data, 0x14); }
                set { BitConverter.GetBytes((uint)value).CopyTo(Data, 0x14); }
            }
            public uint TrainersBattled
            {
                get { return BitConverter.ToUInt32(Data, 0x18); }
                set { BitConverter.GetBytes((uint)value).CopyTo(Data, 0x18); }
            }
            public uint PeoplePassedBy
            {
                get { return BitConverter.ToUInt32(Data, 0); }
                set { BitConverter.GetBytes((uint)value).CopyTo(Data, 0); }
            }
            public UInt16 FeelingsChecked {
	            get { return BitConverter.ToUInt16(Data, 0x170); }
	            set { BitConverter.GetBytes((UInt16)value).CopyTo(Data, 0x170); }
            }
	        public UInt16 MusicalPerformances
            {
                get { return BitConverter.ToUInt16(Data, 0x172); }
                set { BitConverter.GetBytes((UInt16)value).CopyTo(Data, 0x172); }
            }
	        public UInt16 BattleTestHighScore {
	            get { return BitConverter.ToUInt16(Data, 0x186); }
	            set { BitConverter.GetBytes((UInt16)value).CopyTo(Data, 0x186); }
            }
            public UInt16 PokeTransferHighScore
            {
                get { return BitConverter.ToUInt16(Data, 0); }
                set { BitConverter.GetBytes((UInt16)value).CopyTo(Data, 0); }
            }
            public uint ClearedFunfestMissions // allready in PKHeX (see Entralink Editor > Completed)
            {
                get { return BitConverter.ToUInt32(Data, 0); }
                set { BitConverter.GetBytes((uint)value).CopyTo(Data, 0); }
            }
            public UInt16 MovieShoots {
	            get { return BitConverter.ToUInt16(Data, 0x194); }
	            set { BitConverter.GetBytes((UInt16)value).CopyTo(Data, 0x194); }
            }
            public UInt16 WinsAtThePWT
            {
                get { return BitConverter.ToUInt16(Data, 0); }
                set { BitConverter.GetBytes((UInt16)value).CopyTo(Data, 0); }
            }
            public UInt16 CustomersRecommendedToJoinAvenue {
	            get { return BitConverter.ToUInt16(Data, 0x18C); }
	            set { BitConverter.GetBytes((UInt16)value).CopyTo(Data, 0x18C); }
            }
	    }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Value = numericUpDown2.Value + numericUpDown5.Value;
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Value = numericUpDown2.Value + numericUpDown5.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            trainerrecords.LinkBattles = (uint)numericUpDown2.Value;
            trainerrecords.LinkBattleWins = (ushort)numericUpDown3.Value;
            trainerrecords.LinkBattleLoses = (ushort)numericUpDown4.Value;
            //trainerrecords.LinkTrades = (uint)numericUpDown5.Value;
            trainerrecords.WildEncounters = (uint)numericUpDown6.Value;
            trainerrecords.TrainersBattled = (uint)numericUpDown7.Value;
            //trainerrecords.PeoplePassedBy = (uint)numericUpDown8.Value;
            trainerrecords.FeelingsChecked = (ushort)numericUpDown9.Value;
            trainerrecords.MusicalPerformances = (ushort)numericUpDown11.Value;
            //trainerrecords.BattleTestHighScore = (ushort)numericUpDown12.Value;
            //trainerrecords.PokeTransferHighScore = (uint)numericUpDown13.Value;
            trainerrecords.MovieShoots = (ushort)numericUpDown15.Value;
            //trainerrecords.WinsAtThePWT = (uint)numericUpDown16.Value;
            trainerrecords.CustomersRecommendedToJoinAvenue = (ushort)numericUpDown17.Value;

            MainForm.save.setBlockCrypt(trainerrecords.Data, 38);
            this.Close();
        }
    }
}
