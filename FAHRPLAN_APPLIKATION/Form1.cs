using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FAHRPLAN_APPLIKATION
{
    public partial class Form1 : Form
    {
        Transport transport = new Transport();
        Coordinate coordinate = new Coordinate();
        public Form1()
        {
            InitializeComponent();
        }

        //Methoden
        private void Get_Stations(string text, ListBox listBox)
        {
            if (text.Length >= 3)
            {
                listBox.Items.Clear();
                Stations stations = transport.GetStations(text);
                foreach (Station station in stations.StationList)
                {
                    listBox.Items.Add(station.Name);
                    listBox.Visible = true;
                    listBox.BringToFront();
                }
            }
        }

        public string Get_TableFromDataGrid()
        {
            StringBuilder strTable = new StringBuilder();
            try
            {
                strTable.Append("<table border='1' cellpadding='0' cellspacing='0'>");
                strTable.Append("<tr>");
                foreach (DataGridViewColumn col in DTG_verbindungen.Columns)
                {
                    strTable.AppendFormat("<th>{0}</th>", col.HeaderText);
                }
                strTable.Append("</tr>");
                for (int i = 0; i < DTG_verbindungen.Rows.Count; i++)
                {
                    strTable.Append("<tr>");
                    foreach (DataGridViewCell cell in DTG_verbindungen.Rows[i].Cells)
                    {
                        if (cell.Value != null)
                        {
                            strTable.AppendFormat("<td>{0}</td>", cell.Value.ToString());
                        }
                    }
                    strTable.Append("</tr>");
                }
                strTable.Append("</table>");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return strTable.ToString();
        }

        private void Get_Grid()
        {
            Cursor.Current = Cursors.WaitCursor;
            LBL_laden.Visible = true;
            DataTable dtt_connections = new DataTable();
            dtt_connections.Columns.Add("Datum");
            dtt_connections.Columns.Add("Von");
            dtt_connections.Columns.Add("Abfahrt");
            dtt_connections.Columns.Add("Nach");
            dtt_connections.Columns.Add("Ankunft");
            dtt_connections.Columns.Add("Gleis");

            //Abfrage
            Connections connections = transport.GetConnections(TXT_von.Text, TXT_nach.Text, DTP_datum.Value.ToString("yyyy-MM-dd"), DTP_zeit.Text);
           
            //Jedes Resulatat zur Liste hinzufügen
            foreach (Connection connection in connections.ConnectionList)
            {
                dtt_connections.Rows.Add(Get_Date(connection.From.Departure), connection.From.Station.Name, Get_Time(connection.From.Departure), connection.To.Station.Name, Get_Time(connection.To.Arrival), connection.To.Platform);
            }

            DTG_verbindungen.DataSource = dtt_connections;
            LBL_laden.Visible = false;
            UseWaitCursor = false;
        }

        private void Get_2_Grid()
        {
            DataTable dtt_routes = new DataTable();
            dtt_routes.Columns.Add("Zeit");
            dtt_routes.Columns.Add("Nach");
            dtt_routes.Columns.Add("Linie");

            //Definieren der Station für die Abfahrtstafel (Inhalt der Textbox wird übergeben)
            Station station = transport.GetStations(BTN_von_2.Text).StationList.First();
            StationBoardRoot departures = transport.GetStationBoard(station.Name, station.Id); //Beispiel für station.name ist Luzern, Beispiel für station.Id = 8505000

            foreach (StationBoard station_b in departures.Entries)
            {
                dtt_routes.Rows.Add(Get_Time(station_b.Stop.Departure.ToString()), station_b.To, (station_b.Category + " " + station_b.Number)); //Jede Linie die gefunden wird, wird hier durchgegangen
            }

            DTG_Verbindungen_2.DataSource = dtt_routes;
        }

        private string Get_Date(string date1)
        {
            string date2 = date1.Remove(10);
            DateTime date3 = Convert.ToDateTime(date2);
            return date3.ToString("dd.MM.yyyy");
        }

        private string Get_Time(string time1) //Zeit kommt so 13:25:00 und die letzen 2 Stellen :00 werden hier gelöscht.
        {
            string time2 = time1.Remove(0, 11);
            time2 = time2.Remove(5);
            return time2;
        }

        private void Create_GmapStation(string x, string y)
        {
            string url = "https://www.google.ch/maps/place/" + x + "," + y;
            WEB_google_maps.Navigate(url);
        }

        private void Switch_txt(TextBox textBox1, TextBox textBox2)
        {
            string temp = textBox1.Text;
            textBox1.Text = textBox2.Text;
            textBox2.Text = temp;
        }

        //Navigation 
        private void Form_Fahrplan_Load(object sender, EventArgs e)
        {
            PNL_1.Visible = true;
            PNL_2.Visible = false;
            PNL_3.Visible = false;
            LBL_laden.Visible = false;
        }

        private void BTN_nav1_Click(object sender, EventArgs e)
        {
            PNL_1.Visible = true;
            PNL_2.Visible = false;
            PNL_3.Visible = false;
        }

        private void BTN_nav2_Click(object sender, EventArgs e)
        {
            PNL_1.Visible = false;
            PNL_2.Visible = true;
            PNL_3.Visible = false;
        }

        private void BTN_nav3_Click(object sender, EventArgs e)
        {
            PNL_1.Visible = false;
            PNL_2.Visible = false;
            PNL_3.Visible = true;
        }

        //Menu1
        private void BTN_google_maps_Click(object sender, EventArgs e)
        {
            PNL_1.Visible = false;
            PNL_2.Visible = false;
            PNL_3.Visible = true;
        }

        private void TXT_von_TextChanged(object sender, EventArgs e)
        {
            Get_Stations(TXT_von.Text, LBX_von);
        }

        private void TXT_nach_TextChanged(object sender, EventArgs e)
        {
            Get_Stations(TXT_nach.Text, LBX_nach);
        }

        private void LBX_von_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TXT_von.Text = LBX_von.SelectedItem.ToString();
            BTN_suche.Focus();
            LBX_von.Visible = false;
        }

        private void LBX_nach_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TXT_nach.Text = LBX_nach.SelectedItem.ToString();
            BTN_suche.Focus();
            LBX_nach.Visible = false;
        }

        //Menu2
        private void BTN_suche_2_Click(object sender, EventArgs e)
        {
            if (BTN_von_2.Text != string.Empty)
            {
                Get_2_Grid();
            }
            else
            {
                MessageBox.Show("Bitte geben Sie einen Ort ein!");
            }
        }

        private void BTN_von_2_TextChanged(object sender, EventArgs e)
        {
            Get_Stations(BTN_von_2.Text, LBX_von_2);
        }

        private void LBX_von_2_DoubleClick(object sender, EventArgs e)
        {
            BTN_von_2.Text = LBX_von_2.SelectedItem.ToString();
            BTN_suche_2.Focus();
            LBX_von_2.Visible = false;
        }

        //Menu3
        private void BTN_suche_3_Click(object sender, EventArgs e)
        {
            if (TXT_station.Text != string.Empty)
            {
                Stations stations = transport.GetStations(TXT_station.Text);
                Station station = stations.StationList[0];
                Create_GmapStation(Convert.ToString(station.Coordinate.XCoordinate).Replace(',', '.'), Convert.ToString(station.Coordinate.YCoordinate).Replace(',', '.'));
            }
            else
            {
                MessageBox.Show("Bitte geben Sie einen Ort ein!");
            }
        }

        private void TXT_station_TextChanged(object sender, EventArgs e)
        {
            Get_Stations(TXT_station.Text, LBX_station);
        }

        private void lbx_3_start_DoubleClick(object sender, EventArgs e)
        {
            TXT_station.Text = LBX_station.SelectedItem.ToString();
            BTN_suche_3.Focus();
            LBX_station.Visible = false;
        }

        private void BTN_suche_Click_1(object sender, EventArgs e)
        {
            if (TXT_von.Text != string.Empty)
            {
                Get_Grid();
            }
            else
            {
                MessageBox.Show("Bitte geben Sie zwei Orte ein!");
            }
        }

        private void btn_exit_Click_1(object sender, EventArgs e)
        {
            Form2 exit = new Form2();
            exit.Visible = false;
            if (exit.ShowDialog(this) == DialogResult.OK)
            {
                Close();
            }
            else
            {
                exit.Dispose();
            }
        }

        private void PB_switch_Click(object sender, EventArgs e)
        {
            Switch_txt(TXT_von, TXT_nach);
            LBX_von.Visible = false;
            LBX_nach.Visible = false;
        }

        private void BTN_email_Click(object sender, EventArgs e)
        {
            if (TXT_email.Text == "")
                MessageBox.Show("Bitte geben Sie eine Email-Adresse ein!");
            else
            {
                try
                {
                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress("ruthranm318@gmail.com");
                    mail.To.Add(new MailAddress(Convert.ToString(this.TXT_email)));
                    mail.Subject = "Fahrplan";
                    mail.Body = "Hallo, hier ein Fahrplan, den ich mit dir teilen wollte. ";
                    mail.Body += "<b>" + Get_TableFromDataGrid() + "</b>";
                    mail.IsBodyHtml = true;
                    SmtpClient SmtpServer = new SmtpClient();
                    SmtpServer.Host = "smtp.gmail.com";
                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("ruthranm318@gmail.com", "qwertz12345678");
                    SmtpServer.EnableSsl = true;
                    SmtpServer.Send(mail);
                    MessageBox.Show("Email wurde erfolgreich gesendet");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void LBL_datum_Click(object sender, EventArgs e)
        {

        }

        private void DTG_verbindungen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PNL_3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PNL_2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PNL_1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}