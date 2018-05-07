using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Geomagnetic_Sensor_GUI_WAF_
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();



        }

        // Variables --------------

        string[] ports;  // Variable destinada a ser contenedor de la lista de Puertos COM

        string read_command = "$0wn01,71$1";
        string get_x = "$0wnA4rm$1";
        string get_y = "$0wnA7rm$1";
        string get_z = "$0wnAArm$1";

        List<Point> PointDB = new List<Point>();

        int cols, rows; // # de columnas y filas





        //--------------------------


        // Definicion Subclasses Requeridas

        Graph g = new Graph();

        //Fin de Subclasses requeridas


        // Threads necesarios


        //

        public static void Check_Parameters(SerialPort s)
        {
            while (true)
            {
                if (s.PortName.Length < 0)
                {

                }


            }


        }


        public double Teslas(int numero) // Convierte de nivel a su respectivo valor en MicroTeslas, para nanoTeslas, se multiplica por 1000
        {
            double teslas = 0;

            teslas = (double)numero / 75.0;

            teslas = teslas * 1000.0;

            return teslas;
        }

        public int Sin_signo_a_Con_signo(int numero)  // Convierte un numero (Hexadecimal -> decimal) recien unsigned a signed 
        {


            if (numero > 8388607)
            {
                numero = numero - 16777216;
            }


            return numero;
        }

        public double Magnitude(double x, double y, double z)  // Obtiene la magnitud del campo magnético usando los componentes XYZ proporcionados
        {
            double mag = 0;

            mag = x * x + y * y + z * z;

            mag = Math.Sqrt(mag);
            mag = Math.Round(mag, 1);

            return mag;
        }

        public double Lectura(string comando_lectura) // Obtiene lectura de un componente del campo mangnetico
        {
            int componente;
            double final = 0.0;
            string V_no_procesado;


            //System.Windows.Forms.MessageBox.Show("Funcion de lectura");



            serialPort1.Write(comando_lectura);

            Task.Delay(400).Wait();

            //consoleTxt_box.AppendText(" " + serialPort1.ReadExisting() + " ");

            V_no_procesado = serialPort1.ReadExisting();

            //consoleTxt_box.AppendText(V_no_procesado + " ");

            componente = Convert.ToInt32(V_no_procesado, 16);

            //consoleTxt_box.AppendText(componente + " ");

            componente = Sin_signo_a_Con_signo(componente);


            final = Teslas(componente);


            Task.Delay(5).Wait();

            return final;
        }

        public void Do_reading() // Da al sensor la orden de obtener una lectura del campo magnetico
        {
            //System.Windows.Forms.MessageBox.Show("El sensor hace una lectura");

            serialPort1.Write(read_command);

        }


        public Point GetPoint()
        {
            //System.Windows.Forms.MessageBox.Show("Funcion de lectura");
            Point punto = new Point(Lectura(get_x), Lectura(get_y), Lectura(get_z));

            return punto;
        }

        public void ToDB(Point punto)
        {
            PointDB.Add(punto);

        }


        public void Build_PointDB()
        {
            consoleTxt_box.ResetText();
            int char_counter = 65;


            cols = int.Parse(cols_txtbx.Text);
            rows = int.Parse(rows_txtbx.Text);

            int k = cols * rows;

            if (!serialPort1.IsOpen || cols * rows == 0)
            {
                //Should not reach here

                consoleTxt_box.AppendText("No serial port connected or invalid size values");

                return;


            }

            //consoleTxt_box.AppendText("\n" + "Note: The model will be build in a west->East from South to North manner. Press Enter when prompted after placing the sensor in its position");


            //System.Windows.Forms.MessageBox.Show("Process is about to begin");

            for (int i = 0; i < k; i++)
            {
                //System.Windows.Forms.MessageBox.Show("Press Enter to get point: " + i.ToString());



                while (true)
                {

                    if (Arduino.BytesToRead > 0)
                    {
                        Arduino.DiscardInBuffer();
                        break;
                    }



                }

                ToDB(GetPoint());
                PointDB[i].ID = (char)char_counter;

                if ((char)char_counter == 'I' || (char)char_counter == 'E')
                {
                    PointDB[i].max = 3000;
                    PointDB[i].min = 3000;
                }

                string c = PointDB[i].ID.ToString();
                consoleTxt_box.AppendText(c + " is " + PointDB[i].mag.ToString() + "; ");

                char_counter++;


            }


            System.Windows.Forms.MessageBox.Show("DataBase created Succesfully");



        }





        public void Start_Journey()
        {
            char Destination = Convert.ToChar(destinationChar.Text[0]);
            List<char> shortP;
            PathConsole.ResetText();
            Arduino.Write("R");
            while (true)
            {
                while (true)
                {
                    if (Arduino.BytesToRead > 0)
                    {
                        Arduino.DiscardInBuffer();
                        break;
                    }

                }

                char current_pos = WhereAmI(GetPoint());

                if (current_pos == Destination)
                {

                    Arduino.Write('K'.ToString());
                    Task.Delay(15);
                    break;

                }
                else
                {
                    shortP = g.shortest_path(current_pos, Destination);
                    PathConsole.AppendText(shortP[shortP.Count - 1].ToString());
                    Arduino.Write(shortP[shortP.Count - 1].ToString());
                }


            }



        }











        // Buttons, panels, VS toolbox funtions in overall



        private void GetPortBtn_Click(object sender, EventArgs e) // Obtiene la lista de puertos COM disponibles actualmente en el Ordenador
        {

            ports = SerialPort.GetPortNames(); //Obtiene la lista de Puertos COM conectados actualmente a la computadora

            GetPortTxtB.ResetText();


            foreach (string port in ports)
            {
                GetPortTxtB.AppendText(port + "\n");
                ArduinoCOMBOX.Items.AddRange(ports);
            }

        }

        private void real_deal_btn_Click(object sender, EventArgs e)
        {
            real_deal_panel.BringToFront();
        }

        private void config_btn_Click(object sender, EventArgs e)
        {
            config_panel.BringToFront();
        }

        private void about_btn_Click(object sender, EventArgs e)
        {
            about_panel.BringToFront();
        }



        private void Inicializar_sesion_real_deal_Click(object sender, EventArgs e)
        {
            Inicializar_sesion_real_deal.Enabled = false;


            Build_PointDB();

            Inicializar_sesion_real_deal.Enabled = true;

        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (destinationChar.Text[0] >= 65 && destinationChar.Text[0] <= 73)
                {
                    destinationChar.ReadOnly = true;
                    Start_Journey();
                    destinationChar.ReadOnly = false;
                }
                else
                {

                    System.Windows.Forms.MessageBox.Show("Destination ID out of Bounds. Allowable destinations are A - I");
                }
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Please enter a destination");
            }

        }



        private void AcceptCOM_Btn_Click(object sender, EventArgs e) //Obtiene el puerto COM de cuadro de texto e intenta abrir el puerto con la variable dada
        {

           

            //serialPort1.PortName = "COM10";

            //Arduino.PortName = "COM4";

            try
            {

                if (EnterCOMTxtB.Text.Length > 1 && ArduinoCOMBOX.Text.Length > 1)
                {
                    serialPort1.PortName = EnterCOMTxtB.Text;

                    Arduino.PortName = ArduinoCOMBOX.Text;

                    serialPort1.Open();
                    Arduino.Open();

                    Status_Port.Text = "Ports succesfully opened";

                    Arduino.Write("R");
                }

                else
                {
                    System.Windows.MessageBox.Show("Enter a valid serial Ports");
                }

            }

            catch (Exception)
            {
                Status_Port.Text = "Invalid COM or already opened";
            }
        }




    }





}
