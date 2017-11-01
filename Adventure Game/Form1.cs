using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Adventure_Game
{
    public partial class mainDisplay : Form
    {
        int scene = 1;

        Random ranGen = new Random();

        public mainDisplay()
        {

            InitializeComponent();

            outputDisplay.Text = "You found an ancient mysterious book in the library. Would you like to open it?";
            optionOne.Text = "Yes";
            optionTwo.Text = "No";
            optionThree.Text = "";
            imageDisplay.Image = Adventure_Game.Properties.Resources.ancient_book;
        }

        private void mainDisplay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R)       //red button press
            {
                if (scene == 1) { scene = 2; }
                else if (scene == 2) { scene = 4; }
                else if (scene == 4) { scene = 5; }
                else if (scene == 5) { scene = 8; }
                else if (scene == 8) { scene = 9; }
                else if (scene == 9) { scene = 16; }
                else if (scene == 16) { scene = 20; }
                else if (scene == 20) { scene = 27; }

                if (scene == 1) { scene = 2; }
                else if (scene == 2) { scene = 6; }
                else if (scene == 6) { scene = 7; }
                else if (scene == 7) { scene = 11; }
                else if (scene == 11) { scene = 12; }
                else if (scene == 12) { scene = 13; }
                else if (scene == 13) { scene = 14; }
                else if (scene == 14) { scene = 22; }

                if (scene == 1) { scene = 2; }
                else if (scene == 2) { scene = 6; }
                else if (scene == 6) { scene = 7; }
                else if (scene == 7) { scene = 11; }
                else if (scene == 11) { scene = 12; }
                else if (scene == 12) { scene = 13; }
                else if (scene == 13) { scene = 14; }
                else if (scene == 14) { scene = 23; }

                if (scene == 1) { scene = 2; }
                else if (scene == 2) { scene = 6; }
                else if (scene == 6) { scene = 7; }
                else if (scene == 7) { scene = 11; }
                else if (scene == 11) { scene = 12; }
                else if (scene == 12) { scene = 13; }
                else if (scene == 13) { scene = 14; }
                else if (scene == 14) { scene = 24; }

                if (scene == 1) { scene = 2; }
                else if (scene == 2) { scene = 6; }
                else if (scene == 6) { scene = 7; }
                else if (scene == 7) { scene = 11; }
                else if (scene == 11) { scene = 12; }
                else if (scene == 12) { scene = 13; }
                else if (scene == 13) { scene = 14; }
                else if (scene == 14) { scene = 25; }

                if (scene == 1) { scene = 2; }
                else if (scene == 2) { scene = 6; }
                else if (scene == 6) { scene = 7; }
                else if (scene == 7) { scene = 15; }
                else if (scene == 15) { scene = 14; }
                else if (scene == 14) { scene = 18; }

                if (scene == 1) { scene = 2; }
                else if (scene == 2) { scene = 6; }
                else if (scene == 6) { scene = 7; }
                else if (scene == 7) { scene = 15; }
                else if (scene == 15) { scene = 14; }
                else if (scene == 14) { scene = 23; }

            }

            if (e.KeyCode == Keys.B)       //blue button press
            {

                if (scene == 1) { scene = 3; }

                if (scene == 1) { scene = 2; }
                else if (scene == 2) { scene = 4; }
                else if (scene == 4) { scene = 5; }
                else if (scene == 5) { scene = 10; }

                if (scene == 1) { scene = 2; }
                else if (scene == 2) { scene = 6; }
                else if (scene == 6) { scene = 7; }
                else if (scene == 7) { scene = 15; }
                else if (scene == 15) { scene = 14; }
                else if (scene == 14) { scene = 25; }

                if (scene == 1) { scene = 2; }
                else if (scene == 2) { scene = 6; }
                else if (scene == 6) { scene = 7; }
                else if (scene == 7) { scene = 15; }
                else if (scene == 15) { scene = 14; }
                else if (scene == 14) { scene = 24; }

                if (scene == 1) { scene = 2; }
                else if (scene == 2) { scene = 6; }
                else if (scene == 6) { scene = 7; }
                else if (scene == 7) { scene = 11; }
                else if (scene == 11) { scene = 12; }
                else if (scene == 12) { scene = 13; }
                else if (scene == 13) { scene = 14; }
                else if (scene == 14) { scene = 18; }

                if (scene == 1) { scene = 2; }
                else if (scene == 2) { scene = 4; }
                else if (scene == 4) { scene = 5; }
                else if (scene == 5) { scene = 8; }
                else if (scene == 8) { scene = 9; }
                else if (scene == 9) { scene = 16; }
                else if (scene == 16) { scene = 19; }

                if (scene == 1) { scene = 2; }
                else if (scene == 2) { scene = 4; }
                else if (scene == 4) { scene = 5; }
                else if (scene == 5) { scene = 8; }
                else if (scene == 8) { scene = 9; }
                else if (scene == 9) { scene = 16; }
                else if (scene == 16) { scene = 20; }
                else if (scene == 20) { scene = 26; }

                if (scene == 1) { scene = 2; }
                else if (scene == 2) { scene = 4; }
                else if (scene == 4) { scene = 5; }
                else if (scene == 5) { scene = 8; }
                else if (scene == 8) { scene = 9; }
                else if (scene == 9) { scene = 17; }

            }
            if (e.KeyCode == Keys.E)       //Green button press
            {
                if (scene == 1) { scene = 2; }
                else if (scene == 2) { scene = 4; }
                else if (scene == 4) { scene = 5; }
                else if (scene == 5) { scene = 10; }

                if (scene == 1) { scene = 2; }
                else if (scene == 2) { scene = 4; }
                else if (scene == 4) { scene = 5; }
                else if (scene == 5) { scene = 8; }
                else if (scene == 8) { scene = 9; }
                else if (scene == 9) { scene = 16; }
                else if (scene == 16) { scene = 20; }
                else if (scene == 20) { scene = 27; }

                if (scene == 1) { scene = 2; }
                else if (scene == 2) { scene = 6; }
                else if (scene == 6) { scene = 7; }
                else if (scene == 7) { scene = 15; }
                else if (scene == 15) { scene = 14; }
                else if (scene == 14) { scene = 25; }

                if (scene == 1) { scene = 2; }
                else if (scene == 2) { scene = 6; }
                else if (scene == 6) { scene = 7; }
                else if (scene == 7) { scene = 15; }
                else if (scene == 15) { scene = 14; }
                else if (scene == 14) { scene = 24; }

                if (scene == 1) { scene = 2; }
                else if (scene == 2) { scene = 6; }
                else if (scene == 6) { scene = 7; }
                else if (scene == 7) { scene = 11; }
                else if (scene == 11) { scene = 12; }
                else if (scene == 12) { scene = 13; }
                else if (scene == 13) { scene = 14; }
                else if (scene == 14) { scene = 18; }

                if (scene == 1) { scene = 2; }
                else if (scene == 2) { scene = 6; }
                else if (scene == 6) { scene = 7; }
                else if (scene == 7) { scene = 11; }
                else if (scene == 11) { scene = 12; }
                else if (scene == 12) { scene = 13; }
                else if (scene == 13) { scene = 14; }
                else if (scene == 14) { scene = 22; }

                if (scene == 1) { scene = 2; }
                else if (scene == 2) { scene = 6; }
                else if (scene == 6) { scene = 7; }
                else if (scene == 7) { scene = 11; }
                else if (scene == 11) { scene = 12; }
                else if (scene == 12) { scene = 13; }
                else if (scene == 13) { scene = 14; }
                else if (scene == 14) { scene = 23; }

                if (scene == 1) { scene = 2; }
                else if (scene == 2) { scene = 6; }
                else if (scene == 6) { scene = 7; }
                else if (scene == 7) { scene = 11; }
                else if (scene == 11) { scene = 12; }
                else if (scene == 12) { scene = 13; }
                else if (scene == 13) { scene = 14; }
                else if (scene == 14) { scene = 24; }

                if (scene == 1) { scene = 2; }
                else if (scene == 2) { scene = 6; }
                else if (scene == 6) { scene = 7; }
                else if (scene == 7) { scene = 11; }
                else if (scene == 11) { scene = 12; }
                else if (scene == 12) { scene = 13; }
                else if (scene == 13) { scene = 14; }
                else if (scene == 14) { scene = 25; }

                if (scene == 1) { scene = 2; }
                else if (scene == 2) { scene = 6; }
                else if (scene == 6) { scene = 7; }
                else if (scene == 7) { scene = 15; }
                else if (scene == 15) { scene = 14; }
                else if (scene == 14) { scene = 18; }

                if (scene == 1) { scene = 2; }
                else if (scene == 2) { scene = 6; }
                else if (scene == 6) { scene = 7; }
                else if (scene == 7) { scene = 15; }
                else if (scene == 15) { scene = 14; }
                else if (scene == 14) { scene = 23; }

                if (scene == 1) { scene = 2; }
                else if (scene == 2) { scene = 4; }
                else if (scene == 4) { scene = 5; }
                else if (scene == 5) { scene = 8; }
                else if (scene == 8) { scene = 9; }
                else if (scene == 9) { scene = 16; }
                else if (scene == 16) { scene = 21; }
                else if (scene == 21) { scene = 28; }

                if (scene == 1) { scene = 2; }
                else if (scene == 2) { scene = 4; }
                else if (scene == 4) { scene = 5; }
                else if (scene == 5) { scene = 8; }
                else if (scene == 8) { scene = 9; }
                else if (scene == 9) { scene = 16; }
                else if (scene == 16) { scene = 21; }
                else if (scene == 21) { scene = 29; }

                if (scene == 1) { scene = 2; }
                else if (scene == 2) { scene = 6; }
                else if (scene == 6) { scene = 7; }
                else if (scene == 7) { scene = 15; }
                else if (scene == 15) { scene = 14; }
                else if (scene == 14) { scene = 22; }
            }

            switch (scene)
            {
                case 1:  //start scene  
                    outputDisplay.Text = "You found an ancient mysterious book " +
                        "in the library. Would you like to open it?";
                    optionOne.Text = "Yes";
                    optionTwo.Text = "No";
                    optionThree.Text = "";
                    imageDisplay.Image = Adventure_Game.Properties.Resources.ancient_book;
                    break;

                case 2:
                    outputDisplay.Text = "You fell through space and entered the ancient time. " +
                        "You woke up with a bad headache in a strange room. Do you want to head out?";
                    optionOne.Text = "Yes";
                    optionTwo.Text = "No";
                    optionThree.Text = "";
                    imageDisplay.Image = Adventure_Game.Properties.Resources.scene_2;
                    break;

                case 3:
                    outputDisplay.Text = "You went home but the curiosity is killing you. " +
                        "Would you like to start over?";
                    optionOne.Text = "Yes";
                    optionTwo.Text = "No";
                    optionThree.Text = "";
                    imageDisplay.Image = Adventure_Game.Properties.Resources._112450_clouds_computer_Everlasting_Summer_TV_ArseniXC_748x421;
                    break;

                case 4:
                    outputDisplay.Text = "You pushed open the creaking door and a girl " +
                        "claimed to be your family servant greeted you politely.";
                    optionOne.Text = "Continue";
                    optionTwo.Text = "";
                    optionThree.Text = "";
                    imageDisplay.Image = Adventure_Game.Properties.Resources.scene_4_alternnative;
                    break;

                case 5:
                    outputDisplay.Text = "Would you like to ask about your identity in this world?";
                    optionOne.Text = "Yes";
                    optionTwo.Text = "No";
                    optionThree.Text = "Maybe";
                    imageDisplay.Image = Adventure_Game.Properties.Resources.scene_4_alternnative;
                    break;

                case 6:
                    outputDisplay.Text = "You explored the odd looking objects in the room.";
                    optionOne.Text = "";
                    optionTwo.Text = "Continue";
                    optionThree.Text = "";
                    imageDisplay.Image = Adventure_Game.Properties.Resources.scene_6;
                    break;

                case 7:
                    outputDisplay.Text = "Then, you come across a beautiful " +
                        "wooden box, would you like to open it?";
                    optionOne.Text = "Yes";
                    optionTwo.Text = "No";
                    optionThree.Text = "Maybe";
                    imageDisplay.Image = Adventure_Game.Properties.Resources.scene_7;
                    break;

                case 8:
                    outputDisplay.Text = "She told you that you are the daughter of the richest household " +
                        "around the area. Your heartless father married you off to the" +
                        " king to strengthen your family's relationship with the royal family. " +
                        "You were supposed to be married off today if you had not fainted.";
                    optionOne.Text = "Continue";
                    optionTwo.Text = "";
                    optionThree.Text = "";
                    imageDisplay.Image = Adventure_Game.Properties.Resources.scene_4_alternnative;
                    Thread.Sleep(2000);
                    imageDisplay.Image = Adventure_Game.Properties.Resources.scene_8;
                    break;

                case 9:
                    outputDisplay.Text = "Nightfall.You are not allowed to leave your " +
                        "family house until tomorrow's marriage. What do you do?";
                    optionOne.Text = "Escape in the middle of the night";
                    optionTwo.Text = "Stay put until morning";
                    optionThree.Text = "";
                    imageDisplay.Image = Adventure_Game.Properties.Resources.scene_2;
                    break;

                case 10:
                    outputDisplay.Text = "You greeted back, however, you did not ask her any questions. " +
                        "The next day, you were put in a fancy carriage and married off to the king." +
                        " Your goals in life were unfulfilled and" +
                        " you ended up living your whole life in the palace, " +
                        "unable to escape your dreadful fate.";
                    imageDisplay.Image = Adventure_Game.Properties.Resources.scene_10;
                    Thread.Sleep(5000);
                    outputDisplay.Text = "Would you like to try again?";
                    optionOne.Text = "Yes";
                    optionTwo.Text = "No";
                    optionThree.Text = "";
                    break;
                case 11:
                    outputDisplay.Text = "You found an old fashioned wedding attire within" +
                        " and you tried it on out of curiosity.";
                    optionOne.Text = "Continue";
                    optionTwo.Text = "";
                    optionThree.Text = "";
                    imageDisplay.Image = Adventure_Game.Properties.Resources.scene_11;
                    break;
                case 12:
                    outputDisplay.Text = "After you tried on the attire," +
                        " someone knocked on the door. You went to answer it. " +
                        "A  girl claimed to be one of  your family servants greeted you. ";
                    optionOne.Text = "Continue";
                    optionTwo.Text = "";
                    optionThree.Text = "";
                    imageDisplay.Image = Adventure_Game.Properties.Resources.scene_4;
                    break;
                case 13:
                    outputDisplay.Text = "She ignored your appearance and explained that she" +
                        " is here to help you get ready for tomorrow's wedding. " +
                        "You asked her to clarify as you are very confused.";
                    optionOne.Text = "Continue";
                    optionTwo.Text = "";
                    optionThree.Text = "";
                    imageDisplay.Image = Adventure_Game.Properties.Resources.scene_4;
                    break;
                case 14:
                    outputDisplay.Text = "She did not answer your question and instructed you specifically" +
                        " to not leave your family house as your father would be furious if you did. " +
                        "You did not get a good feeling from this. Would you like to escape?";
                    optionOne.Text = "Yes";
                    optionTwo.Text = "No";
                    optionThree.Text = "";
                    imageDisplay.Image = Adventure_Game.Properties.Resources.scene_4;
                    Thread.Sleep(1000);
                    imageDisplay.BackColor = Color.Black;
                    break;
                case 15:
                    outputDisplay.Text = "A girl knocked and came into the room, claiming to be your family " +
                        "servant. You asked her about yourself and this place.";
                    optionOne.Text = "Continue";
                    optionTwo.Text = "";
                    optionThree.Text = "";
                    imageDisplay.Image = Adventure_Game.Properties.Resources.scene_4;
                    break;
                case 16:
                    outputDisplay.Text = "How would you like to escape?";
                    optionOne.Text = "Escape through the front doors of your family house";
                    optionTwo.Text = "Escape through the window";
                    optionThree.Text = "Request for your servant's help";
                    imageDisplay.Image = Adventure_Game.Properties.Resources.scene_16;
                    break;
                case 17:
                    outputDisplay.Text = "You ended up becoming one of the king's three thousand wives." +
                        " You were given infinite amount of precious jewels and expensive silk" +
                        " except you died a lonely death. ";
                    Thread.Sleep(5000);
                    outputDisplay.Text = "Would you like to start over?";
                    optionOne.Text = "Yes";
                    optionTwo.Text = "No";
                    optionThree.Text = "";
                    imageDisplay.Image = Adventure_Game.Properties.Resources.scene_17;
                    break;
                case 18:
                    outputDisplay.Text = "Your father married you off to the palace the next day, " +
                        "leaving you confused and devastated for the rest of your life. " +
                        "You regretted the decision you made to not escape.";
                    imageDisplay.Image = Adventure_Game.Properties.Resources.scene_18;
                    Thread.Sleep(5000);
                    outputDisplay.Text = "Would you like to start over?";
                    optionOne.Text = "Yes";
                    optionTwo.Text = "No";
                    optionThree.Text = "";
                    imageDisplay.BackColor = Color.Black;
                    break;
                case 19:
                    outputDisplay.Text = "You underestimated the height " +
                        "of your family house and fell to your death.";
                    imageDisplay.Image = Adventure_Game.Properties.Resources.scene_19;
                    Thread.Sleep(5000);
                    outputDisplay.Text = "Would you like to start over?";
                    optionOne.Text = "Yes";
                    optionTwo.Text = "No";
                    optionThree.Text = "";
                    imageDisplay.BackColor = Color.Black;
                    break;
                case 20:
                    outputDisplay.Text = "On the way, you noticed a sword on the ground. " +
                        "Would you like to pick it up?";
                    optionOne.Text = "Yes";
                    optionTwo.Text = "No";
                    optionThree.Text = "";
                    imageDisplay.Image = Adventure_Game.Properties.Resources.scene_20;
                    break;
                case 21:
                    outputDisplay.Text = "Your servant pitied you and helped you to escape.";
                    optionOne.Text = "";
                    optionTwo.Text = "";
                    optionThree.Text = "";
                    imageDisplay.Image = Adventure_Game.Properties.Resources.scene_4_alternnative;
                    break;
                case 22:
                    outputDisplay.Text = "She betrayed you by calling in the guards. " +
                        "You were married off to the king afterwards. " +
                        "The fights among you and other concubines got you assassinated. ";
                    imageDisplay.Image = Adventure_Game.Properties.Resources.scene_22;
                    Thread.Sleep(5000);
                    outputDisplay.Text = "Would you like to start over?";
                    optionOne.Text = "Yes";
                    optionTwo.Text = "No";
                    optionThree.Text = "";
                    imageDisplay.BackColor = Color.Black;
                    break;
                case 23:
                    outputDisplay.Text = "You were captured and the next day, you were " +
                        "married off to the emperor. You lived an unhappy life in the " +
                        "palace with other concubines.";
                    imageDisplay.Image = Adventure_Game.Properties.Resources.scene_23;
                    Thread.Sleep(5000);
                    outputDisplay.Text = "Would you like to start over?";
                    optionOne.Text = "Yes";
                    optionTwo.Text = "No";
                    optionThree.Text = "";
                    imageDisplay.BackColor = Color.Black;
                    break;
                case 24:
                    outputDisplay.Text = "You successfully escaped from the marriage." +
                        " Congratulations, you choose happiness instead of fate.";
                    imageDisplay.Image = Adventure_Game.Properties.Resources.scene_24;
                    Thread.Sleep(5000);
                    outputDisplay.Text = "Would you like to start over?";
                    optionOne.Text = "Yes";
                    optionTwo.Text = "No";
                    optionThree.Text = "";
                    imageDisplay.BackColor = Color.Black;
                    break;
                case 25:
                    outputDisplay.Text = "You successfully escaped from the marriage. However," +
                        " you were killed by the robbers trying to rob your family house.";
                    imageDisplay.Image = Adventure_Game.Properties.Resources.scene_25;
                    Thread.Sleep(5000);
                    outputDisplay.Text = "Would you like to start over?";
                    optionOne.Text = "Yes";
                    optionTwo.Text = "No";
                    optionThree.Text = "";
                    imageDisplay.BackColor = Color.Black;
                    break;
                case 26:
                    outputDisplay.Text = "The guards were at the front doors and you were captured." +
                        " The next day, you were married off.";
                    imageDisplay.Image = Adventure_Game.Properties.Resources.scene_26;
                    Thread.Sleep(5000);
                    outputDisplay.Text = "Would you like to start over?";
                    optionOne.Text = "Yes";
                    optionTwo.Text = "No";
                    optionThree.Text = "";
                    imageDisplay.BackColor = Color.Black;
                    break;
                case 27:
                    outputDisplay.Text = "The guards were afraid of you and you successfully escaped them.";
                    imageDisplay.Image = Adventure_Game.Properties.Resources.scene_27;
                    Thread.Sleep(5000);
                    outputDisplay.Text = "Would you like to start over?";
                    optionOne.Text = "Yes";
                    optionTwo.Text = "No";
                    optionThree.Text = "";
                    imageDisplay.BackColor = Color.Black;
                    break;
                case 28:
                    outputDisplay.Text = "You successfully escaped from the marriage. " +
                        "Congratulations, you choose happiness instead of fate.";
                    imageDisplay.Image = Adventure_Game.Properties.Resources.scene_28;
                    Thread.Sleep(5000);
                    outputDisplay.Text = "Would you like to start over?";
                    optionOne.Text = "Yes";
                    optionTwo.Text = "No";
                    optionThree.Text = "";
                    imageDisplay.BackColor = Color.Black;
                    break;
                case 29:
                    outputDisplay.Text = "Unfortunately, you did not  escape. Your servant " +
                        "got beaten to death as a result of helping you. " +
                        "You ended up living the rest of  your life in guilt. ";
                    imageDisplay.Image = Adventure_Game.Properties.Resources.scene_29;
                    Thread.Sleep(5000);
                    outputDisplay.Text = "Would you like to start over?";
                    optionOne.Text = "Yes";
                    optionTwo.Text = "No";
                    optionThree.Text = "";
                    imageDisplay.BackColor = Color.Black;
                    break;


            }

            }

        private void imageDisplay_Click(object sender, EventArgs e)
        {

        }
    }

}
