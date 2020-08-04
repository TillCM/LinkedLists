using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using ABI.Windows.UI.Popups;
using Windows.UI.Popups;
using BasicLinkedList.LinkedList;
using BasicLinkedList.Narrative;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace BasicLinkedList
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        String playerName = null;
        String welcomeMessage = "Welcome to the game   ";
        GameLinkedList gameStory = new GameLinkedList();
        GameNarrative  bjornsStory = new GameNarrative();
        CircularSinlyLinkedList csList = new CircularSinlyLinkedList();
        DList doubleListStory = new DList();
        int count;
        int counter = 0;




        public MainWindow()
        {
            this.InitializeComponent();
            gameStory.append(bjornsStory.intro);
            gameStory.append(bjornsStory.bjorn);
            gameStory.append(bjornsStory.bjornStory);
            gameStory.append(bjornsStory.bjornInsideStory);
            gameStory.append(bjornsStory.bjornReasons);
            gameStory.append(bjornsStory.bjornFights);
            count = gameStory.Count();

            doubleListStory.append(bjornsStory.intro);
            doubleListStory.append(bjornsStory.bjorn);
            doubleListStory.append(bjornsStory.bjornStory);
            doubleListStory.append(bjornsStory.bjornInsideStory);
            doubleListStory.append(bjornsStory.bjornReasons);
            doubleListStory.append(bjornsStory.bjornFights);
            doubleListStory.insert("The story of bjorn", 2);

            csList.append(bjornsStory.intro);
            csList.append(bjornsStory.bjorn);
            csList.append(bjornsStory.bjornStory);
            csList.append(bjornsStory.bjornInsideStory);
            csList.append(bjornsStory.bjornReasons);

           
        }

        private async void myButton_Click(object sender, RoutedEventArgs e)
        {
            playerName = nameInput.Text;
            Windows.UI.Popups.MessageDialog messageDialog = new Windows.UI.Popups.MessageDialog(playerName, welcomeMessage);
           await messageDialog.ShowAsync();

        }

        private  void nextButton_Click(object sender, RoutedEventArgs e)
        {
           
           
                List<string> storyList = new List<string>();

                storyList =gameStory.showNext(counter,count);

            if  (counter < storyList.Count())
            {
               // Windows.UI.Popups.MessageDialog listValues = new Windows.UI.Popups.MessageDialog(count.ToString() + " " + storyList[counter]);
                txtGameNarative.Text = storyList[counter];
                counter++;
                // await listValues.ShowAsync();

                TextBox textBox = new TextBox();
                
                
            }
                
                
                

            

            
        }

        private void previousButton_Click(object sender, RoutedEventArgs e)
        {
            List<string> previousValues = new List<string>();
            previousValues = doubleListStory.showPrevious();

            if (counter < previousValues.Count())
            {
                // Windows.UI.Popups.MessageDialog listValues = new Windows.UI.Popups.MessageDialog(count.ToString() + " " + storyList[counter]);
                txtGameNarative.Text = previousValues[counter];
                counter++;
                // await listValues.ShowAsync();

                TextBox textBox = new TextBox();


            }

        }



        }

    }
