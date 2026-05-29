using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace PROG_PART_2
{
    public class user_name
    {
        public string submit_name(TextBox user_name, ListView chats)
        {//start of

            //temp variables 
            string filename = "user_names.txt";

            //check if the filename exists or not , then auto create
            if (!File.Exists(filename))
            {
                //auto create the file using AppendAllText() function
                File.AppendAllText(filename, "auto_create\n");

                //system message
                error_method(
                    "System",
                    "New database file created successfully",
                    chats
                );

            }//end 

            //temp variables
            string name = user_name.Text.ToString();

            //validation
            if (name.Trim() == "")
            {
                error_method(
                    "System",
                    "Please enter your username first",
                    chats
                );

                return "";
            }

            bool found = check_name(name);

            //check if the user is found or not and write the name in a text file
            if (!found)
            {//start of if

                //write the name in a text file
                File.AppendAllText(filename, name + "\n");

                //then welcome the user
                error_method(
                    "ChatBot",
                    "Hey " + name +
                    " welcome to AI cybersecurity Assistant",
                    chats
                );

                //extra chatbot message
                error_method(
                    "ChatBot",
                    "You can ask me about passwords, phishing, malware, hacking tips and cybersecurity.",
                    chats
                );

            }//end of if
            else
            {//start of else

                //welcome the user back
                error_method(
                    "ChatBot ",
                    "Hey " + name +
                    " welcome back, how can i assist you today?",
                    chats
                );

            }//end of else

            //return name
            return name;

        }//end of


        //method to check name of the user
        private Boolean check_name(string name)
        {//start

            //temp variable
            string filename = "user_names.txt";

            bool found_name = false;

            //store or get all the names in the text file and store in an 1D array
            string[] names = File.ReadAllLines(filename);

            //foreach to search the name of the user
            foreach (string name_found in names)
            { //start of loop

                //if statement to check for the username
                if (name_found.ToLower() == name.ToLower())
                {//start if

                    //found_name set to true
                    found_name = true;

                }//end of if

            }//end of the loop

            //return the status of found or not [ true or false ]
            return found_name;

        }//end check method



        //error method
        private void error_method(string name, string message, ListView chats)
        {//star of error mehtod

            // Create a border for chats
            Border messageBorder = new Border
            {
                Margin = new Thickness(0, 5, 0, 5),
                Padding = new Thickness(10, 8, 10, 8),
                CornerRadius = new CornerRadius(10)
            };

            // Set different background for user vs bot
            if (name.ToLower().Contains("chatbot") || name.ToLower().Contains("chat"))
            {// Light blue

                messageBorder.Background =
                    new SolidColorBrush(Color.FromRgb(230, 240, 255));

                messageBorder.BorderBrush =
                    new SolidColorBrush(Color.FromRgb(0, 120, 215));

            }
            else if (name.ToLower().Contains("system"))
            {//light red

                messageBorder.Background =
                    new SolidColorBrush(Color.FromRgb(255, 240, 240));

                messageBorder.BorderBrush =
                    new SolidColorBrush(Color.FromRgb(220, 20, 60));

            }
            else
            {    // Light gray

                messageBorder.Background =
                    new SolidColorBrush(Color.FromRgb(245, 245, 245));

                messageBorder.BorderBrush =
                    new SolidColorBrush(Color.FromRgb(211, 211, 211));

            }

            messageBorder.BorderThickness = new Thickness(1);

            TextBlock messageText = new TextBlock
            {
                TextWrapping = TextWrapping.Wrap,
                Margin = new Thickness(2),
                FontSize = 14
            };

            // Set color based on sender
            Brush nameColor =
                (name.ToLower().Contains("chatbot") ||
                 name.ToLower().Contains("chat"))
                ?
                Brushes.DarkBlue
                :
                Brushes.DarkGreen;

            Brush messageColor = Brushes.Black;

            //username
            messageText.Inlines.Add(new Run
            {
                Text = name + ": ",
                Foreground = nameColor,
                FontWeight = FontWeights.Bold,
                FontSize = 15
            });

            //message
            messageText.Inlines.Add(new Run
            {
                Text = message,
                Foreground = messageColor
            });

            //time
            messageText.Inlines.Add(new Run
            {
                Text = "\n " + DateTime.Now.ToShortTimeString(),
                Foreground = Brushes.Gray,
                FontSize = 10
            });

            messageBorder.Child = messageText;

            //add to chats
            chats.Items.Add(messageBorder);

            //auto scroll
            chats.ScrollIntoView(chats.Items[chats.Items.Count - 1]);

        }//end of error method



        //clear chat event handler
        public void ClearChat_Click(object sender, RoutedEventArgs e, ListView chats, TextBox question)
        {
            chats.Items.Clear();
            question.Clear();

            //display a clear message from the chatbot
            error_method(
                "ChatBot",
                "The chat has been cleared successfully",
                chats
            );
        }



        //exit_chat event handler
        public void ExitChat_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

    }

}