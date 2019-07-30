using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//John Westbrooks

namespace MemoryGame
{
    public partial class Form1 : Form
    {
        PictureBox card1 = null; //cards that will be chosen (2 at a time)
        PictureBox card2 = null;
        bool[] crdsFound = new bool[7] { false, false, false, false, false, false, false };
        int tagVar = 0;

        //When a matching pair is found the appropriate value in 
        // crdsFound array will be set to true. When all seven values
        //are set to true the player wins the game.
    
        


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            intializePictureBoxes(); //set tags when form loads
        }


        private void intializePictureBoxes()
        {

            Random rand = new Random();
            int rndm;
            rndm = rand.Next(1, 17);
            //Random number generated below is used to seed one of
            //sixteen possible game boards via a switch. It gives each pictureBox
            //a tag which will be used used to match with an image resource.

            switch (rndm)
            {
                case 1:
                    pictureBox1.Tag = 1.ToString();
                    pictureBox2.Tag = 2.ToString();
                    pictureBox3.Tag = 3.ToString();
                    pictureBox4.Tag = 4.ToString();
                    pictureBox5.Tag = 5.ToString();
                    pictureBox6.Tag = 6.ToString();
                    pictureBox7.Tag = 7.ToString();
                    pictureBox8.Tag = 1.ToString();
                    pictureBox9.Tag = 4.ToString();
                    pictureBox10.Tag = 3.ToString();
                    pictureBox11.Tag = 2.ToString();
                    pictureBox12.Tag = 6.ToString();
                    pictureBox13.Tag = 7.ToString();
                    pictureBox14.Tag = 5.ToString();
                    break;
                case 2:
                    pictureBox1.Tag = 3.ToString();
                    pictureBox2.Tag = 7.ToString();
                    pictureBox3.Tag = 1.ToString();
                    pictureBox4.Tag = 2.ToString();
                    pictureBox5.Tag = 4.ToString();
                    pictureBox6.Tag = 5.ToString();
                    pictureBox7.Tag = 6.ToString();
                    pictureBox8.Tag = 4.ToString();
                    pictureBox9.Tag = 5.ToString();
                    pictureBox10.Tag = 7.ToString();
                    pictureBox11.Tag = 2.ToString();
                    pictureBox12.Tag = 6.ToString();
                    pictureBox13.Tag = 3.ToString();
                    pictureBox14.Tag = 1.ToString();
                    break;
                case 3:
                    pictureBox1.Tag = 7.ToString();
                    pictureBox2.Tag = 4.ToString();
                    pictureBox3.Tag = 2.ToString();
                    pictureBox4.Tag = 5.ToString();
                    pictureBox5.Tag = 3.ToString();
                    pictureBox6.Tag = 6.ToString();
                    pictureBox7.Tag = 1.ToString();
                    pictureBox8.Tag = 5.ToString();
                    pictureBox9.Tag = 3.ToString();
                    pictureBox10.Tag = 6.ToString();
                    pictureBox11.Tag = 7.ToString();
                    pictureBox12.Tag = 2.ToString();
                    pictureBox13.Tag = 1.ToString();
                    pictureBox14.Tag = 4.ToString();
                    break;
                case 4:
                    pictureBox1.Tag = 6.ToString();
                    pictureBox2.Tag = 2.ToString();
                    pictureBox3.Tag = 5.ToString();
                    pictureBox4.Tag = 4.ToString();
                    pictureBox5.Tag = 1.ToString();
                    pictureBox6.Tag = 7.ToString();
                    pictureBox7.Tag = 3.ToString();
                    pictureBox8.Tag = 3.ToString();
                    pictureBox9.Tag = 2.ToString();
                    pictureBox10.Tag = 1.ToString();
                    pictureBox11.Tag = 7.ToString();
                    pictureBox12.Tag = 6.ToString();
                    pictureBox13.Tag = 5.ToString();
                    pictureBox14.Tag = 4.ToString();
                    break;
                case 5:
                    pictureBox1.Tag = 7.ToString();
                    pictureBox2.Tag = 6.ToString();
                    pictureBox3.Tag = 5.ToString();
                    pictureBox4.Tag = 4.ToString();
                    pictureBox5.Tag = 3.ToString();
                    pictureBox6.Tag = 2.ToString();
                    pictureBox7.Tag = 1.ToString();
                    pictureBox8.Tag = 4.ToString();
                    pictureBox9.Tag = 3.ToString();
                    pictureBox10.Tag = 2.ToString();
                    pictureBox11.Tag = 7.ToString();
                    pictureBox12.Tag = 6.ToString();
                    pictureBox13.Tag = 5.ToString();
                    pictureBox14.Tag = 1.ToString();
                    break;
                case 6:
                    pictureBox1.Tag = 5.ToString();
                    pictureBox2.Tag = 6.ToString();
                    pictureBox3.Tag = 7.ToString();
                    pictureBox4.Tag = 4.ToString();
                    pictureBox5.Tag = 3.ToString();
                    pictureBox6.Tag = 1.ToString();
                    pictureBox7.Tag = 2.ToString();
                    pictureBox8.Tag = 6.ToString();
                    pictureBox9.Tag = 1.ToString();
                    pictureBox10.Tag = 5.ToString();
                    pictureBox11.Tag = 7.ToString();
                    pictureBox12.Tag = 3.ToString();
                    pictureBox13.Tag = 2.ToString();
                    pictureBox14.Tag = 4.ToString();
                    break;
                case 7:
                    pictureBox1.Tag = 6.ToString();
                    pictureBox2.Tag = 7.ToString();
                    pictureBox3.Tag = 1.ToString();
                    pictureBox4.Tag = 2.ToString();
                    pictureBox5.Tag = 4.ToString();
                    pictureBox6.Tag = 5.ToString();
                    pictureBox7.Tag = 3.ToString();
                    pictureBox8.Tag = 1.ToString();
                    pictureBox9.Tag = 2.ToString();
                    pictureBox10.Tag = 7.ToString();
                    pictureBox11.Tag = 6.ToString();
                    pictureBox12.Tag = 4.ToString();
                    pictureBox13.Tag = 3.ToString();
                    pictureBox14.Tag = 5.ToString();
                    break;
                case 8:
                    pictureBox1.Tag = 5.ToString();
                    pictureBox2.Tag = 1.ToString();
                    pictureBox3.Tag = 4.ToString();
                    pictureBox4.Tag = 2.ToString();
                    pictureBox5.Tag = 7.ToString();
                    pictureBox6.Tag = 3.ToString();
                    pictureBox7.Tag = 6.ToString();
                    pictureBox8.Tag = 7.ToString();
                    pictureBox9.Tag = 5.ToString();
                    pictureBox10.Tag = 4.ToString();
                    pictureBox11.Tag = 3.ToString();
                    pictureBox12.Tag = 1.ToString();
                    pictureBox13.Tag = 2.ToString();
                    pictureBox14.Tag = 6.ToString();
                    break;
                case 9:
                    pictureBox1.Tag = 2.ToString();
                    pictureBox2.Tag = 5.ToString();
                    pictureBox3.Tag = 1.ToString();
                    pictureBox4.Tag = 7.ToString();
                    pictureBox5.Tag = 4.ToString();
                    pictureBox6.Tag = 3.ToString();
                    pictureBox7.Tag = 6.ToString();
                    pictureBox8.Tag = 6.ToString();
                    pictureBox9.Tag = 5.ToString();
                    pictureBox10.Tag = 7.ToString();
                    pictureBox11.Tag = 3.ToString();
                    pictureBox12.Tag = 1.ToString();
                    pictureBox13.Tag = 2.ToString();
                    pictureBox14.Tag = 4.ToString();
                    break;
                case 10:
                    pictureBox1.Tag = 4.ToString();
                    pictureBox2.Tag = 1.ToString();
                    pictureBox3.Tag = 5.ToString();
                    pictureBox4.Tag = 2.ToString();
                    pictureBox5.Tag = 6.ToString();
                    pictureBox6.Tag = 3.ToString();
                    pictureBox7.Tag = 7.ToString();
                    pictureBox8.Tag = 1.ToString();
                    pictureBox9.Tag = 4.ToString();
                    pictureBox10.Tag = 7.ToString();
                    pictureBox11.Tag = 2.ToString();
                    pictureBox12.Tag = 6.ToString();
                    pictureBox13.Tag = 3.ToString();
                    pictureBox14.Tag = 5.ToString();
                    break;
                case 11:
                    pictureBox1.Tag = 2.ToString();
                    pictureBox2.Tag = 5.ToString();
                    pictureBox3.Tag = 3.ToString();
                    pictureBox4.Tag = 6.ToString();
                    pictureBox5.Tag = 4.ToString();
                    pictureBox6.Tag = 7.ToString();
                    pictureBox7.Tag = 1.ToString();
                    pictureBox8.Tag = 1.ToString();
                    pictureBox9.Tag = 3.ToString();
                    pictureBox10.Tag = 6.ToString();
                    pictureBox11.Tag = 7.ToString();
                    pictureBox12.Tag = 2.ToString();
                    pictureBox13.Tag = 5.ToString();
                    pictureBox14.Tag = 4.ToString();
                    break;
                case 12:
                    pictureBox1.Tag = 1.ToString();
                    pictureBox2.Tag = 7.ToString();
                    pictureBox3.Tag = 2.ToString();
                    pictureBox4.Tag = 6.ToString();
                    pictureBox5.Tag = 4.ToString();
                    pictureBox6.Tag = 5.ToString();
                    pictureBox7.Tag = 3.ToString();
                    pictureBox8.Tag = 1.ToString();
                    pictureBox9.Tag = 2.ToString();
                    pictureBox10.Tag = 7.ToString();
                    pictureBox11.Tag = 4.ToString();
                    pictureBox12.Tag = 5.ToString();
                    pictureBox13.Tag = 3.ToString();
                    pictureBox14.Tag = 6.ToString();
                    break;
                case 13:
                    pictureBox1.Tag = 6.ToString();
                    pictureBox2.Tag = 7.ToString();
                    pictureBox3.Tag = 2.ToString();
                    pictureBox4.Tag = 1.ToString();
                    pictureBox5.Tag = 5.ToString();
                    pictureBox6.Tag = 4.ToString();
                    pictureBox7.Tag = 3.ToString();
                    pictureBox8.Tag = 7.ToString();
                    pictureBox9.Tag = 2.ToString();
                    pictureBox10.Tag = 4.ToString();
                    pictureBox11.Tag = 5.ToString();
                    pictureBox12.Tag = 6.ToString();
                    pictureBox13.Tag = 1.ToString();
                    pictureBox14.Tag = 3.ToString();
                    break;
                case 14:
                    pictureBox1.Tag = 3.ToString();
                    pictureBox2.Tag = 5.ToString();
                    pictureBox3.Tag = 1.ToString();
                    pictureBox4.Tag = 6.ToString();
                    pictureBox5.Tag = 4.ToString();
                    pictureBox6.Tag = 7.ToString();
                    pictureBox7.Tag = 2.ToString();
                    pictureBox8.Tag = 4.ToString();
                    pictureBox9.Tag = 5.ToString();
                    pictureBox10.Tag = 1.ToString();
                    pictureBox11.Tag = 6.ToString();
                    pictureBox12.Tag = 2.ToString();
                    pictureBox13.Tag = 3.ToString();
                    pictureBox14.Tag = 7.ToString();
                    break;
                case 15:
                    pictureBox1.Tag = 1.ToString();
                    pictureBox2.Tag = 2.ToString();
                    pictureBox3.Tag = 3.ToString();
                    pictureBox4.Tag = 7.ToString();
                    pictureBox5.Tag = 5.ToString();
                    pictureBox6.Tag = 4.ToString();
                    pictureBox7.Tag = 6.ToString();
                    pictureBox8.Tag = 7.ToString();
                    pictureBox9.Tag = 3.ToString();
                    pictureBox10.Tag = 4.ToString();
                    pictureBox11.Tag = 1.ToString();
                    pictureBox12.Tag = 6.ToString();
                    pictureBox13.Tag = 5.ToString();
                    pictureBox14.Tag = 2.ToString();
                    break;
                case 16:
                    pictureBox1.Tag = 5.ToString();
                    pictureBox2.Tag = 6.ToString();
                    pictureBox3.Tag = 7.ToString();
                    pictureBox4.Tag = 3.ToString();
                    pictureBox5.Tag = 4.ToString();
                    pictureBox6.Tag = 2.ToString();
                    pictureBox7.Tag = 1.ToString();
                    pictureBox8.Tag = 6.ToString();
                    pictureBox9.Tag = 7.ToString();
                    pictureBox10.Tag = 1.ToString();
                    pictureBox11.Tag = 4.ToString();
                    pictureBox12.Tag = 3.ToString();
                    pictureBox13.Tag = 2.ToString();
                    pictureBox14.Tag = 5.ToString();
                    break;
            }//end switch
          }//end intializePictureBoxes


