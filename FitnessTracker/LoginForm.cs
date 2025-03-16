using System;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace FitnessTracker
{
    public partial class LoginForm : Form
    {
        private IMongoCollection<BsonDocument> usersCollection;

        public LoginForm()
        {
            InitializeComponent();
            InitializeMongoDB();
        }

        private void InitializeMongoDB()
        {
            var client = new MongoClient("mongodb+srv://root:root@fitnesstrackerlogin.rymvb.mongodb.net/?retryWrites=true&w=majority&appName=FitnessTrackerLogin");
            var database = client.GetDatabase("FitnessTracker");
            usersCollection = database.GetCollection<BsonDocument>("Users");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Validate the user (e.g., check if the username and password match in the database)
            var userFilter = Builders<BsonDocument>.Filter.Eq("Username", username) & Builders<BsonDocument>.Filter.Eq("Password", password);
            var user = usersCollection.Find(userFilter).FirstOrDefault();

            if (user != null)
            {
                // Open Form1 and pass the username as the UserId
                Form1 form1 = new Form1(username);
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            // Implement sign-up logic here if needed
        }
    }
}