

namespace Films
{
    public partial class Form1 : Form
    {
        private readonly AddDataInBase dab = new AddDataInBase();
        private readonly UpdateDataInBase deb = new UpdateDataInBase();
        public Form1()
        {
            InitializeComponent();
            Getdata();
        }
        private void Getdata()
        {
            dwg1.DataSource = db.GetFilms();
        }

        
        private void Addbtn_Click(object sender, EventArgs e)
        {
            var films = new Films
            {
                name = txtName.Text,
                autor = txtAutor.Text,
                year = txtYear.Text,
            };
            dab.AddFilm(films);
            Getdata();


        }
        private void Table_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    RowDelete(sender as DataGridView);
                    break;
            }
        }

        private void RowDelete(DataGridView dataGrid)
        {
            int rowIndx = dataGrid.SelectedCells[0].RowIndex;
            var row = dataGrid.Rows[rowIndx];
            var data = row.DataBoundItem;

            if (data is Films films)
            {
                DeleteDataInBase.RemoveFilms(films.Id);
                dataGrid.DataSource = db.GetFilms();
            }
        }
        private void CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var dataGrid = (DataGridView)sender;
            if (dataGrid.SelectedCells.Count == 0) return;

            int rowIndex = dataGrid.SelectedCells[0].RowIndex;
            var data = dataGrid.Rows[rowIndex].DataBoundItem;

            if (data is Films film)
            {
                try
                {
                    deb.Update(film);
                    Getdata();
                }
                catch (Exception)
                {
                    
                }
                
            }
            
        }
    }
}