        //method to flip cards face down in event of mismatch
        void flipCardDown()
        {
            card1.Image = Properties.Resources.card0; //set images to default
            card2.Image = Properties.Resources.card0;
            card1 = null; //reset cards to null
            card2 = null;
        }

        //method to flip all cards down - called when game is reset
        void flipAllCardsDown()
        {
            //reset images to stock
            pictureBox1.Image = Properties.Resources.card0;
            pictureBox2.Image = Properties.Resources.card0;
            pictureBox3.Image = Properties.Resources.card0;
            pictureBox4.Image = Properties.Resources.card0;
            pictureBox5.Image = Properties.Resources.card0;
            pictureBox6.Image = Properties.Resources.card0;
            pictureBox7.Image = Properties.Resources.card0;
            pictureBox8.Image = Properties.Resources.card0;
            pictureBox9.Image = Properties.Resources.card0;
            pictureBox10.Image = Properties.Resources.card0;
            pictureBox11.Image = Properties.Resources.card0;
            pictureBox12.Image = Properties.Resources.card0;
            pictureBox13.Image = Properties.Resources.card0;
            pictureBox14.Image = Properties.Resources.card0;


        }

        //method to check for a winner
        private bool checkBoard()
        {

            for(int k = 0; k < crdsFound.Length; k++)
            {
                if (crdsFound[k] == false) //if a value is false - there is at 
                    return false;           //at least one unmatched pair
            }

            return true;
        }
        //method to compare to cards
        void compare(PictureBox first, PictureBox second)
        {
            int temp1, temp2; //turn tag into flag, and array subscript
            temp1 = Convert.ToInt32(first.Tag.ToString());
            temp2 = Convert.ToInt32(second.Tag.ToString());

            Application.DoEvents(); //show second card
            System.Threading.Thread.Sleep(1000); //pause execution so player can see card
            if (temp1 == temp2)
            {
               // textBox.Text += " Match found! ";
                card1 = null; //reset cards
                card2 = null; 
                temp1 = temp1 - 1; //convert flag to array subscript
                crdsFound[temp1] = true;
                if (checkBoard()) //checkboard
                {
                    textBox.Text += "YOU WIN! "; //if yes, player has won
                }

            }
            else if (temp1 != temp2)
            {   //don't match - flip cards down
                flipCardDown();
            }
        }

