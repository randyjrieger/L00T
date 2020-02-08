using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LootClasses;

namespace L00t_Tester
{
    public partial class Form1 : Form
    {
        List<card> playdeck = new List<card>();
        List<card> discard = new List<card>();
        //List<player> players = null;
        List<loot> lootPile = new List<loot>();
        List<monster> Monsters = new List<monster>();
        List<card> lootDeck = new List<card>();

        private int cardID = 0;
        private int numberOfLootCards = 14;
        private int numberOfAttackCards = 6;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSetUpGame_Click(object sender, EventArgs e)
        {
            SetUpGame();
            btnDrawCard.Text = "DRAW CARD";
            btnDrawCard.Visible = true;
            btnDrawCard.Enabled = true;
            btnShuffleDeck.Enabled = false;
            btnEndTurn.Visible = true;
            btnEndTurn.Enabled = true;

            btnDrawCard2.Visible = true;
            btnDrawCard2.Enabled = true;
            btnEndTurn2.Visible = true;
            btnEndTurn2.Enabled = true;
        }

        public void SetUpGame()
        {
            player playerX;
            btnSetUpGame.Text = "Please Wait...";
            btnSetUpGame.Enabled = false;
            
            CreateMonsters();           
            CreatePlayDeck();
            CreateLootDeck();
            
            for (int x = 1; x <=4; x++)
            {
                playerX = new player();
                playerX.id = x;
                playerX.classType = (ClassName)x;
                playerX.hand = GenerateHand((ClassName)x);
                GameManager.Players.Add(playerX);
            }
            
            ShuffleDeck(playdeck);
            refreshDeckList();

            btnSetUpGame.Text = "Game On!";

            btnSetUpGame.Visible = false;
            btnDrawCard.Visible = true;
            btnDrawCard.Enabled = true; ;
            btnDrawCard2.Visible = true;
            btnDrawCard2.Enabled = true;

            btnDrawLoot.Visible = false;
            btnDrawLoot.Enabled = false;

            btnEndTurn.Visible = false;
            btnEndTurn.Enabled = false;
            btnEndTurn2.Visible = false;
            btnEndTurn2.Enabled = false;

            GameManager.CurrentPlayerID = 1;
            GameManager.CurrentPlayer = GameManager.Players[0];
        }

        public void CreateMonsters()        
        {
            Random roll = new Random();
            for (int x = 1; x <= 10; x++)
            {
                Monsters.Add(new monster(roll.Next(1,5)));
            }
        }

        public void CreateLootDeck()
        {
            lootDeck = new List<card>();
           
            for (int x = 1; x <= numberOfLootCards; x++)
            {
                lootPile.Add(new loot(x));
            }

            foreach (loot bling in lootPile)
            {
                lootDeck.Add(new card
                {
                    ID = ++cardID,
                    Title = "LOOT",
                    Description = String.Format("Your discover {0} worth {1} points!", bling.Description, bling.Worth.ToString())
                });
            }
        }

        public void CreatePlayDeck()
        {
            //MONSTER ENCOUNTER ARDS
            foreach (monster beasty in Monsters)
            {
                playdeck.Add(new card
                {
                    ID = ++cardID,
                    Title = beasty.Name,
                    Description = String.Format("You are confronted by a {0}", beasty.Type.ToString()),
                    Type = cardType.monster
                });

            }

            //ATTACK CARD
            for (int x = 1; x <= numberOfAttackCards; x++)
            {
                playdeck.Add(new card
                {
                    ID = ++cardID,
                    Title = "ATTACK",
                    Description = "Use this card to attack and destroy a Monster card in play.",
                    Type = cardType.attack
                });
            }

            //HIDDEN TREASURE
            for (int x = 1; x <= 4; x++)
            {
                playdeck.Add(new card
                {
                    ID = ++cardID,
                    Title = "HIDDEN TREASURE",
                    Description = "You have uncovered hidden treasure! Take the top card from the Loot pile.",
                    Type = cardType.treasure
                });
            }

            //WHAT'S YOURS IS MINE
            for (int x = 1; x <= 2; x++)
            {
                playdeck.Add(new card
                {
                    ID = ++cardID,
                    Title = "WHAT'S YOURS IS MINE",
                    Description = "One of your rivals has left some loot unattended. You can take a random loot card from any player. This must be used immediately.",
                    Type = cardType.yoursismine
                });
            }

            //TRIP
            for (int x = 1; x <= 2; x++)
            {
                playdeck.Add(new card
                {
                    ID = ++cardID,
                    Title = "HAVE A NICE TRIP?",
                    Description = "Your eyes just don't seem adjusted to the darkness of this passage. Shuffle the Play Deck.",
                    Type = cardType.trip
                });
            }

            //THE OLD twistoffate
            playdeck.Add(new card
            {
                ID = ++cardID,
                Title = "TWIST OF FATE",
                Description = "The Gods are being either kind or cruel. Either way, your hand has been switched with another players.",
                Type = cardType.twistoffate
            });
        }

