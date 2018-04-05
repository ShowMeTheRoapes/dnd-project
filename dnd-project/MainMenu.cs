using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dnd_project
{
    public partial class MainMenu : Form
    {
        private Button NewCharacter;
        private Button LoadCharacter;
        private Button Exit;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.NewCharacter = new System.Windows.Forms.Button();
            this.LoadCharacter = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewCharacter
            // 
            this.NewCharacter.Font = new System.Drawing.Font("Cardinal", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewCharacter.Location = new System.Drawing.Point(200, 117);
            this.NewCharacter.Name = "NewCharacter";
            this.NewCharacter.Size = new System.Drawing.Size(172, 54);
            this.NewCharacter.TabIndex = 0;
            this.NewCharacter.Text = "New Character";
            this.NewCharacter.UseVisualStyleBackColor = true;
            this.NewCharacter.Click += new System.EventHandler(this.newCharacter_Click);
            // 
            // LoadCharacter
            // 
            this.LoadCharacter.Font = new System.Drawing.Font("Cardinal", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadCharacter.Location = new System.Drawing.Point(200, 201);
            this.LoadCharacter.Name = "LoadCharacter";
            this.LoadCharacter.Size = new System.Drawing.Size(172, 54);
            this.LoadCharacter.TabIndex = 1;
            this.LoadCharacter.Text = "Load Character";
            this.LoadCharacter.UseVisualStyleBackColor = true;
            this.LoadCharacter.Click += new System.EventHandler(this.loadCharacter_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Cardinal", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(200, 285);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(172, 54);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // MainMenu
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(401, 455);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.LoadCharacter);
            this.Controls.Add(this.NewCharacter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.Text = "Dungeons & Dragons Character Builder";
            this.ResumeLayout(false);

        }

        private void newCharacter_Click(object sender, EventArgs e)
        {
            new NewCharacter().Show();
            Close();
        }

        private void loadCharacter_Click(object sender, EventArgs e)
        {
            new LoadCharacter().Show();
            Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if(Application.OpenForms.Count == 1)
            {
                Application.Exit();
            }
        }
    }
}
