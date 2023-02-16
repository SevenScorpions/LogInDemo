﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogInDemo.DTO;
using LogInDemo.DAO;
namespace LogInDemo
{
    public partial class mainFrm : Form
    {
        public User user;
        public mainFrm()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            loadArea();
            loadMovie();

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MMMM yyyy";
            dateTimePicker1.ShowUpDown = true;
            textBoxToday.Text = DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();

            //MANAGE
            string query1 = @"select [Username],[Password],[Name],[Birthday],[Email],[Phone],[Gender],[Point],[NID] from customer where username != 'admin'";
            DataTable data1 = DataProvider.Instance.ExcuteQuery(query1);
            dataGridView1.DataSource = data1;
            string query2 = @"select * from food where fid != ''";
            DataTable data2 = DataProvider.Instance.ExcuteQuery(query2);
            dataGridView2.DataSource = data2;
            string query3 = @"select BID, Username, SID, Term, Total, DCreate, FID from bill";
            DataTable data3 = DataProvider.Instance.ExcuteQuery(query3);
            dataGridView3.DataSource = data3;
            string query4 = @"select BID, Username, SID, Term, Total, DCreate, FID from bill where DAY(DCreate) = DAY(GETDATE())";
            DataTable data4 = DataProvider.Instance.ExcuteQuery(query4);
            dataGridView4.DataSource = data4;

            for (int i = 0; i <= dataGridView1.ColumnCount - 1; i++)
            {
                dataGridView1.Columns[i].ReadOnly = true;
            }

            for (int i = 0; i <= dataGridView2.ColumnCount - 1; i++)
            {
                dataGridView2.Columns[i].ReadOnly = true;
            }

            for (int i = 0; i <= dataGridView3.ColumnCount - 1; i++)
            {
                dataGridView3.Columns[i].ReadOnly = true;
            }

            for (int i = 0; i <= dataGridView4.ColumnCount - 1; i++)
            {
                dataGridView4.Columns[i].ReadOnly = true;
            }

            //Get sum
            int monthpick = dateTimePicker1.Value.Month;
            int yearpick = dateTimePicker1.Value.Year;

            string sql1 = @"select SUM(total) as total from Bill where DAY(DCreate) = DAY(GETDATE())";
            DataTable dataDay = DataProvider.Instance.ExcuteQuery(sql1);
            object ott1 = dataDay.Compute("Sum(total)", string.Empty);
            if (!ott1.Equals(DBNull.Value))
            {
                int inp1 = int.Parse(ott1.ToString());
                label18.Text = label18.Text + ":   " + formatMoney(inp1);
            }
            else
            {
                label18.Text = label18.Text + ":   " + formatMoney(0);
            }