        public void refreshDeckList()
        {
            lvPlayDeck.Items.Clear();
            
            foreach (card c in playdeck)
            {
                lvPlayDeck.Items.Add(new ListViewItem(new string[] { c.Title, c.ID.ToString() }));
            }

            lvLootDeck.Items.Clear();

            foreach (card c in lootDeck)
            {
                lvLootDeck.Items.Add(new ListViewItem(new string[] { c.Title, c.ID.ToString() }));
            }

            lvCleric.Items.Clear();
            lvWarrior.Items.Clear();
            lvWizard.Items.Clear();
            lvThief.Items.Clear();

            foreach (player p in GameManager.Players)
            {
                foreach (card c in p.hand)
                {
                    if (p.classType == ClassName.cleric)
                    {
                        lvCleric.Items.Add(new ListViewItem(new string[] { c.Title, c.ID.ToString() }));
                    }
                    else if (p.classType == ClassName.thief)
                    {
                        lvThief.Items.Add(new ListViewItem(new string[] { c.Title, c.ID.ToString() }));
                    }
                    else if (p.classType == ClassName.warrior)
                    {
                        lvWarrior.Items.Add(new ListViewItem(new string[] { c.Title, c.ID.ToString() }));
                    }
                    else if (p.classType == ClassName.wizard)
                    {
                        lvWizard.Items.Add(new ListViewItem(new string[] {c.Title, c.ID.ToString() }));
                    }

                }
            }

            if (GameManager.CurrentPlayerID == 1)
            {
                lvWizard.Enabled = true;
                lvWarrior.Enabled = false;
                lvThief.Enabled = false;
                lvCleric.Enabled = false;
            }
            else if (GameManager.CurrentPlayerID == 2)
            {
                lvWizard.Enabled = false;
                lvWarrior.Enabled = true;
                lvThief.Enabled = false;
                lvCleric.Enabled = false;

            }
            else if (GameManager.CurrentPlayerID == 3)
            {
                lvWizard.Enabled = false;
                lvWarrior.Enabled = false;
                lvThief.Enabled = true;
                lvCleric.Enabled = false;

            }
            else if (GameManager.CurrentPlayerID == 4)
            {
                lvWizard.Enabled = false;
                lvWarrior.Enabled = false;
                lvThief.Enabled = false;
                lvCleric.Enabled = true;

            }
        }

        public List<card> GenerateHand(ClassName classType)
        {
            List<card> newHand = new List<card>();

            if (classType == ClassName.cleric)
            {
                //newHand.Add(new card
                //{
                //    Title = "CLERIC",
                //    Description = "",
                //    AssociatedClass = ClassName.cleric
                //});

                newHand.Add(new card
                {
                    Title = "Protect From Evil",
                    Description = "",
                    AssociatedClass = ClassName.cleric
                });

                newHand.Add(new card
                {
                    Title = "Summon Undead",
                    Description = "",
                    AssociatedClass = ClassName.cleric
                });
            }

            else if (classType == ClassName.wizard)
            {
                //newHand.Add(new card
                //{
                //    Title = "WIZARD",
                //    Description = "",
                //    AssociatedClass = ClassName.cleric
                //});

                newHand.Add(new card
                {
                    Title = "Magic Missile",
                    Description = "",
                    AssociatedClass = ClassName.wizard
                });

                newHand.Add(new card
                {
                    Title = "Invisibility",
                    Description = "",
                    AssociatedClass = ClassName.wizard
                });
            }

            else if (classType == ClassName.warrior)
            {
                //newHand.Add(new card
                //{
                //    Title = "WARRIOR",
                //    Description = "",
                //    AssociatedClass = ClassName.cleric
                //});

                newHand.Add(new card
                {
                    Title = "Dodge",
                    Description = "",
                    AssociatedClass = ClassName.warrior
                });

                newHand.Add(new card
                {
                    Title = "Haste",
                    Description = "",
                    AssociatedClass = ClassName.warrior
                });
            }

            else if (classType == ClassName.thief)
            {
                //newHand.Add(new card
                //{
                //    Title = "THIEF",
                //    Description = "",
                //    AssociatedClass = ClassName.cleric
                //});

                newHand.Add(new card
                {
                    Title = "Backstab",
                    Description = "",
                    AssociatedClass = ClassName.thief
                });

                newHand.Add(new card
                {
                    Title = "Pick Pocket",
                    Description = "",
                    AssociatedClass = ClassName.thief
                });
            }
            
            return newHand;
        }

