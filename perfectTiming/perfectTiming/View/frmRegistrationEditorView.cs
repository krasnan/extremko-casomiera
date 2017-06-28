using MetroFramework.Controls;
using perfectTiming.Helpers;
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
        Competitor actualCompetitor;

        public frmRegistrationEditorView(Registration item)
        {
            InitializeComponent();
            app = AppController.Instance;

            this.actualCompetitor = item.Competitor;
            categories = app.CategoryController.Categories;
            races = app.RaceController.Races;
            competitors = app.CompetitorController.Competitors;
            registrations = app.RegistrationController.Registrations;

            bsItem.DataSource = item;
            bsRaces.DataSource = races;



          //  List<Registration> reg = registrations.Where(r => r.Category.race_id == races.First().id).ToList()

            bsCategories.DataSource = categories;
            bsCompetitors.DataSource = competitors;

            cmbRaces.SelectedItem = item.Category.Race;
        }

        private void frmRegistrationEditorView_Load(object sender, EventArgs e)
        {
            cmbRaces_SelectedValueChanged(null, null);
        }

        private void cmbRaces_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbRaces.SelectedItem != null)
            {
                bsCategories.DataSource = categories.Where(c => c.race_id == ((Race)cmbRaces.SelectedItem).id).ToList();
                bsCategories.ResetBindings(false);
                cmbCategories_SelectedValueChanged(null, null);
                generateStartNumber();
            }
        }

        private void cmbCategories_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbCategories.SelectedItem != null) {
                List<Competitor> comp = competitors.Where(c => isNotRegistered((Category)cmbCategories.SelectedItem, c)).ToList();
                if (actualCompetitor != null && !comp.Contains(actualCompetitor))
                    comp.Add(actualCompetitor);
                bsCompetitors.DataSource = comp;
                if (actualCompetitor != null)
                    cmbCompetitors.SelectedItem = actualCompetitor;
                bsCompetitors.ResetBindings(false);
                generateStartNumber();
            }
        }
        private bool isNotRegistered(Category category, Competitor competitor) {
            Registration reg = registrations.FirstOrDefault(r => r.category_id == category.id && r.competitor_id == competitor.id);
            if (reg != null)
                return false;
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

            //Registration reg = (Registration)bsItem.Current;

            //RequestResult<Registration> result;
            //if (reg.id != 0)
            //    result = app.RegistrationController.Update(reg);
            //else
            //    result = app.RegistrationController.Add(reg);
            //if (result.Status == Enums.RequestStatus.Success)
            //    this.DialogResult = DialogResult.OK;

            //else
            //    lblErrorHolder.Text = result.Detail;
        }

        private void generateStartNumber()
        {
            if (cmbRaces.SelectedItem != null)
            {
                int count = registrations.Where(r => r.Category.race_id == ((Race)cmbRaces.SelectedItem).id).Count();
                iStartNumber.Text = (count + 1).ToString();
            }
        }

        private void cmbCompetitors_SelectionChangeCommitted(object sender, EventArgs e)
        {
            generateStartNumber();

        }
    }
}