            string sql2 = @"select SUM(total) as total from Bill where MONTH(DCreate) = '" + monthpick + "' AND YEAR(DCreate) = '" + yearpick + "'";
            DataTable dataMonth = DataProvider.Instance.ExcuteQuery(sql2);
            object ott2 = dataMonth.Compute("Sum(total)", string.Empty);
            if(!ott2.Equals(DBNull.Value))
            {
                int inp2 = int.Parse(ott2.ToString());
                label17.Text = label17.Text + ":   " + formatMoney(inp2);
            }
            else
            {
                label17.Text = label17.Text + ":   " + formatMoney(0);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void loadArea()
        {
            List<Area> areas = AreaDAO.Instance.getAreaList();
            cbArea.DataSource = areas;
            cbArea.DisplayMember = "name";
        }

        private void loadCinemaByAID(string aid)
        {
            List<Cinema> cinemas = CinemaDAO.Instance.getCinemaListByAID(aid);
            cbCinema.DataSource = cinemas;
            cbCinema.DisplayMember = "name";
        }
        private void loadMovie()
        {
            List<Movie> movies = MovieDAO.Instance.getMovieList();
            cbMovie.DataSource = movies;
            cbMovie.DisplayMember = "name";
        }
        private void loadSession()
        {
            sessionFlw.Controls.Clear();
            List<Session> sessions = SessionDAO.Instance.getSessionListByCID(((Cinema)cbCinema.Tag).Id, ((DateTime)timePick.Tag).Date, ((Movie)cbMovie.Tag).Id);
            foreach(Session session in sessions)
            {
                Button bttn = new Button() { Width = SessionDAO.width, Height = SessionDAO.height };
                bttn.Text = ((Movie)cbMovie.Tag).Name ;
                if(session.Format!="Normal")
                {
                    bttn.Text += " (" + session.Format + ")";
                }
                bttn.Click += Bttn_Click;
                bttn.Text += "\n" + session.Subtitle + " - Time Start: " + session.Date.TimeOfDay;
                bttn.BackColor = Color.DarkCyan;
                bttn.ForeColor = Color.White;
                bttn.FlatStyle = FlatStyle.Flat;
                bttn.FlatAppearance.BorderSize = 0;
                bttn.TextAlign = ContentAlignment.MiddleLeft;
                bttn.Tag = session;
                sessionFlw.Controls.Add( bttn );
            }
            
        }

        private void Bttn_Click(object? sender, EventArgs e)
        {
            Button button = sender as Button;
            buyTicketFrm frm = new buyTicketFrm(user, (Session)button.Tag, (Movie)cbMovie.Tag);
            MessageBox.Show("You need to click Reload to select chair!");
            frm.ShowDialog();
        }

        private void loadPro5()
        {
            pro4Username.Text = user.Username;
            pro4BirthDay.Value = user.Birthdate;
            pro4Email.Text = user.Email;
            pro4Id.Text = user.Nid;
            pro4Name.Text = user.Name;
            pro4Phone.Text = user.Phone;
            if (user.Gender=="F")
            {
                genderF.Checked = true;
            }
            else
            {
                genderM.Checked = true;
            }
        }
        private void pro4Tab_Click(object sender, EventArgs e)
        {

        }

        private void mainFrm_Load(object sender, EventArgs e)
        {
            cbArea.SelectedIndex = -1; 
            cbCinema.SelectedIndex = -1;
            cbCinema.Enabled = false;
            cbMovie.SelectedIndex = -1;
            searchBttn.Enabled = false;

            if (user.Username != "admin")
            {
                settingTab.TabPages.RemoveAt(3);
                settingTab.TabPages.RemoveAt(3);
                settingTab.TabPages.RemoveAt(3);
            }
        }

        private void appExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to close the program?", "", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                return;
            }
            Environment.Exit(0);
        }

        private void appSignOut_Click(object sender, EventArgs e)
        {
            
            this.Close();
            
            
        }

