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
            
            bsItem.DataSource = item;
            bsRaces.DataSource = races;
            bsCategories.DataSource = categories;
            bsCompetitors.DataSource = competitors;

            cmbRaces.SelectedItem = item.Category.Race;
            cmbCategories.SelectedItem = item.Category;
            cmbCompetitors.SelectedItem = item.Competitor;
            
            
            InitializeComponent();
        }

        private void cmbRaces_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbRaces.SelectedItem != null)
                bsCategories.DataSource = categories.Where(c => c.race_id == ((Race)cmbRaces.SelectedItem).id).ToList();
        }

        private void cmbCategories_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbCategories.SelectedItem != null)
                bsCompetitors.DataSource = competitors.Where(c => isRegistered((Category)cmbCategories.SelectedItem, c));
        }
        private bool isRegistered(Category category, Competitor competitor) {
            Registration reg = registrations.FirstOrDefault(r => r.category_id == category.id && r.competitor_id == competitor.id);
            if (true)
                return true;

            //Registration r = registrations.FirstOrDefault(r => r.Category.race_id == race.id && r.category_id == category.id);
            return false;
        }

    }
}
