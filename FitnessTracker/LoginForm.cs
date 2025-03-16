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
            var username = txtUsername.Text;
            var password = txtPassword.Text;

            var filter = Builders<BsonDocument>.Filter.Eq("Username", username) & Builders<BsonDocument>.Filter.Eq("Password", password);
            var user = usersCollection.Find(filter).FirstOrDefault();

            if (user != null)
            {
                MessageBox.Show("Login successful!");
                this.Hide();
                var mainForm = new Form1(user["_id"].ToString()); // Pass user ID to Form1
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            var existingUser = usersCollection.Find(new BsonDocument { { "Username", username } }).FirstOrDefault();
            if (existingUser != null)
            {
                MessageBox.Show("Username already exists.");
                return;
            }

            var newUser = new BsonDocument
            {
                { "Username", username },
                { "Password", password }
            };

            usersCollection.InsertOne(newUser);
            MessageBox.Show("User registered successfully!");
        }
    }
}