        public void ShuffleDeck<T>(IList<T> deck)
        {
            Random rng = new Random();

            int n = deck.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = deck[k];
                deck[k] = deck[n];
                deck[n] = value;
            }


        }

        private void btnDrawCard_Click(object sender, EventArgs e)
        {
            DrawCard();
        }
        private void btnDrawLoot_Click(object sender, EventArgs e)
        {
            DrawLoot();
        }

        private void DrawLoot()
        {
            int cardsLeft = lootDeck.Count;
            card newCard = null;
            loot newLoot = null;

            if (cardsLeft >= 1)
            {
                newLoot = lootPile[cardsLeft - 1];
               // newCard = lootDeck[cardsLeft - 1];
                txtLootTitle.Text = "LOOT";
                txtLootDescription.Text = newLoot.Description;
                txtLootWorth.Text = newLoot.Worth + " Points";

                GameManager.CurrentPlayer.hoard.Add(newLoot);
                GameManager.CurrentPlayer.Points = GameManager.CurrentPlayer.Points + newLoot.Worth;
                GameManager.CurrentPlayer.lootHand.Add(newCard);
                if (GameManager.CurrentPlayer.Points > GameManager.MaxPointsEarned)
                {
                    GameManager.MaxPointsEarned = GameManager.CurrentPlayer.Points;
                    GameManager.WinningPlayer = GameManager.CurrentPlayer;
                }

                lootDeck.RemoveAt(cardsLeft - 1);
            }
            else
            {
                btnDrawLoot.Text = "No More Loot!";
                btnDrawLoot.Enabled = false;
                btnSetUpGame.Text = "";
            }

            btnEndTurn.Enabled = true;
            btnDrawLoot.Visible = false;
            btnDrawLoot.Enabled = false;
            btnDrawCard.Enabled = false;
            btnEndTurn2.Enabled = true;
            btnDrawCard2.Enabled = false;

            refreshDeckList();
            refreshPoints();
        }

        private void refreshPoints()
        {
            foreach (player p in GameManager.Players)
            {
                if (p.classType == ClassName.wizard)
                {
                    lvWizard.Columns[1].Text = p.Points + " Pts";
                }
                else if (p.classType == ClassName.cleric)
                {
                    lvCleric.Columns[1].Text = p.Points + " Pts";
                }
                else if (p.classType == ClassName.thief)
                {
                    lvThief.Columns[1].Text = p.Points + " Pts";
                }
                else if (p.classType == ClassName.warrior)
                {
                    lvWarrior.Columns[1].Text = p.Points + " Pts";
                }
            }
         
        }

