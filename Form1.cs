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

namespace Adventure_Dere
{
    public partial class Form1 : Form
    {
        // variable to tell where the user is
        int scene = 0;
        // random number generator, 
        Random randGen = new Random();
        int scene2Chance, scene1Chance;

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // initial output // start of the game// random values
            photoBox.Image = Properties.Resources._class;
            outputLabel.Text = "Press M to select the first choice, and B for the second choice, it goes down in that order, and press N to restart.";
            beginButton.Visible = false;
            outputLabel.Text = "You are a boy in your second year of high school.";
            outputLabel.Text += "The school dance is coming up and you do not have a date. ";
            outputLabel.Text += "There are two girls in your class who also do not have a date. ";
            outputLabel.Text += "Which one do you talk to?";
            questionLabel.Text = "Mashiro Shiina";
            question2Label.Text = "Karen Tendo";
            question3Label.Text = "";
            this.Focus();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // tells where the game to go when a certain button is pressed.
            if (e.KeyCode == Keys.M)
            {
                if (scene == 0) { scene = 1; }
                else if (scene == 1) { scene = 12; }
                else if (scene == 12) { scene = 13; }
                else if (scene == 13) { scene = 15; }
                else if (scene == 4) { scene = 5; }
                else if (scene == 3){ scene = 6; }
                else if (scene == 6) { scene = 7; }
                else if (scene == 7) { scene = 8; }
                else if (scene == 9) { scene = 10; }
                else if (scene == 10) { scene = 8; }
                else if (scene == 11) { scene = 5; }
                else if (scene == 2) { scene = 16; }
                else if (scene == 16) { scene = 17; }
                else if (scene == 18) { scene = 19; }
                else if (scene == 20) { scene = 21; }
                else if (scene == 22) { scene = 23; }
                else if (scene == 25) { scene = 26; }
            }
            else if (e.KeyCode == Keys.B)
            {
                if (scene == 0) { scene = 2; }
                else if (scene == 2)
                {
                    scene2Chance = randGen.Next(1, 101);
                    if (scene2Chance > 50)
                    {
                        scene = 25;
                    }
                    else
                    {
                        scene = 26;
                    }
                }
                else if (scene == 25) { scene = 0; }
                else if (scene == 1)
                {
                    scene1Chance = randGen.Next(1, 101);
                    if (scene1Chance < 10)
                    {
                        scene = 3;
                    }
                    else
                    {
                        scene = 4;
                    }
                }
                else if (scene == 6) { scene = 9; }
                else if (scene == 9) { scene = 11; }
                else if (scene == 12) { scene = 14; }
                else if (scene == 13) { scene = 3; }
                else if (scene == 16) { scene = 18; }
                else if (scene == 18) { scene = 20; }
                else if (scene == 20) { scene = 22; }
                else if (scene == 22) { scene = 24; }
            }
            else if (e.KeyCode == Keys.N)
            {
                if (scene == 1) { scene = 2; }
                else if (scene == 2) { scene = 1; }//Talking to another girl, doesnt restart it
                else if (scene == 5) { scene = 0; }
                else if (scene == 8) { scene = 0; }
                else if (scene == 14) { scene = 0; }
                else if (scene == 15) { scene = 0; }
                else if (scene == 21) { scene = 0; }
                else if (scene == 23) { scene = 0; }
                else if (scene == 17) { scene = 0; }
                else if (scene == 19) { scene = 0; }
                else if (scene == 24) { scene = 0; }
                else if (scene == 26) { scene = 0; }


            }
            // the dialouge of the scenes and the options for the player
            switch (scene)
            {
                //Scene , 26 all have endings, so put  "Press the N key to restart"
                case 0:
                    photoBox.Image = Properties.Resources._class;
                    outputLabel.Text = "You are a boy in your second year of high school.";
                    outputLabel.Text += "The school dance is coming up and you do not have a date. ";
                    outputLabel.Text += "There are two girls in your class who also do not have a date. ";
                    outputLabel.Text += "Which one do you talk to?";
                    questionLabel.Text = "Mashiro Shiina ";
                    question2Label.Text = "Karen Tendo";
                    break;
                case 1:
                    photoBox.Image = Properties.Resources.shiina;
                    outputLabel.Text = "You Approach the girl and she greets you with a smile.";
                    questionLabel.Text = "Ask her on a date?";
                    question2Label.Text = "Ask her to the dance?";
                    question3Label.Text = "Talk to the other girl.";
                    break;
                case 2:
                    photoBox.Image = Properties.Resources.images__1_;
                    outputLabel.Text = "You Approach the girl and she glares at you.";
                    questionLabel.Text = "Ask her out?";
                    question2Label.Text = " Walk Away?";
                    question3Label.Text = "Talk to the other girl";
                    break;
                case 3:
                    outputLabel.Text = "She smiles and gives a pleasant laugh as she agrees to your proposal. " +
                        "she says to pick her up by 7. you rush home excited as you prepare for the dance.";
                    question2Label.Text = "";
                    question3Label.Text = "";
                    questionLabel.Text = "Continue.";
                    break;
                case 4:
                    outputLabel.Text = "She smiles at you but she politely turns you down. " +
                        "she says that she doesn't know you that well and that she would feel " +
                        "uncomfortable at a dance with a person she has never spent any time with prior. ";
                    questionLabel.Text = "Continue.";
                    question2Label.Text = "";
                    question3Label.Text = "";
                    break;
                case 5:
                    outputLabel.Text = "You turn around defeated as you go home. You see the other girl on your way and she smiles at you." +
                        " You are too depressed to do anything else and you retreat to your room for the rest of the year. ";
                    questionLabel.Text = "";
                    question2Label.Text = "";
                    question3Label.Text = "Press 'n' to Restart.";
                    break;
                case 6:
                    outputLabel.Text = "you prepare yourself for the dance do you:";
                    questionLabel.Text = "red tie?";
                    question2Label.Text = "blue tie ? ";
                    question3Label.Text = "";
                    break;
                case 7:
                    outputLabel.Text = "You go to her house by 7 pm and she open the door. she is wearing a red dress. " +
                        "she smiles at you for your great choice in tie colour";
                    questionLabel.Text = "Continue";
                    question2Label.Text = "";
                    question3Label.Text = "";
                    break;
                case 8:
                    outputLabel.Text = "You both have a wonderful time at the dance. " +
                        "Eventually your new found friendship blossoms into a steady relationship and " +
                        "you realize you both are meant for each other. ";
                    questionLabel.Text = "";
                    question2Label.Text = "";
                    question3Label.Text = " Press N to restart";
                    break;
                case 9:
                    outputLabel.Text = "You go to her house by 7 pm and she open the door. she is wearing a red dress. " +
                        "she look at your clashing tie and she frowns. " +
                        " You go to the dance but it doesn't seem right. you see a punch bowl.";
                    questionLabel.Text = "Look Closer";
                    question2Label.Text = "Quickly Grab Punch";
                    question3Label.Text = "";
                    break;
                case 10:
                    outputLabel.Text = "you notice that the punch glasses look cheap so instead go go to your date and ask her to dance.";
                    questionLabel.Text = "Continue";
                    question2Label.Text = "";
                    question3Label.Text = "";
                    break;
                case 11:
                    outputLabel.Text = "you bring your date a glass of punch but the glass spills all over her. she runs out of the room.";
                    questionLabel.Text = "Continue";
                    question2Label.Text = "";
                    question3Label.Text = "";
                    break; 
                case 12:
                    outputLabel.Text = "She seems delighted and accepts. she says she is free after school. Where do you take her?";
                    questionLabel.Text = "To the zoo?";
                    question2Label.Text = "Or to the Park?";
                    question3Label.Text = "";
                    break;
                case 13:
                    outputLabel.Text = "The zoo is both your favourite place to go. you spend the day laughing and having fun. " +
                        "It begins to get late and you want to ask her if she wants to go to the dance. But you are having a lot of fun.";
                    questionLabel.Text = "Stay at the zoo?";
                    question2Label.Text = " Ask her to the dance?";
                    question3Label.Text = "";
                    break;
                case 14:
                    outputLabel.Text = "A day at the park is a wonderful idea. you both enjoy yourselves to the point of exhaustion. She thank you for a wonder day but she is too tired to go to the dance."
                    +"You go home happy for a great day but you are upset about not going to the dance";
                    questionLabel.Text = "";
                    question2Label.Text = "";
                    question3Label.Text = "Press N to reset";
                    break;
                case 15:
                    outputLabel.Text = "You decide that this is in fact the perfect day and you decide to skip the dance. Tour date seems to agree and eventually, your new friendship blossoms into a steady relationship";
                    questionLabel.Text = "";
                    question2Label.Text = "";
                    question3Label.Text = "Press N to reset";
                    break;
                case 16:
                    outputLabel.Text = "She scoffs at first but she says she is in a good mood today so she agrees to a date." + "What do you do?";
                    questionLabel.Text = "Fancy Dinner?";
                    question2Label.Text = " Or the zoo?";
                    question3Label.Text = "";
                    break;
                case 17:
                    outputLabel.Text = "You dont know what happened. it may be the lighting or the casual nature of a restaurant but your date begins to open up and she turns out to be a wonderful person on the inside. " +
                        "you spend the rest of your night forgetting about the dance and instead have a great time talking to one another.";
                    questionLabel.Text = "";
                    question2Label.Text = "";
                    question3Label.Text = "Press N to reset";
                    break;
                case 18:
                    outputLabel.Text = "She is skeptical but reluctantly agrees. when you get there she asks to go see the sea otters. You see a small gift shop. What do you do? ";
                    questionLabel.Text = "Buy her a gift?";
                    question2Label.Text = " Buy her a candy apple?";
                    question3Label.Text = "";
                    break;
                case 19:
                    outputLabel.Text = " You see a stuffed Sea Otter on a shelf and you buy it for your date. she blushes and thanks you for the present." +
                        " you both decide to forget about the dance and you continue to have an incredible evening at the zoo" + 
                        "your new found friendship blossoms into a steady relationship and you realize you both are meant for each other.";
                    questionLabel.Text = "";
                    question2Label.Text = "";
                    question3Label.Text = " press N to restart";
                    break;
                case 20:
                    outputLabel.Text = "You buy here a candy apple, she thanks you and you both enjoy the apple.She's enjoying herself.Do you ask her to the dance?";
                    questionLabel.Text = "Stay at the zoo?";
                    question2Label.Text = "Ask her to the dance?";
                    question3Label.Text = "";
                    break;
                case 21:
                    outputLabel.Text = "You both enjoyed the zoo a lot more than you originally thought, " +
                        "you eventually end up driving her home that night and she thanks you for the wonderful time." + "your new found friendship blossoms into a steady relationship and you realize you both are meant for each other.";
                    questionLabel.Text = "";
                    question2Label.Text = "";
                    question3Label.Text = " Press N to restart";
                    break;
                case 22:
                    outputLabel.Text = " You ask her if she wants to go to the dance with you, stuttering and blushing, she reluctantly agrees to go but, mention that she has  an invitation to a secret dance party held in the towns abandons factory, " +
                        "You agree to go and you say  that  you will pick her up at 7PM that night, you ask yourself: wht should I wear?";
                    questionLabel.Text = "An edgy costume that makes ypu rethink your life?";
                    question2Label.Text = "A tuxedo that you haven't worn in months?";
                    question3Label.Text = "";
                    break;
                case 23:
                    outputLabel.Text = "Turns out the dance was a anime costume party! She shows up in a similarly edgy costume and she loves the way you dress! You both have a wonderful time and dance the night away! "
                        + "You both have made something more than a relationship, you have become soulmates! Your love knows no bounds and you live happy ever after!";
                    questionLabel.Text = "";
                    question2Label.Text = "";
                    question3Label.Text = " press N to restart";
                    break;
                case 24:
                    outputLabel.Text = "Turns out the dance was a anime costume party! She shows up in a in an  edgy costume and she hates the way you dress! " +
                        "She punches you in the face  and into the girl's bathroom were they proceed to slap and kick the living snot out of you! You go home humiliated and defeated, covered in bruises and the occasional scratches. " + 
                        "You stay home for the next few days as you are so humiliated and everybody  hates you! You get called by her parents and they thank you for saving there daughter from herself! They say if you want, you could come over tonight for supper were they would have a feast in  your honor......";
                    questionLabel.Text = "";
                    question2Label.Text = "";
                    question3Label.Text = " press N to restart";
                    break;
                case 25:
                    outputLabel.Text = "You have been given a second shot at love. Do you:";
                    questionLabel.Text = "Go home?";
                    question2Label.Text = "Talk";
                    question3Label.Text = "";
                    break;
                case 26:
                    outputLabel.Text = " You continue on your pathetic life of lonliness";
                    questionLabel.Text = "";
                    question2Label.Text = "";
                    question3Label.Text = " press N to restart";
                    break;
               



            }


        }
    }
}
