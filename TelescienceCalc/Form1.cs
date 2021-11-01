using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelescienceCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.dataLocation.DataSource = this._data.GetList();
            power.Text = "20";
        }

        private DataLocationModel _data = new DataLocationModel(); //datagrid table
        int toCalibNumber = 15; //number to next calibration

        Point telepad = new Point(0,0); //telepad position (offset)
        Point gps = new Point(0, 0); //gps position (offset)
        double powerOFFSET = 0;
        double bearingOFFSET = 0;

    

        private void calibrateDialog_Click(object sender, EventArgs e)
        {
            Calibration calibDialog = new Calibration();
            calibDialog.telepadX.Text = this.telepad.X.ToString();
            calibDialog.telepadY.Text = this.telepad.Y.ToString();
            if (calibDialog.ShowDialog() == DialogResult.OK)
            {
                // Set recommended calibratin
                toCalibNumber = 15;
                this.recommendedCalibration.Text = "15";
                this.telepad.X = Convert.ToInt32(calibDialog.telepadX.Text);
                this.telepad.Y = Convert.ToInt32(calibDialog.telepadY.Text);
                this.gps.X = Convert.ToInt32(calibDialog.gpsX.Text);
                this.gps.Y = Convert.ToInt32(calibDialog.gpsY.Text);
                try
                {
                    //power offset calculation
                    powerOFFSET = Convert.ToInt32(Math.Round(20-Math.Sqrt(10*GetLengthBetweenPoints(telepad,gps))));
                    this.powerOFFSETlabel.Text = powerOFFSET.ToString();
                    //bearing offset calculation
                    if (this.gps.X < this.telepad.X) bearingOFFSET = Math.Round(Math.Atan(Math.Abs(Convert.ToDouble(this.gps.X - this.telepad.X)) / Math.Abs(Convert.ToDouble(this.gps.Y - this.telepad.Y))) * (180 / Math.PI) * -1);
                    else bearingOFFSET = Math.Round(Math.Atan(Math.Abs(Convert.ToDouble(this.gps.X - this.telepad.X)) / Math.Abs(Convert.ToDouble(this.gps.Y - this.telepad.Y))) * (180 / Math.PI));
                    
                    this.bearingOFFSETlabel.Text = bearingOFFSET.ToString();
                }
                catch
                {
                    new MessageError().ShowDialog();
                }
            }
        }

        private void increaseCalibration_Click(object sender, EventArgs e)
        {
            toCalibNumber += 1;
            this.recommendedCalibration.Text = toCalibNumber == 0 ? "Now" : Convert.ToString(toCalibNumber);
        }

        private void decreaseCalibration_Click(object sender, EventArgs e)
        {
            if(toCalibNumber > 0) toCalibNumber -= 1;
            this.recommendedCalibration.Text = toCalibNumber == 0 ? "Now" : Convert.ToString(toCalibNumber);
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            try
            {

                if (toCalibNumber > 0) toCalibNumber -= 1;
                this.recommendedCalibration.Text = toCalibNumber == 0 ? "Now" : Convert.ToString(toCalibNumber);

                double Elevation = 0;
                double Bearing = 0;
                double D = 0;
                double Dmax = 0;
                Point dest = new Point(Convert.ToInt32(this.destinationX.Text),Convert.ToInt32(this.destinationY.Text));
                double x = Math.Abs(this.telepad.X - Convert.ToDouble(this.destinationX.Text));
                double y = Math.Abs(this.telepad.Y - Convert.ToDouble(this.destinationY.Text));

                D = Math.Sqrt(Math.Pow(x,2)+Math.Pow(y,2));

                Dmax = (Math.Pow((Convert.ToDouble(power.Text) - powerOFFSET), 2)) / 10;
                Elevation = (Math.Asin(D/Dmax) * (180 / Math.PI)) / 2;
                elevation.Text = Math.Round(Elevation).ToString();

                if(dest.Y >= this.telepad.Y) //North
                {
                    if(dest.X >= this.telepad.X)//North-East
                    {
                        Bearing = (Math.Atan(x / y) * (180 / Math.PI)) + 0 - bearingOFFSET;
                    }
                    else//North-West
                    {
                        Bearing = (Math.Atan(y / x) * (180 / Math.PI)) + 270 - bearingOFFSET;
                    }
                }
                else //South
                {
                    if (dest.X >= this.telepad.X)//South-East
                    {
                        Bearing = (Math.Atan(y / x) * (180 / Math.PI)) + 90 - bearingOFFSET;
                    }
                    else//South-West
                    {
                        Bearing = (Math.Atan(x / y) * (180 / Math.PI)) + 180 - bearingOFFSET;
                    }
                }
                bearing.Text = Math.Round(Bearing,2).ToString();
            }
            catch
            {
                new MessageError().ShowDialog();
            }
        }

        private void deleteLocation_Click(object sender, EventArgs e)
        {
            if (this.dataLocation.SelectedRows.Count > 0)
            {
                try
                {
                    this._data.DeleteLocation(this.dataLocation.CurrentRow.Index);
                }
                catch { }
            }
        }

        private void saveLocation_Click(object sender, EventArgs e)
        {
            try
            {
                Location loc = new Location();
                loc.Name = this.name.Text;
                loc.Position_X = Convert.ToInt32(this.destinationX.Text);
                loc.Position_Y = Convert.ToInt32(this.destinationY.Text);
                this._data.AddLocation(loc);
            }
            catch
            {
                new MessageError().ShowDialog();
            }
        }

        private void loadLocation_Click(object sender, EventArgs e)
        {
            if (this.dataLocation.SelectedRows.Count > 0)
            {
                try
                {
                    Location loc = this._data.GetLocation(this.dataLocation.CurrentRow.Index);
                    this.destinationX.Text = loc.Position_X.ToString();
                    this.destinationY.Text = loc.Position_Y.ToString();
                    this.name.Text = loc.Name;
                }
                catch { }
            }
        }
        private double GetLengthBetweenPoints(Point first, Point second)
        {
            return Math.Sqrt(Math.Pow(first.X - second.X, 2) + Math.Pow(first.Y - second.Y, 2));
        }

        private void saveData_Click(object sender, EventArgs e)
        {
            
            Stream myStream;
            SaveFileDialog SaveLocDialog = new SaveFileDialog();

            SaveLocDialog.Filter = "Location file (*.csv)|*.csv|All files (*.*)|*.*";
            SaveLocDialog.FilterIndex = 1;
            SaveLocDialog.RestoreDirectory = true;

            if (SaveLocDialog.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = SaveLocDialog.OpenFile()) != null)
                {
                    StreamWriter writer = new StreamWriter(myStream);

                    
                    foreach (Location item in this._data.GetList())
                    {
                        writer.WriteLine(item.Name + ";" + item.Position_X + ";" + item.Position_Y);
                    }
                    writer.Close();
                    myStream.Close();
                }
            }
            
        }

        private void loadData_Click(object sender, EventArgs e)
        {
            Stream loader = null;
            OpenFileDialog LoadLocDialog = new OpenFileDialog();

            LoadLocDialog.Filter = "Location file (*.csv)|*.csv|All files (*.*)|*.*";
            LoadLocDialog.FilterIndex = 1;
            LoadLocDialog.RestoreDirectory = true;

            if (LoadLocDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((loader = LoadLocDialog.OpenFile()) != null)
                    {
                        using (loader)
                        {
                            this._data.DeleteAllLocations();
                            StreamReader reader = new StreamReader(loader);
                            while (!reader.EndOfStream)
                            {
                                Location tmp = new Location();
                                string[] buffer = reader.ReadLine().Split(';');
                                tmp.Name = buffer[0];
                                tmp.Position_X = Convert.ToInt32(buffer[1]);
                                tmp.Position_Y = Convert.ToInt32(buffer[2]);
                                this._data.AddLocation(tmp);
                            }
                            reader.Close();
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Error: Could not read file!");
                }
            }
        }
    }
}