        private void DrawCard()
        {
            int cardsLeft = playdeck.Count;
            card newCard = null;

            btnEndTurn.Enabled = false;
            btnDrawCard.Enabled = false;
            btnEndTurn2.Enabled = false;
            btnDrawCard2.Enabled = false;
            btnDrawLoot.Visible = false;

            if (cardsLeft >= 1)
            {
                newCard = playdeck[cardsLeft - 1];
                txtCardTitle.Text = newCard.Title;
                txtCardDescription.Text = newCard.Description;
                txtCardClass.Text = "";

                GameManager.CurrentCard = newCard;
                GameManager.CurrentPlayer.hand.Add(newCard);
                playdeck.RemoveAt(cardsLeft - 1);

                CheckCard(GameManager.CurrentCard);

            }
            else
            {

                //player p = GameManager.Players.ToList<player>().OrderByDescending(x => x.Points).First();

                // int numberOfWinners = GameManager.Players.ToList<player>(x => x.Points == p.ToString).Count();
//
              //  List<player> listOfWinners = (from p2 in GameManager.Players.ToList<player>() select p2.Points == GameManager.WinningPlayer.Points);
                List<player> listOfWinners;
                listOfWinners = GameManager.Players.ToList<player>().FindAll(x => x.Points == GameManager.WinningPlayer.Points);
                string winners = "";

                if (listOfWinners.Count == 1)
                {
                    winners = listOfWinners[0].classType.ToString();
                }
                
                if (listOfWinners.Count > 1)
                {
                    foreach (player p in listOfWinners)
                    {
                        winners = winners + ", " + p.classType.ToString();
                    }
                }
                StringBuilder winningMessage = new StringBuilder(String.Format("Game Over! The {0} wins with {1} points!", winners, GameManager.MaxPointsEarned));
               
                MessageBox.Show(winningMessage.ToString());
                                
                btnSetUpGame.Text = "Play Again?";
                ResetBoard();
            }


            refreshDeckList();
        }

        private void ResetBoard()
        {
            btnSetUpGame.Visible = true;
            btnDrawCard.Visible = false;
            btnDrawCard.Enabled = false;
            btnDrawCard2.Visible = false;
            btnDrawCard2.Enabled = false;

            btnDrawLoot.Visible = false;
            btnDrawLoot.Enabled = false;

            btnEndTurn.Visible = false;
            btnEndTurn.Enabled = false;
            btnEndTurn2.Visible = false;
            btnEndTurn2.Enabled = false;
        }
        private void CheckCard(card newCard)
        {
            Random roll;

            if (newCard.Type == cardType.treasure)
            {
                btnEndTurn.Enabled = false;
                btnDrawCard.Enabled = false;
                btnDrawLoot.Visible = true;
                btnDrawLoot.Enabled = true;
            }
            else if (newCard.Type == cardType.yoursismine)
            {
                bool EligiblePlayers = false;

                if (!GameManager.WaitingToSelectCharacter)
                {
                    Color waitToSelectColor = Color.MistyRose;
                    Color oldColor = lvWizard.ForeColor;

                    foreach (player p in GameManager.Players)
                    {
                        if (p != GameManager.CurrentPlayer)
                        {
                            if (p.lootHand.Count > 0)
                            {
                                if (p.classType == ClassName.cleric)
                                    lvCleric.ForeColor = waitToSelectColor;
                                if (p.classType == ClassName.wizard)
                                    lvWizard.ForeColor = waitToSelectColor;
                                if (p.classType == ClassName.warrior)
                                    lvWarrior.ForeColor = waitToSelectColor;
                                if (p.classType == ClassName.thief)
                                    lvThief.ForeColor = waitToSelectColor;
                                EligiblePlayers = true;
                            }
                        }
                    }

                    if (!EligiblePlayers)
                    {
                        btnEndTurn.Enabled = true;
                        btnEndTurn2.Enabled = true;
                        btnDrawLoot.Visible = false;
                        btnDrawLoot.Enabled = false;
                        btnDrawCard.Enabled = false;
                        btnDrawCard2.Enabled = false;
                    }
                    else
                    {
                        GameManager.WaitingToSelectCharacter = true;
                    }

                    GameManager.CurrentCard = newCard;
                }
                
            }
            else if (newCard.Type == cardType.twistoffate)
            {
                List<card> tempHand;
                roll = new Random();

                int x = 0;
                do
                {
                    x = roll.Next(1, 4);
                    x--;
                } while (x != (GameManager.CurrentPlayerID - 1));

                tempHand = GameManager.CurrentPlayer.hand;
                GameManager.CurrentPlayer.hand = GameManager.Players[x].hand;
                GameManager.Players[x].hand = tempHand;

                ClassName playerClass = GameManager.CurrentPlayer.classType;
                ClassName victimClass = GameManager.Players[x].classType;

                lvWarrior.Items.Clear();
                lvWizard.Items.Clear();
                lvThief.Items.Clear();

                ClassName thisClass;
                ListView lv;
                for (int i = 0; i < 4; i++)
                {
                    thisClass = GameManager.Players.Find(p => p.classType == ClassName.cleric).classType;

                    if (thisClass == ClassName.cleric)
                    {
                        lv = lvCleric;
                        foreach (card c in GameManager.Players[i].hand)
                        {
                            lvCleric.Items.Add(new ListViewItem(new string[] { c.Title, c.ID.ToString() }));
                        }
                    }

                }

            
                btnEndTurn.Enabled = true;
                btnEndTurn2.Enabled = true;
                btnDrawLoot.Visible = false;
                btnDrawLoot.Enabled = false;
                btnDrawCard.Enabled = false;
                btnDrawCard2.Enabled = false;
            }
            else if (newCard.Type == cardType.trip)
            {
                btnShuffleDeck.Enabled = true;
                btnEndTurn.Enabled = false;
                btnDrawCard.Enabled = false;
                btnEndTurn2.Enabled = false;
                btnDrawCard2.Enabled = false;
                btnDrawLoot.Visible = false;
                btnDrawLoot.Enabled = false;
            }
            else if (newCard.Type == cardType.monster)
            {
                btnShuffleDeck.Enabled = false;
                btnPlayCard.Visible = true;
                btnPlayCard2.Visible = true;

                btnEndTurn.Enabled = false;
                btnDrawCard.Enabled = false;
                btnEndTurn2.Enabled = false;
                btnDrawCard2.Enabled = false;
                btnDrawLoot.Visible = false;
                btnDrawLoot.Enabled = false;

            }
            else
            {
                btnEndTurn.Enabled = true;
                btnDrawLoot.Visible = false;
                btnDrawLoot.Enabled = false;
                btnDrawCard.Enabled = false;
                btnEndTurn2.Enabled = true;
                btnDrawCard2.Enabled = false;
            }

            /*
             * 
                newCard = playdeck[cardsLeft - 1];
                txtCardTitle.Text = newCard.Title;
                txtCardDescription.Text = newCard.Description;
                txtCardClass.Text = "";

                players[GameManager.CurrentPlayerID - 1].hand.Add(newCard);
                playdeck.RemoveAt(cardsLeft - 1);

             */

        }

