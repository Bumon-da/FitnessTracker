using System;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace FitnessTracker
{
    public partial class Form1 : Form
    {
        private string loggedInUserId; // This will store the username (e.g., "Bumonda")
        private IMongoCollection<BsonDocument> usersCollection;
        private IMongoCollection<BsonDocument> workoutsCollection;
        private IMongoCollection<BsonDocument> goalsCollection;

        // Variables to store the most recent workout and goal
        private BsonDocument mostRecentWorkout = null;
        private BsonDocument mostRecentGoal = null;

        public Form1(string username)
        {
            InitializeComponent();
            loggedInUserId = username; // Store the username as the UserId
            InitializeMongoDB();
            InitializeControls();
        }

        private void InitializeMongoDB()
        {
            var client = new MongoClient("mongodb+srv://root:root@fitnesstrackerlogin.rymvb.mongodb.net/?retryWrites=true&w=majority&appName=FitnessTrackerLogin");
            var database = client.GetDatabase("FitnessTracker");
            usersCollection = database.GetCollection<BsonDocument>("Users");
            workoutsCollection = database.GetCollection<BsonDocument>("Workouts");
            goalsCollection = database.GetCollection<BsonDocument>("Goals");
        }

        private void InitializeControls()
        {
            // Initialize Workout Type ComboBox
            cmbWorkoutType.Items.AddRange(new string[] { "Chest and Arms", "Back and Biceps", "Legs", "Cardio" });
            cmbWorkoutType.SelectedIndex = 0; // Default selection

            // Initialize Duration ComboBox
            cmbDuration.Items.AddRange(new string[] { "30 mins", "45 mins", "60 mins", "90 mins", "120 mins" });
            cmbDuration.SelectedIndex = 0; // Default selection

            // Initialize Goal Type CheckBoxes
            chkEasy.Text = "Easy";
            chkMedium.Text = "Medium";
            chkHard.Text = "Hard";
            chkExtreme.Text = "Extreme";

            // Initialize Target Value TrackBar
            trackTargetValue.Minimum = 0;
            trackTargetValue.Maximum = 100;
            trackTargetValue.Value = 50; // Default value
            lblTargetValue.Text = "50%"; // Default label text

            // Initialize Deadline DateTimePicker
            dtpDeadline.Format = DateTimePickerFormat.Short;
            dtpDeadline.Value = DateTime.Now.AddDays(7); // Default to 1 week from today
        }

        private void btnLogWorkout_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if the logged-in user exists in the Users collection
                var userFilter = Builders<BsonDocument>.Filter.Eq("Username", loggedInUserId);
                var user = usersCollection.Find(userFilter).FirstOrDefault();

                if (user == null)
                {
                    MessageBox.Show("Error: User not found. Please log in again.");
                    return; // Exit the method if the user is not found
                }

                // If the user exists, proceed to log the workout
                var workout = new BsonDocument
                {
                    { "UserId", loggedInUserId }, // Use the username as the UserId
                    { "Type", cmbWorkoutType.SelectedItem.ToString() },
                    { "Duration", cmbDuration.SelectedItem.ToString() },
                    { "CaloriesBurned", txtCaloriesBurned.Text },
                    { "StepsTaken", txtStepsTaken.Text },
                    { "Date", DateTime.UtcNow } // Store date in UTC
                };

                // Insert the workout into the database
                workoutsCollection.InsertOne(workout);

                // Store the most recent workout
                mostRecentWorkout = workout;

                MessageBox.Show("Workout logged successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error logging workout: " + ex.Message);
            }
        }

        private void btnSetGoal_Click(object sender, EventArgs e)
        {
            try
            {
                string goalType = "";
                if (chkEasy.Checked) goalType = "Easy";
                else if (chkMedium.Checked) goalType = "Medium";
                else if (chkHard.Checked) goalType = "Hard";
                else if (chkExtreme.Checked) goalType = "Extreme";

                var goal = new BsonDocument
                {
                    { "UserId", loggedInUserId }, // Use the username as the UserId
                    { "GoalType", goalType },
                    { "TargetValue", trackTargetValue.Value },
                    { "Deadline", dtpDeadline.Value.ToUniversalTime() } // Store deadline in UTC
                };

                // Insert the goal into the database
                goalsCollection.InsertOne(goal);

                // Store the most recent goal
                mostRecentGoal = goal;

                MessageBox.Show("Goal set successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error setting goal: " + ex.Message);
            }
        }

        private void btnViewProgress_Click(object sender, EventArgs e)
        {
            try
            {
                string progress = "Most Recent Workout:\n";
                if (mostRecentWorkout != null)
                {
                    string type = mostRecentWorkout.Contains("Type") ? mostRecentWorkout["Type"].ToString() : "N/A";
                    string duration = mostRecentWorkout.Contains("Duration") ? mostRecentWorkout["Duration"].ToString() : "N/A";
                    string caloriesBurned = mostRecentWorkout.Contains("CaloriesBurned") ? mostRecentWorkout["CaloriesBurned"].ToString() : "N/A";
                    string stepsTaken = mostRecentWorkout.Contains("StepsTaken") ? mostRecentWorkout["StepsTaken"].ToString() : "N/A";
                    string date = mostRecentWorkout.Contains("Date") && mostRecentWorkout["Date"].IsValidDateTime
                        ? mostRecentWorkout["Date"].ToLocalTime().ToString("d")
                        : "N/A";

                    // Validate and format CaloriesBurned and StepsTaken
                    if (!int.TryParse(caloriesBurned, out int calories))
                    {
                        caloriesBurned = "Invalid";
                    }
                    if (!int.TryParse(stepsTaken, out int steps))
                    {
                        stepsTaken = "Invalid";
                    }

                    progress += $"Type: {type}, Duration: {duration}, Calories: {caloriesBurned}, Steps: {stepsTaken}, Date: {date}\n";
                }
                else
                {
                    progress += "No recent workout logged.\n";
                }

                progress += "\nMost Recent Goal:\n";
                if (mostRecentGoal != null)
                {
                    string goalType = mostRecentGoal.Contains("GoalType") ? mostRecentGoal["GoalType"].ToString() : "N/A";
                    string targetValue = mostRecentGoal.Contains("TargetValue") ? mostRecentGoal["TargetValue"].ToString() : "N/A";
                    string deadline = mostRecentGoal.Contains("Deadline") && mostRecentGoal["Deadline"].IsValidDateTime
                        ? mostRecentGoal["Deadline"].ToLocalTime().ToString("d")
                        : "N/A";

                    // Validate and format TargetValue
                    if (!int.TryParse(targetValue, out int target))
                    {
                        targetValue = "Invalid";
                    }

                    progress += $"Type: {goalType}, Target: {targetValue}%, Deadline: {deadline}\n";
                }
                else
                {
                    progress += "No recent goal set.\n";
                }

                MessageBox.Show(progress);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error viewing progress: " + ex.Message);
            }
        }

        private void trackTargetValue_Scroll(object sender, EventArgs e)
        {
            lblTargetValue.Text = $"{trackTargetValue.Value}%";
        }
    }
}