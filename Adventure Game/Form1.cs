//By Rie Koay On Nov 8 2017
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Adventure_Game
{
    public partial class mainDisplay : Form
    {//starting from scene 1
        int scene = 1;
        //Generating Random Number
        Random ranGen = new Random();

        int computer;

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
                else if (scene == 3) { scene = 1; }
                else if (scene == 7) { scene = 11; }
                else if (scene == 11) { scene = 12; }
                else if (scene == 12) { scene = 13; }
                else if (scene == 13) { scene = 14; }
                else if (scene == 14) { scene = 30; }
                else if (scene == 30) { scene = 23; }
                else if (scene == 15) { scene = 14; }
                else if (scene == 10) { scene = 31; }
                else if (scene == 17) { scene = 31; }
                else if (scene == 18) { scene = 31; }
                else if (scene == 19) { scene = 31; }
                else if (scene == 22) { scene = 31; }
                else if (scene == 23) { scene = 31; }
                else if (scene == 24) { scene = 31; }
                else if (scene == 25) { scene = 31; }
                else if (scene == 26) { scene = 31; }
                else if (scene == 27) { scene = 31; }
                else if (scene == 28) { scene = 31; }
                else if (scene == 29) { scene = 31; }
                else if (scene == 31) { scene = 1; }
            }

            if (e.KeyCode == Keys.T)       //blue button press
            {

                //if (scene == 1) { scene = 3; }

                if (scene == 1) { scene = 3; }
                else if (scene == 3) { Close(); }
                else if (scene == 5) { scene = 10; }
                else if (scene == 9) { scene = 17; }
                else if (scene == 16) { scene = 19; }
                else if (scene == 20) { scene = 26; }
                else if (scene == 14) { scene = 18; }
                else if (scene == 30)
                {
                    computer = ranGen.Next(1, 11);
                    if (computer > 5)
                    { scene = 24; }
                    else
                    { scene = 25; }
                    ;
                }
                else if (scene == 7) { scene = 15; }
                else if (scene == 2) { scene = 6; }
                else if (scene == 6) { scene = 7; }
                else if (scene == 31) { Close(); }

            }
            if (e.KeyCode == Keys.E)       //Green button press
            {
                if (scene == 5)
                {
                    computer = ranGen.Next(1, 11);
                    if (computer > 5)
                    { scene = 8; }
                    else
                    { scene = 10; }
                    ;
                }
                else if (scene == 16) { scene = 21; }
                else if (scene == 21)
                {
                    computer = ranGen.Next(1, 11);
                    if (computer > 7)
                    { scene = 29; }
                    else
                    { scene = 28; }
                    ;
                }
                else if (scene == 7)
                {
                    computer = ranGen.Next(1, 11);
                    if (computer > 5)
                    { scene = 15; }
                    else
                    { scene = 11; }
                    ;
                }
                else if (scene == 30) { scene = 22; }
            }

            switch (scene)
            {
                case 1:  //start scene  
                    outputDisplay.Text = "You found an ancient book " +
                        "in the library. It seemed to be about marriage in the ancient time. " +
                        "Would you like to open it?";
                    optionOne.Text = "Yes";
                    optionTwo.Text = "No";
                    optionThree.Text = "";
                    imageDisplay.Image = Adventure_Game.Properties.Resources.ancient_book;
                    break;

                case 2:
                    SoundPlayer player = new SoundPlayer(Properties.Resources.flyby_Conor_1500306612);
                    player.Play();
                    outputDisplay.Text = "You fell through space and entered the ancient time. " +
                        "You woke up with a bad headache in a strange room. " +
                        "Would you like to head out?";
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
                    player = new SoundPlayer(Properties.Resources.Ting_Popup_Pixels_349896185);
                    player.Play();
                    outputDisplay.Text = "You pushed open the creaking door and a girl " +
                        "claimed to be your family servant greeted you politely.";
                    optionOne.Text = "Continue";
                    optionTwo.Text = "";
                    optionThree.Text = "";
                    imageDisplay.Image = Adventure_Game.Properties.Resources.scene_4_alternnative;
                    break;

                case 5:
                    player = new SoundPlayer(Properties.Resources.birds_after_rain_Mike_Koenig_1034248330);
                    player.Play();
                    outputDisplay.Text = "Would you like to ask about your identity in this world?";
                    optionOne.Text = "Yes";
                    optionTwo.Text = "No";
                    optionThree.Text = "Maybe";
                    imageDisplay.Image = Adventure_Game.Properties.Resources.scene_4_alternnative;
                    break;

                case 6:
                    player = new SoundPlayer(Properties.Resources.Footsteps_SoundBible_com_534261997);
                    player.Play();
                    outputDisplay.Text = "You explored the contents in the room.";
                    optionOne.Text = "";
                    optionTwo.Text = "Continue";
                    optionThree.Text = "";
                    imageDisplay.Image = Adventure_Game.Properties.Resources.scene_6;
                    break;

                case 7:
                    outputDisplay.Text = "Then, you came across a beautiful " +
                        "wooden box, would you like to open it?";
                    optionOne.Text = "Yes";
                    optionTwo.Text = "No";
                    optionThree.Text = "Maybe";
                    imageDisplay.Image = Adventure_Game.Properties.Resources.scene_7;
                    break;

                case 8:
                    player = new SoundPlayer(Properties.Resources.Appear_KP_1137861048);
                    player.Play();
                    outputDisplay.Text = "She told you that you are the daughter of the richest household " +
                        "around the area. Your heartless father married you off to the" +
                        " king to strengthen your family's relationship with the royal family. " +
                        "You were supposed to be married off today if you had not fainted.";
                    optionOne.Text = "Continue";
                    optionTwo.Text = "";
                    optionThree.Text = "";
                    imageDisplay.Image = Adventure_Game.Properties.Resources.scene_8;
                    break;

                case 9:
                    player = new SoundPlayer(Properties.Resources.Night_Sounds___Crickets_Lisa_Redfern_591005346);
                    player.Play();
                    outputDisplay.Text = "Nightfall.You are not allowed to leave your " +
                        "family house until tomorrow's marriage. What do you do?";
                    optionOne.Text = "Escape in the middle of the night";
                    optionTwo.Text = "Stay put until morning";
                    optionThree.Text = "";
                    imageDisplay.Image = Adventure_Game.Properties.Resources.scene_2;
                    break;
                case 10:
                    player = new SoundPlayer(Properties.Resources.Sad_Trombone_Joe_Lamb_665429450);
                    player.Play();
                    outputDisplay.Text = "You greeted back, however, you did not ask her any questions. " +
                        "The next day, you were put in a fancy carriage and married off to the king." +
                        " Your goals in life were unfulfilled and" +
                        " you ended up living your whole life in the palace, " +
                        "unable to escape your dreadful fate.";
                    optionOne.Text = "Continue";
                    optionTwo.Text = "";
                    optionThree.Text = "";
                    imageDisplay.Image = Adventure_Game.Properties.Resources.scene_10;
                    break;
                case 11:
                    player = new SoundPlayer(Properties.Resources.cloth_Anna_2094913298);
                    player.Play();
                    outputDisplay.Text = "You found an old fashioned wedding attire within" +
                        " and you tried it on out of curiosity.";
                    optionOne.Text = "Continue";
                    optionTwo.Text = "";
                    optionThree.Text = "";
                    imageDisplay.Image = Adventure_Game.Properties.Resources.scene_11;
                    break;
                case 12:
                    player = new SoundPlayer(Properties.Resources.Knocking_On_Door_SoundBible_com_84643603);
                    player.Play();
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
                    break;
                case 15:
                    player = new SoundPlayer(Properties.Resources.Knocking_On_Door_SoundBible_com_84643603);
                    player.Play();
                    outputDisplay.Text = "A girl knocked and came into the room, claiming to be your family " +
                        "servant. You asked her about yourself and this place.";
                    optionOne.Text = "Continue";
                    optionTwo.Text = "";
                    optionThree.Text = "";
                    imageDisplay.Image = Adventure_Game.Properties.Resources.scene_4;
                    break;
                case 16:
                    player = new SoundPlayer(Properties.Resources.Strange_Noise_SoundBible_com_229408508);
                    player.Play();
                    outputDisplay.Text = "How would you like to escape?";
                    optionOne.Text = "Escape through the front doors of your family house";
                    optionTwo.Text = "Escape through the window";
                    optionThree.Text = "Request for your servant's help";
                    imageDisplay.Image = Adventure_Game.Properties.Resources.scene_16;
                    break;
                case 17:
                    player = new SoundPlayer(Properties.Resources.Sad_Trombone_Joe_Lamb_665429450);
                    player.Play();
                    outputDisplay.Text = "You ended up becoming one of the king's three thousand wives." +
                        " You were given infinite amount of precious jewels and expensive silk" +
                        " except you died a lonely death. ";
                    optionOne.Text = "Continue";
                    optionTwo.Text = "";
                    optionThree.Text = "";
                    imageDisplay.Image = Adventure_Game.Properties.Resources.scene_17;
                    break;
                case 18:
                    player = new SoundPlayer(Properties.Resources.Sad_Trombone_Joe_Lamb_665429450);
                    player.Play();
                    outputDisplay.Text = "Your father married you off to the palace the next day, " +
                        "leaving you confused and devastated for the rest of your life. " +
                        "You regretted the decision you made to not escape.";
                    optionOne.Text = "Continue";
                    optionTwo.Text = "";
                    optionThree.Text = "";
                    imageDisplay.Image = Adventure_Game.Properties.Resources.scene_18; 
                    break;
                case 19:
                    player = new SoundPlayer(Properties.Resources.Sad_Trombone_Joe_Lamb_665429450);
                    player.Play();
                    outputDisplay.Text = "You underestimated the height " +
                        "of your family house and fell to your death.";
                    optionOne.Text = "Continue";
                    optionTwo.Text = "";
                    optionThree.Text = "";
                    imageDisplay.Image = Adventure_Game.Properties.Resources.scene_19;
                    break;
                case 20:
                    player = new SoundPlayer(Properties.Resources.Swords_Collide_Sound_Explorer_2015600826);
                    player.Play();
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
                    optionThree.Text = "Continue";
                    imageDisplay.Image = Adventure_Game.Properties.Resources.scene_4_alternnative;
                    break;
                case 22:
                    player = new SoundPlayer(Properties.Resources.Sad_Trombone_Joe_Lamb_665429450);
                    player.Play();
                    outputDisplay.Text = "She betrayed you by calling in the guards. " +
                        "You were married off to the king afterwards. " +
                        "The fights among you and other concubines got you assassinated. ";
                    optionOne.Text = "Continue";
                    optionTwo.Text = "";
                    optionThree.Text = "";
                    imageDisplay.Image = Adventure_Game.Properties.Resources.scene_22;
                    break;
                case 23:
                    player = new SoundPlayer(Properties.Resources.Sad_Trombone_Joe_Lamb_665429450);
                    player.Play();
                    outputDisplay.Text = "You were captured and the next day, you were " +
                        "married off to the emperor. You lived an unhappy life in the " +
                        "palace with other concubines.";
                    optionOne.Text = "Continue";
                    optionTwo.Text = "";
                    optionThree.Text = "";
                    imageDisplay.Image = Adventure_Game.Properties.Resources.scene_23;
                    break;
                case 24:
                    player = new SoundPlayer(Properties.Resources.SMALL_CROWD_APPLAUSE_Yannick_Lemieux_1268806408__1_);
                    player.Play();
                    outputDisplay.Text = "Later on, you found out that your father wanted to marry you off to the emperor. " +
                        "Unfortunately for him, have successfully escaped from the marriage." +
                        " Congratulations, you chose happiness instead of fate.";
                    optionOne.Text = "Continue";
                    optionTwo.Text = "";
                    optionThree.Text = "";
                    imageDisplay.Image = Adventure_Game.Properties.Resources.scene_24;
                    break;
                case 25:
                    player = new SoundPlayer(Properties.Resources.Sad_Trombone_Joe_Lamb_665429450);
                    player.Play();
                    outputDisplay.Text = "You have successfully escaped from your family. However," +
                        " you were killed by the robbers trying to rob your house.";
                    optionOne.Text = "Continue";
                    optionTwo.Text = "";
                    optionThree.Text = "";
                    imageDisplay.Image = Adventure_Game.Properties.Resources.scene_25;
                    break;
                case 26:
                    player = new SoundPlayer(Properties.Resources.Sad_Trombone_Joe_Lamb_665429450);
                    player.Play();
                    outputDisplay.Text = "The guards were at the front doors and you were captured." +
                        " The next day, you were married off.";
                    optionOne.Text = "Continue";
                    optionTwo.Text = "";
                    optionThree.Text = "";
                    imageDisplay.Image = Adventure_Game.Properties.Resources.scene_26;
                    break;
                case 27:
                    player = new SoundPlayer(Properties.Resources.SMALL_CROWD_APPLAUSE_Yannick_Lemieux_1268806408__1_);
                    player.Play();
                    outputDisplay.Text = "The guards were afraid of you and you successfully escaped them.";
                    optionOne.Text = "Continue";
                    optionTwo.Text = "";
                    optionThree.Text = "";
                    imageDisplay.Image = Adventure_Game.Properties.Resources.scene_27;
                    break;
                case 28:
                    player = new SoundPlayer(Properties.Resources.SMALL_CROWD_APPLAUSE_Yannick_Lemieux_1268806408__1_);
                    player.Play();
                    outputDisplay.Text = "You successfully escaped from the marriage. " +
                        "Congratulations, you choose happiness instead of fate.";
                    optionOne.Text = "Continue";
                    optionTwo.Text = "";
                    optionThree.Text = "";
                    imageDisplay.Image = Adventure_Game.Properties.Resources.scene_28;
                    break;
                case 29:
                    player = new SoundPlayer(Properties.Resources.Sad_Trombone_Joe_Lamb_665429450);
                    player.Play();
                    outputDisplay.Text = "Unfortunately, you did not  escape. Your servant " +
                        "got beaten to death as a result of helping you. " +
                        "You ended up living the rest of  your life in guilt. ";
                    optionOne.Text = "Continue";
                    optionTwo.Text = "";
                    optionThree.Text = "";
                    imageDisplay.Image = Adventure_Game.Properties.Resources.scene_29;
                    break;
                case 30:
                    outputDisplay.Text = "Do you escape through the doors of your family house," +
                        " request for your servant's help or do you escape through the back" +
                        " door?";
                    optionOne.Text = "Escape through the doors of your family house";
                    optionTwo.Text = "Escape through the back door";
                    optionThree.Text = "Request for servant's help";
                    imageDisplay.Image = Adventure_Game.Properties.Resources.scene_30;
                    break;
                case 31:
                    outputDisplay.Text = "Would you like to start over?";
                    optionOne.Text = "Yes";
                    optionTwo.Text = "No";
                    optionThree.Text = "";
                    imageDisplay.Image = Adventure_Game.Properties.Resources.Ending_Scene;
                    break;

            }

        }
        
    }
}