        private void cbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            string aid = "";
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
            {
                return;
            }
            Area a = cb.SelectedItem as Area;
            aid = a.Id;
            loadCinemaByAID(aid);
            cbCinema.SelectedIndex = -1;
            cbCinema.Enabled = true;
        }

        private string formatMoney(int p)
        {
            if(p == 0)
            {
                return 0 + " VND";
            }
            string str = "";
            if (p < 1000)
            {
                return p.ToString();
            }
            while (p > 0)
            {
                int thr = p % 1000;
                string s = p.ToString();
                if (p >= 1000)
                {
                    if (thr == 0)
                    {
                        s = "0" + "0" + "0";
                    }
                    else if (thr < 100 && thr >= 10)
                    {
                        s = "0" + s;
                    }
                    else if (thr < 10)
                    {
                        s = "0" + "0" + s;
                    }
                }
                p /= 1000;
                if (str != "")
                {
                    str = s + "," + str;
                }
                else
                {
                    str = s + str;
                }
            }
            return str + " VND";
        }

        private void timePick_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = timePick.Value;
            timePick.Tag = date;
            searchBttn.Enabled = true;
        }

        private void searchBttn_Click(object sender, EventArgs e)
        {
            loadSession();
        }

        private void cbCinema_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
            {
                return;
            }
            Cinema a = cb.SelectedItem as Cinema;
            cbCinema.Tag = a;
        }

        private void cbMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
            {
                return;
            }
            Movie a = cb.SelectedItem as Movie;
            cbMovie.Tag = a;
        }

        private void pro4Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void settingTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadPro5();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new changePassFrm();
            frm.user = user;
            frm.ShowDialog();
            user = frm.user;
        }

        private void saveChangeBttn_Click(object sender, EventArgs e)
        {
            if (pro4Password.Text == user.Password) {
                string gender = "";
                if (genderF.Checked == true)
                {
                    gender = "F";
                }
                else
                {
                    gender = "M";
                }
                string query = string.Format(@"UPDATE CUSTOMER SET BOD = '{0}', GENDER = '{1}', EMAIL = '{2}', PHONE = '{3}', NID = '{4}', NAME = N'{5}' where username = '{6}'",((DateTime)pro4BirthDay.Value).Date,gender,pro4Email.Text,pro4Phone.Text,pro4Id.Text,pro4Name.Text,pro4Username.Text);
                DataProvider.Instance.ExcuteQuery(query);
                user = UserDAO.Instance.getAccount(user.Username,user.Password);
                MessageBox.Show("Change profile information successfully");
            }
            else if(pro4Password.Text=="")
            {
                MessageBox.Show("Enter the password to save your change.");
            }
            else
            {
                MessageBox.Show("Wrong password.");
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to close the program?", "", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                return;
            }
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
                button2.BackgroundImage = global::LogInDemo.Properties.Resources.download_icon_MINIMIZE_131994911324916820_512;
                foreach (Control control in hisFlw.Controls)
                {
                    control.Width = hisFlw.Width;
                }
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                button2.BackgroundImage = global::LogInDemo.Properties.Resources.maximize;
                foreach(Control control in hisFlw.Controls)
                {
                    control.Width = hisFlw.Width;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void tabHis_Enter(object sender, EventArgs e)
        {
            hisFlw.Controls.Clear();
            List<Bill> bills = BillDAO.Instance.getUserBill(user.Username);
            foreach(Bill bill in bills)
            {
                Button bttn = new Button() { Width = hisFlw.Width, Height = 90};
                string query = @"select * from session where sid='" + bill.Sid + "'";
                DataTable data = DataProvider.Instance.ExcuteQuery(query);
                Session session = new Session(data.Rows[0]);
                query = @"select * from movie where mid='" + session.Mid + "'";
                data = DataProvider.Instance.ExcuteQuery(query);
                Movie movie = new Movie(data.Rows[0]);
                query = @"select Cinema.cid,cinema.cname,cinema.aid from cinema,room,session where cinema.cid=room.cid and room.rid = session.rid and session.rid = '" + session.Room + "'";
                data = DataProvider.Instance.ExcuteQuery(query);
                Cinema cinema = new Cinema(data.Rows[0]);
                List<Ticket> tickets = TicketDAO.Instance.getTicketList(bill.Id);
                bttn.Text = "Bill: " + bill.Id + " - " + cinema.Name + "\n" + movie.Name;
                if (session.Format != "Normal")
                {
                    bttn.Text += " (" + session.Format + ")";
                }
                bttn.Text += " - Time: " + session.Date.ToString("dd/MM/yyyy HH:mm");
                bttn.Text += "\nTotal: " + session.Price*tickets.Count + " VND";
                bttn.Enabled = false;
                bttn.BackColor = Color.Turquoise;
                bttn.ForeColor = Color.White;
                bttn.FlatStyle = FlatStyle.Flat;
                bttn.FlatAppearance.BorderSize = 0;
                bttn.TextAlign = ContentAlignment.MiddleLeft;
                hisFlw.Controls.Add(bttn);
                foreach(Ticket ticket in tickets)
                {
                    Button bttnt = new Button() { Width = hisFlw.Width - 2, Height = 40 };
                    bttnt.Text = "ID: " +ticket.Id + " - Chair number: " + ticket.Chair; 
                    bttnt.Enabled = false;
                    bttnt.BackColor = Color.PaleGoldenrod;
                    bttnt.ForeColor = Color.Black;
                    bttnt.FlatStyle = FlatStyle.Flat;
                    bttnt.FlatAppearance.BorderSize = 0;
                    bttnt.TextAlign = ContentAlignment.MiddleLeft;
                    hisFlw.Controls.Add(bttnt);
                }
            }
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int monthpick = dateTimePicker1.Value.Month;
            int yearpick = dateTimePicker1.Value.Year;
            //MessageBox.Show("" + monthpick + " - " + yearpick);
            string query3 = @"select BID, Username, SID, Term, Total, DCreate, FID from bill where MONTH(DCreate) = '" + monthpick + "' AND YEAR(DCreate) = '" + yearpick + "'";
            DataTable data3 = DataProvider.Instance.ExcuteQuery(query3);
            dataGridView3.DataSource = data3;
        }

        private void sessionFlw_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxToday_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabRevenue_Click(object sender, EventArgs e)
        {

        }
    }
}