        //method to "flip up" card by matching a flag (tag) to
        //the approrpriate associated image
        void flipCardUp(PictureBox bx)
        {
            tagVar = Convert.ToInt32(bx.Tag);  //grab flag
            //show appropriate image for flag
            if (tagVar == 1)
                bx.Image = Properties.Resources.card1;
            else if (tagVar == 2)
                bx.Image = Properties.Resources.card2;
            else if (tagVar == 3)
                bx.Image = Properties.Resources.card3;
            else if (tagVar == 4)
                bx.Image = Properties.Resources.card4;
            else if (tagVar == 5)
                bx.Image = Properties.Resources.card5;
            else if (tagVar == 6)
                bx.Image = Properties.Resources.card6;
            else if (tagVar == 7)
                bx.Image = Properties.Resources.card7;

            //if two cards are chosen compare them
            if (card2 != null)
                compare(card1, card2);
        }

        //event handler for clicking a card. 
        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox temp = (sender as PictureBox);

            if (card1 == null) //set first card
                card1 = temp;
            else               //or second
                card2 = temp;

            flipCardUp(temp); //show card
        }

        //method to reset the game board
        private void button1_Click(object sender, EventArgs e)
        {
            //reset win condition
            for (int l = 0; l < crdsFound.Length; l++)
                crdsFound[l] = false;

            flipAllCardsDown();      //flip all cards down
            textBox.Clear();         //clear textBox
            intializePictureBoxes(); //shuffle game board
            Application.DoEvents();  //program catches up
        }
    }
}
