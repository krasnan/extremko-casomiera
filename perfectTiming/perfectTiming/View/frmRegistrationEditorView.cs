using perfectTiming.Controller;
using perfectTiming.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace perfectTiming.View
{
    public partial class frmRegistrationEditorView : MetroFramework.Forms.MetroForm
    {
        private AppController app;
        private List<Category> categories;
        private List<Race> races;
        private List<Competitor> competitors;
        private List<Registration> registrations;

        public frmRegistrationEditorView(Registration item)
        {
            InitializeComponent();
            app = AppController.Instance;

            categories = app.CategoryController.Categories;
            races = app.RaceController.Races;
            competitors = app.CompetitorController.Competitors;
            registrations = app.RegistrationController.Registrations;

            bsRaces.DataSource = races;

            cmbRaces.SelectedItem = item.Category.Race;
            cmbCategories.SelectedItem = item.Category;

            
            InitializeComponent();
        }

        private void cmbRaces_SelectedValueChanged(object sender, EventArgs e)
        {
            //bsCategories.DataSource = categories.Where(c => c.race_id == ((Race)cmbRaces.SelectedItem).id);
        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool result = isRegistered((Race)cmbRaces.SelectedItem,(Category)cmbCategories.SelectedItem, (Competitor)cmbCompetitors.SelectedItem);
        }
        private bool isRegistered(Race race, Category category, Competitor competitor) {
            //Registration r = registrations.FirstOrDefault(r => r.Category.race_id == race.id && r.category_id == category.id);
            return false;
        }

    }
}
