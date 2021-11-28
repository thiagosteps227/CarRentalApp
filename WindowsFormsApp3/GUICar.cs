using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;





class GFrame : Form
{

    private Label lmain = new Label();
    private Label l1 = new Label(); private TextBox t1 = new TextBox();
    private Label l2 = new Label(); private TextBox t2 = new TextBox();
    private Label l3 = new Label(); private TextBox t3 = new TextBox();
    private Label lAlloc = new Label(); private TextBox tAlloc = new TextBox();
    private Label l4 = new Label(); private TextBox t4 = new TextBox();
    private Label l5 = new Label(); private TextBox t5 = new TextBox();
    private Label l6 = new Label(); private TextBox t6 = new TextBox();
    private Button b_7 = new Button(); private TextBox t7 = new TextBox();
    private Button b_8 = new Button(); private TextBox t8 = new TextBox();

    private ComboBox c3 = new ComboBox();
    private Button b_next = new Button(); private Button b_prev = new Button();
    private Button b_insert = new Button(); private Button b_exit = new Button();
    private Button b_clear = new Button();
    private Font f = new Font("Times New Roman", 15, FontStyle.Bold);
    private Font f2 = new Font("Times New Roman", 10, FontStyle.Bold);
    private Car[] list = new Car[20];
    private int count = 8;
    private int current = 0;

    private DataGridView dataGridView = new DataGridView();
    private BindingSource bindingSource1 = new BindingSource();
    private BindingSource bindingSource2 = new BindingSource();
    private BindingSource bindingSource3 = new BindingSource();

    /*
     private Panel buttonPanel = new Panel();
     private DataGridView songsDataGridView = new DataGridView();
     private Button addNewRowButton = new Button();
     private Button deleteRowButton = new Button();*/


    public GFrame() : base()
    {
        lmain.Text = "Car Rental App";
        InitializeList();
        lmain.Font = f;
        this.refresh();
        c3.Items.AddRange(new string[] { "Audi", "Ford", "Citroen" });
        b_next.Text = "Next"; b_prev.Text = "Prev";
        b_insert.Text = "Insert"; b_clear.Text = "Clear"; b_exit.Text = "Exit";
        l1.Text = "Name"; l2.Text = "Plate Number"; l3.Text = "Model"; l4.Text = "Rental Days";
        l5.Text = "Daily Rate"; l6.Text = "Final Price"; l6.Font = f2; l6.ForeColor = Color.Red;
        //b_7.Text = "Update RDays "; b_8.Text = "Update DRate";
        //lAlloc.Text = "Allocation";
        lmain.SetBounds(10, 10, 1000, 43);
        l1.SetBounds(22, 60, 70, 23); t1.SetBounds(102, 60, 90, 23);
        l2.SetBounds(22, 90, 70, 23); t2.SetBounds(102, 90, 90, 23);
        l3.SetBounds(22, 120, 70, 23); c3.SetBounds(102, 120, 90, 23);
        //lAlloc.SetBounds(22, 150, 70, 23); tAlloc.SetBounds(102, 150, 90, 23);
        l4.SetBounds(22, 180, 70, 23); t4.SetBounds(102, 180, 90, 23);
        l5.SetBounds(22, 210, 70, 23); t5.SetBounds(102, 210, 90, 23);
        l6.SetBounds(22, 240, 70, 23); t6.SetBounds(102, 240, 90, 23);
       // b_7.SetBounds(22, 270, 70, 23); t7.SetBounds(102, 270, 90, 23);
        //b_8.SetBounds(22, 300, 70, 23); t8.SetBounds(102, 300, 90, 23);

        b_next.SetBounds(12, 330, 90, 23); b_prev.SetBounds(102, 330, 90, 23);
        b_clear.SetBounds(12, 360, 90, 23); b_insert.SetBounds(102, 360, 90, 23);
        b_exit.SetBounds(62, 390, 90, 23);
        b_next.Click += new EventHandler(this.buttonNext_Click);
        b_prev.Click += new EventHandler(this.buttonPrev_Click);
        b_clear.Click += new EventHandler(this.buttonClear_Click);
        b_insert.Click += new EventHandler(this.buttonInsert_Click);
        b_exit.Click += new EventHandler(this.buttonExit_Click);

        b_7.Click += new EventHandler(this.buttonCAUpdate_Click);
        b_8.Click += new EventHandler(this.buttonExamUpdate_Click);


        Controls.Add(lmain);
        Controls.Add(l1); Controls.Add(t1);
        Controls.Add(l2); Controls.Add(t2);
        Controls.Add(l3); Controls.Add(c3);
        Controls.Add(lAlloc); Controls.Add(tAlloc);
        Controls.Add(l4); Controls.Add(t4);
        Controls.Add(l5); Controls.Add(t5);

        Controls.Add(l6); Controls.Add(t6);
        Controls.Add(b_7); Controls.Add(t7);
        Controls.Add(b_8); Controls.Add(t8);
        Controls.Add(b_next); Controls.Add(b_prev);
        Controls.Add(b_clear); Controls.Add(b_insert);
        Controls.Add(b_exit);
        this.Height = 460;
        this.Width = 850;
    }