        private void btnShuffleDeck_Click(object sender, EventArgs e)
        {
            ShuffleDeck(playdeck);
            refreshDeckList();

            btnShuffleDeck.Enabled = false;
            btnEndTurn.Enabled = true;
            btnDrawCard.Enabled = false;
            btnDrawLoot.Visible = false;
            btnDrawLoot.Enabled = false;
        }

        private void btnPlayCard_Click(object sender, EventArgs e)
        {
            //what player is it and what lv?

            //what card is it and what is current card?
            if (GameManager.CurrentCard.Type == cardType.monster)
            {
                //and this is attack card...

            //and this is special card

            }
           
        }

        private void btnEndTurn_Click(object sender, EventArgs e)
        {
            btnDrawCard.Enabled = true;
            btnEndTurn.Enabled = false;
            btnDrawCard2.Enabled = true;
            btnEndTurn2.Enabled = false;

            txtCardDescription.Text = "";
            txtCardTitle.Text = "";
            txtCardClass.Text = "";

            txtLootDescription.Text = "";
            txtLootTitle.Text = "";
            txtLootWorth.Text = "";

            GameManager.NextPlayer();
            refreshDeckList();

        }

        private void lvPlayDeck_SelectedIndexChanged(object sender, EventArgs e)
        {
           // lvPlayDeck_SelectedIndexChanged.Items.Add(new ListViewItem(new string[] { c.Title, c.ID.ToString() }));

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lvWizard_Click(object sender, EventArgs e)
        {

        }

        private void lvWarrior_Click(object sender, EventArgs e)
        {

        }

        private void lvCleric_Click(object sender, EventArgs e)
        {

        }

        private void lvThief_Click(object sender, EventArgs e)
        {
            //int lootCount = 
            //ListBox source = (ListBox)sender;
            //if (source.BackColor == Color.MistyRose)
            //{
            //    if (GameManager.WaitingToSelectCharacter)
            //    {
            //        if (GameManager.CurrentCard.Type == cardType.yoursismine)
            //        {
            //            //Take Loot 
            //            foreach ()

            //        }
            //    }
            //    //    }
        }
    }
}