    private void populateTable()
    {
       
    }

    private void InitializeList()
    {
        list[0] = new Audi("A3", "19D456", 5, 50);
        list[1] = new Ford("Ranger", "21RN433", 3, 60);
        list[2] = new Citroen("C3", "19D433", 4, 45);
        list[3] = new Audi("A4", "18RN678", 4, 50);

        list[4] = new Ford("Focus", "19D532", 3, 60);
        list[5] = new Citroen("C4", "21D833", 5, 70);
        list[6] = new Audi("A4", "17RN433", 4, 65);

        list[7] = new Citroen("Lounge", "21D934", 1, 80);
        //count = 8;

        //dataGridView settings
        dataGridView.SetBounds(210, 60, 600, 300);
        Controls.Add(dataGridView);
        dataGridView.ColumnCount = 6;
        dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Green;
        dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        dataGridView.ColumnHeadersDefaultCellStyle.Font =
            new Font(dataGridView.Font, FontStyle.Bold);

        dataGridView.Name = "Car List";
        dataGridView.AutoSizeRowsMode =
            DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;

        dataGridView.ColumnHeadersBorderStyle =
            DataGridViewHeaderBorderStyle.Single;
        dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
        dataGridView.GridColor = Color.Black;
        dataGridView.RowHeadersVisible = true;
        //column names
        dataGridView.Columns[0].Name = "Model";
        dataGridView.Columns[1].Name = "Name";
        dataGridView.Columns[2].Name = "Plate Number";
        dataGridView.Columns[3].Name = "Rental Days";
        dataGridView.Columns[4].Name = "Daily Rate";
        dataGridView.Columns[5].Name = "Final Price";
        dataGridView.Columns[5].DefaultCellStyle.Font =
            new Font(dataGridView.DefaultCellStyle.Font, FontStyle.Italic);

        //populating the table
        for (int i = 0; i < count; i++)
        {
            dataGridView.Rows.Add(list[i],
                list[i].readName(),
                list[i].readPlateNumber(),
                list[i].readRentalDays(),
                list[i].readDailyRate(),
                list[i].readTotalPrice());

        }



    }
    private void refresh()
    {
        t1.Text = list[current].readName();
        t2.Text = "" + list[current].readPlateNumber();
        c3.Text = "" + list[current].readCarModel();
        tAlloc.Text = "" + list[current].readRentalDetails();
        t4.Text = "" + list[current].readRentalDays();
        t5.Text = "" + list[current].readDailyRate();
        t6.Text = "" + list[current].readTotalPrice();
        //t7.Text = "0";
        //t8.Text = "0";

    }


    private void buttonNext_Click(object sender, EventArgs e)
    {
        if (current < (count - 1))
        {
            current++;
            refresh();
        }
    }



    private void buttonPrev_Click(object sender, EventArgs e)
    {
        if (current > 0)
        {
            current--;
            refresh();
        }
    }

    private void buttonClear_Click(object sender, EventArgs e)
    {
        t1.Text = "";
        t2.Text = "";
        t3.Text = "Bus; Eng; or Sc";
        tAlloc.Text = "Leave Blank";
        t4.Text = "0";
        t5.Text = "0";
        t6.Text = "Leave Blank";
        t7.Text = "Leave Blank";
        t8.Text = "Leave Blank";
    }

    private void buttonCAUpdate_Click(object sender, EventArgs e)
    {
        int ca = int.Parse(t7.Text);
        list[current].setRentalDays(ca);
        refresh();
    }
    private void buttonExamUpdate_Click(object sender, EventArgs e)
    {
        int ca = int.Parse(t8.Text);
        list[current].setDailyRate(ca);
        refresh();
    }


    private void buttonInsert_Click(object sender, EventArgs e)
    {
        if (count < 20)
        {
            String nm = t1.Text;
            String pn = t2.Text;
            String newCourseType = c3.Text;
            int rd = int.Parse(t4.Text);
            int dr = int.Parse(t5.Text);
            if (newCourseType == "Audi")
            {
                list[count] = new Audi(nm, pn, rd, dr);
                dataGridView.Rows.Add("Audi", nm, pn, rd, dr, rd * dr);
            }

            else if (newCourseType == "Ford")
            {
                list[count] = new Ford(nm, pn, rd, dr);
                dataGridView.Rows.Add("Ford", nm, pn, rd, dr, rd * dr);

            }
            else
            {
                list[count] = new Citroen(nm, pn, rd, dr);
                dataGridView.Rows.Add("Citroen", nm, pn, rd, dr, rd * dr);
                current = count;
                count++;
            }
        }
        refresh();
        
    }

    private void buttonExit_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
}

public class Test92
{
    public static void Main(string[] args)
    {
        Application.Run(new GFrame());
    }
}


