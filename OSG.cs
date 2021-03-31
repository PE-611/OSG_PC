using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Threading;


namespace Test_COM
{
    public partial class OSG : Form
    {
        byte START = 0;

        
 //////////////////////////////////////////////////// ПЕРЕМЕННЫЕ ДЛЯ КАНАЛА №1 /////////////////////////////////////////////////////////////////////////////////////////// 
       
        int DurationPulseCH1;                        // Переменная для хранения числового значения длительности импульса
        int DelBetweenPulseCH1;                      // Переменная для хранения числового значения паузы между импульсами
        byte[] DurationMassiveDataCH1;               // Массив хранящий две части переменной int DurationPulse в формате byte
        byte[] DelayMassiveDataCH1;                  // Массив хранящий две части переменной int DelayMassiveData в формате byte
        byte DurMultiplierCH1;                       // Переменная хранит закодированное значение множителя для задания диапазона (нс, мкс, мс с) длительности импульса 
        byte DelMultiplierCH1;                       // Переменная хранит закодированное значение множителя для задания диапазона (нс, мкс, мс с) длительности импульса 
        byte TypeStartCH1;                           // Переменная хранит код типа запуска (общий или последовательный) 

 //////////////////////////////////////////////////// ПЕРЕМЕННЫЕ ДЛЯ КАНАЛА №2 ///////////////////////////////////////////////////////////////////////////////////////////

        int DurationPulseCH2;                        
        int DelBetweenPulseCH2;                      
        byte[] DurationMassiveDataCH2;               
        byte[] DelayMassiveDataCH2;                  
        byte DurMultiplierCH2;                        
        byte DelMultiplierCH2;                        
        byte TypeStartCH2;

 //////////////////////////////////////////////////// ПЕРЕМЕННЫЕ ДЛЯ КАНАЛА №3 ///////////////////////////////////////////////////////////////////////////////////////////

        int DurationPulseCH3;
        int DelBetweenPulseCH3;
        byte[] DurationMassiveDataCH3;
        byte[] DelayMassiveDataCH3;
        byte DurMultiplierCH3;
        byte DelMultiplierCH3;
        byte TypeStartCH3;

//////////////////////////////////////////////////// ПЕРЕМЕННЫЕ ДЛЯ КАНАЛА №4 ///////////////////////////////////////////////////////////////////////////////////////////

        int DurationPulseCH4;
        int DelBetweenPulseCH4;
        byte[] DurationMassiveDataCH4;
        byte[] DelayMassiveDataCH4;
        byte DurMultiplierCH4;
        byte DelMultiplierCH4;
        byte TypeStartCH4;

 //////////////////////////////////////////////////// ПЕРЕМЕННЫЕ ДЛЯ КАНАЛА №5 ///////////////////////////////////////////////////////////////////////////////////////////

        int DurationPulseCH5;
        int DelBetweenPulseCH5;
        byte[] DurationMassiveDataCH5;
        byte[] DelayMassiveDataCH5;
        byte DurMultiplierCH5;
        byte DelMultiplierCH5;
        byte TypeStartCH5;

///////////////////////////////////////////////////// ПЕРЕМЕННЫЕ ДЛЯ КАНАЛА №6 ///////////////////////////////////////////////////////////////////////////////////////////

        int DurationPulseCH6;
        int DelBetweenPulseCH6;
        byte[] DurationMassiveDataCH6;
        byte[] DelayMassiveDataCH6;
        byte DurMultiplierCH6;
        byte DelMultiplierCH6;
        byte TypeStartCH6;

///////////////////////////////////////////////////// ПЕРЕМЕННЫЕ ДЛЯ КАНАЛА №7 ///////////////////////////////////////////////////////////////////////////////////////////

        int DurationPulseCH7;
        int DelBetweenPulseCH7;
        byte[] DurationMassiveDataCH7;
        byte[] DelayMassiveDataCH7;
        byte DurMultiplierCH7;
        byte DelMultiplierCH7;
        byte TypeStartCH7;

///////////////////////////////////////////////////// ПЕРЕМЕННЫЕ ДЛЯ КАНАЛА №8 ///////////////////////////////////////////////////////////////////////////////////////////

        int DurationPulseCH8;
        int DelBetweenPulseCH8;
        byte[] DurationMassiveDataCH8;
        byte[] DelayMassiveDataCH8;
        byte DurMultiplierCH8;
        byte DelMultiplierCH8;
        byte TypeStartCH8;

///////////////////////////////////////////////////// ПЕРЕМЕННЫЕ ДЛЯ КАНАЛА №9 /////////////////////////////////////////////////////////////////////////////////////////// 
        int DurationPulseCH9;                        
        int DelBetweenPulseCH9;                      
        byte[] DurationMassiveDataCH9;               
        byte[] DelayMassiveDataCH9;                  
        byte DurMultiplierCH9;                       
        byte DelMultiplierCH9;                       
        byte TypeStartCH9;

////////////////////////////////////////////////////// ПЕРЕМЕННЫЕ ДЛЯ КАНАЛА №10 ///////////////////////////////////////////////////////////////////////////////////////////

        int DurationPulseCH10;
        int DelBetweenPulseCH10;
        byte[] DurationMassiveDataCH10;
        byte[] DelayMassiveDataCH10;
        byte DurMultiplierCH10;
        byte DelMultiplierCH10;
        byte TypeStartCH10;

///////////////////////////////////////////////////// ПЕРЕМЕННЫЕ ДЛЯ КАНАЛА №11 ///////////////////////////////////////////////////////////////////////////////////////////

        int DurationPulseCH11;
        int DelBetweenPulseCH11;
        byte[] DurationMassiveDataCH11;
        byte[] DelayMassiveDataCH11;
        byte DurMultiplierCH11;
        byte DelMultiplierCH11;
        byte TypeStartCH11;

///////////////////////////////////////////////////// ПЕРЕМЕННЫЕ ДЛЯ КАНАЛА №12 ///////////////////////////////////////////////////////////////////////////////////////////

        int DurationPulseCH12;
        int DelBetweenPulseCH12;
        byte[] DurationMassiveDataCH12;
        byte[] DelayMassiveDataCH12;
        byte DurMultiplierCH12;
        byte DelMultiplierCH12;
        byte TypeStartCH12;

 ///////////////////////////////////////////////////// ПЕРЕМЕННЫЕ ДЛЯ КАНАЛА №13 ///////////////////////////////////////////////////////////////////////////////////////////

        int DurationPulseCH13;
        int DelBetweenPulseCH13;
        byte[] DurationMassiveDataCH13;
        byte[] DelayMassiveDataCH13;
        byte DurMultiplierCH13;
        byte DelMultiplierCH13;
        byte TypeStartCH13;

////////////////////////////////////////////////////// ПЕРЕМЕННЫЕ ДЛЯ КАНАЛА №14 ///////////////////////////////////////////////////////////////////////////////////////////

        int DurationPulseCH14;
        int DelBetweenPulseCH14;
        byte[] DurationMassiveDataCH14;
        byte[] DelayMassiveDataCH14;
        byte DurMultiplierCH14;
        byte DelMultiplierCH14;
        byte TypeStartCH14;

 ///////////////////////////////////////////////////// ПЕРЕМЕННЫЕ ДЛЯ КАНАЛА №15 ///////////////////////////////////////////////////////////////////////////////////////////

        int DurationPulseCH15;
        int DelBetweenPulseCH15;
        byte[] DurationMassiveDataCH15;
        byte[] DelayMassiveDataCH15;
        byte DurMultiplierCH15;
        byte DelMultiplierCH15;
        byte TypeStartCH15;

////////////////////////////////////////////////////// ПЕРЕМЕННЫЕ ДЛЯ КАНАЛА №16 ///////////////////////////////////////////////////////////////////////////////////////////

        int DurationPulseCH16;
        int DelBetweenPulseCH16;
        byte[] DurationMassiveDataCH16;
        byte[] DelayMassiveDataCH16;
        byte DurMultiplierCH16;
        byte DelMultiplierCH16;
        byte TypeStartCH16;

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        int ranger;   // Переменная для преобразования текста в 32 бит число, нужна для проверки выхода за 65535

        string filePath; // Переменная для хранения пути к файлу для записи и загрузки файла конфигурации каналов
        
        ////////////////////////////////////////////////////// Инициализация GUI и СОМ ПОРТА ///////////////////////////////////////////////////////////////////////////////////////

        public OSG()
        {   
            InitializeComponent();

            string[] ports;                       // Массив строковых переменных для хранения имен подключеннх СОМ портов
            ports = SerialPort.GetPortNames();    // Получение имен подключеннх СОМ портов
            ComComboBox.Items.AddRange(ports);    // Добавление полученных имен СОМ портов в  СОМ комбобокс


            DurTextBoxCh1.Text = "1";             // Начальное значение длительности канала №1
            DelTextBoxch1.Text = "1";             // Начальное значение паузы канала №1
           
            DurTextBoxCh2.Text = "1";             
            DelTextBoxch2.Text = "1";

            DurTextBoxCh3.Text = "1";
            DelTextBoxch3.Text = "1";

            DurTextBoxCh4.Text = "1";
            DelTextBoxch4.Text = "1";

            DurTextBoxCh5.Text = "1";
            DelTextBoxch5.Text = "1";

            DurTextBoxCh6.Text = "1";
            DelTextBoxch6.Text = "1";

            DurTextBoxCh7.Text = "1";
            DelTextBoxch7.Text = "1";

            DurTextBoxCh8.Text = "1";
            DelTextBoxch8.Text = "1";

            DurTextBoxCh9.Text = "1";
            DelTextBoxch9.Text = "1";

            DurTextBoxCh10.Text = "1";
            DelTextBoxch10.Text = "1";

            DurTextBoxCh11.Text = "1";
            DelTextBoxch11.Text = "1";

            DurTextBoxCh12.Text = "1";
            DelTextBoxch12.Text = "1";

            DurTextBoxCh13.Text = "1";
            DelTextBoxch13.Text = "1";

            DurTextBoxCh14.Text = "1";
            DelTextBoxch14.Text = "1";

            DurTextBoxCh15.Text = "1";
            DelTextBoxch15.Text = "1";

            DurTextBoxCh16.Text = "1";
            DelTextBoxch16.Text = "1";


            DurTextBoxCh1.MaxLength = 5;  
            DurTextBoxCh2.MaxLength = 5;
            DurTextBoxCh3.MaxLength = 5;
            DurTextBoxCh4.MaxLength = 5;
            DurTextBoxCh5.MaxLength = 5;
            DurTextBoxCh6.MaxLength = 5;
            DurTextBoxCh7.MaxLength = 5;
            DurTextBoxCh8.MaxLength = 5;
            DurTextBoxCh9.MaxLength = 5;
            DurTextBoxCh10.MaxLength = 5;
            DurTextBoxCh11.MaxLength = 5;
            DurTextBoxCh12.MaxLength = 5;
            DurTextBoxCh13.MaxLength = 5;
            DurTextBoxCh14.MaxLength = 5;
            DurTextBoxCh15.MaxLength = 5;
            DurTextBoxCh16.MaxLength = 5;

            DelTextBoxch1.MaxLength = 5;
            DelTextBoxch2.MaxLength = 5;
            DelTextBoxch3.MaxLength = 5;
            DelTextBoxch4.MaxLength = 5;
            DelTextBoxch5.MaxLength = 5;
            DelTextBoxch6.MaxLength = 5;
            DelTextBoxch7.MaxLength = 5;
            DelTextBoxch8.MaxLength = 5;
            DelTextBoxch9.MaxLength = 5;
            DelTextBoxch10.MaxLength = 5;
            DelTextBoxch11.MaxLength = 5;
            DelTextBoxch12.MaxLength = 5;
            DelTextBoxch13.MaxLength = 5;
            DelTextBoxch14.MaxLength = 5;
            DelTextBoxch15.MaxLength = 5;
            DelTextBoxch16.MaxLength = 5;

            TypeLaunchComboBox.SelectedItem = "ПУСК с ПК";

        }



        SerialPort Port = new SerialPort("COM", 115200, Parity.None, 8, StopBits.Two);            // Инициализация последовательного порта 
        // _serialPort.Handshake = Handshake.None;

        public void ComComboBox_SelectedIndexChanged(object sender, EventArgs e)                // При выборе СОМ порта осуществляем:
        {
            if (Port.IsOpen == false)
            {
                Port.PortName = ComComboBox.Text.ToString();                                    // Изменение имени Комбобокса
                Port.Open();                                                                    // Открываем порт
                Port.BaudRate = 115200;
                Port.DataBits = 8;
                //Port.WriteTimeout = 1000;                                                       // Эти тайм ауты можно не ставить
                //Port.ReadTimeout = 1000;                                                        // Эти тайм ауты можно не ставить
                OffComButton.Text = "Отключить " + Port.PortName;                               // Изменяем текст на кнопке отключения порта на "Отключить СОМ порт"
                label1.Text = "Подключен";                                                      // Изменяем текст на лейбле на "Подключен"    
                pictureBox1.BackColor = Color.LightGreen;                                       // Зажигаем зеленым лампочку оповещающую о подключенном СОМ порте
            }
        }

        public void OffComButton_Click(object sender, EventArgs e)                              // При нажатии на кнопку отключения СОМ порта осуществяем:
        {
            Port.Close();                                                                       // Закрываем порт
            OffComButton.Text = "Выберите порт";                                                // Изменяем текст на кнопке отключения порта на "Выберите порт"
            label1.Text = "Нет подключенных портов";                                            // Изменяем текст на лейбле на "Нет подключенных портов"
            ComComboBox.Text = "";                                                              // Очищаем СОМ комбобокс
            pictureBox1.BackColor = Color.Empty;                                                // Цвет "лампочки" фоновый
        }
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


////////////////////////////////////////////////// Организация GUI, пакета данных для передачи в СОМ порт и передача данных ///////////////////////////////////////////////////////////////

        public void SerialSendButton_Click(object sender, EventArgs e)                          // При нажатии на кнопку отправки в СОМ порт:
        {
            int count = 113;              ///// ВНИМАНИЕ                                        // Количество байтов массива для отправки в СОМ 
            int offset = 0;                                                                     // Смещение не нужно = 0
            byte[] buffer = new byte[] {DurationMassiveDataCH1[0], DurationMassiveDataCH1[1],   // Массив байтов для отправки в СОМ порт
                                        DurMultiplierCH1,
                                        DelayMassiveDataCH1[0],    DelayMassiveDataCH1[1],
                                        DelMultiplierCH1,
                                        TypeStartCH1,

                                        DurationMassiveDataCH2[0], DurationMassiveDataCH2[1],   
                                        DurMultiplierCH2,
                                        DelayMassiveDataCH2[0],    DelayMassiveDataCH2[1],
                                        DelMultiplierCH2,
                                        TypeStartCH2,

                                        DurationMassiveDataCH3[0], DurationMassiveDataCH3[1],
                                        DurMultiplierCH3,
                                        DelayMassiveDataCH3[0],    DelayMassiveDataCH3[1],
                                        DelMultiplierCH3,
                                        TypeStartCH3,
                                        
                                        DurationMassiveDataCH4[0], DurationMassiveDataCH4[1],
                                        DurMultiplierCH4,
                                        DelayMassiveDataCH4[0],    DelayMassiveDataCH4[1],
                                        DelMultiplierCH4,
                                        TypeStartCH4,

                                        DurationMassiveDataCH5[0], DurationMassiveDataCH5[1],
                                        DurMultiplierCH5,
                                        DelayMassiveDataCH5[0],    DelayMassiveDataCH5[1],
                                        DelMultiplierCH5,
                                        TypeStartCH5,

                                        DurationMassiveDataCH6[0], DurationMassiveDataCH6[1],
                                        DurMultiplierCH6,
                                        DelayMassiveDataCH6[0],    DelayMassiveDataCH6[1],
                                        DelMultiplierCH6,
                                        TypeStartCH6,

                                        DurationMassiveDataCH7[0], DurationMassiveDataCH7[1],
                                        DurMultiplierCH7,
                                        DelayMassiveDataCH7[0],    DelayMassiveDataCH7[1],
                                        DelMultiplierCH7,
                                        TypeStartCH7,

                                        DurationMassiveDataCH8[0], DurationMassiveDataCH8[1],
                                        DurMultiplierCH8,
                                        DelayMassiveDataCH8[0],    DelayMassiveDataCH8[1],
                                        DelMultiplierCH8,
                                        TypeStartCH8,

                                        DurationMassiveDataCH9[0], DurationMassiveDataCH9[1],
                                        DurMultiplierCH9,
                                        DelayMassiveDataCH9[0],    DelayMassiveDataCH9[1],
                                        DelMultiplierCH9,
                                        TypeStartCH9,

                                        DurationMassiveDataCH10[0], DurationMassiveDataCH10[1],
                                        DurMultiplierCH10,
                                        DelayMassiveDataCH10[0],    DelayMassiveDataCH10[1],
                                        DelMultiplierCH10,
                                        TypeStartCH10,

                                        DurationMassiveDataCH11[0], DurationMassiveDataCH11[1],
                                        DurMultiplierCH11,
                                        DelayMassiveDataCH11[0],    DelayMassiveDataCH11[1],
                                        DelMultiplierCH11,
                                        TypeStartCH11,

                                        DurationMassiveDataCH12[0], DurationMassiveDataCH12[1],
                                        DurMultiplierCH12,
                                        DelayMassiveDataCH12[0],    DelayMassiveDataCH12[1],
                                        DelMultiplierCH12,
                                        TypeStartCH12,

                                        DurationMassiveDataCH13[0], DurationMassiveDataCH13[1],
                                        DurMultiplierCH13,
                                        DelayMassiveDataCH13[0],    DelayMassiveDataCH13[1],
                                        DelMultiplierCH13,
                                        TypeStartCH13,

                                        DurationMassiveDataCH14[0], DurationMassiveDataCH14[1],
                                        DurMultiplierCH14,
                                        DelayMassiveDataCH14[0],    DelayMassiveDataCH14[1],
                                        DelMultiplierCH14,
                                        TypeStartCH14,

                                        DurationMassiveDataCH15[0], DurationMassiveDataCH15[1],
                                        DurMultiplierCH15,
                                        DelayMassiveDataCH15[0],    DelayMassiveDataCH15[1],
                                        DelMultiplierCH15,
                                        TypeStartCH15,

                                        DurationMassiveDataCH16[0], DurationMassiveDataCH16[1],
                                        DurMultiplierCH16,
                                        DelayMassiveDataCH16[0],    DelayMassiveDataCH16[1],
                                        DelMultiplierCH16,
                                        TypeStartCH16,

                                        START
                                        
                                        


                                                                                     };

            if (Port.IsOpen == true)                                                            // Если порт открыт 
            {
                
                                                                                        // Если хоть один из пусков не выбран то 
                    if (ComboBoxTypeStartCh1.Text == "" | ComboBoxTypeStartCh2.Text == "" | ComboBoxTypeStartCh3.Text == "" | ComboBoxTypeStartCh4.Text == "" 
                      | ComboBoxTypeStartCh5.Text == "" | ComboBoxTypeStartCh6.Text == "" | ComboBoxTypeStartCh7.Text == "" | ComboBoxTypeStartCh8.Text == ""
                      | ComboBoxTypeStartCh9.Text == "" | ComboBoxTypeStartCh10.Text == "" | ComboBoxTypeStartCh11.Text == "" | ComboBoxTypeStartCh12.Text == ""
                      | ComboBoxTypeStartCh13.Text == "" | ComboBoxTypeStartCh14.Text == "" | ComboBoxTypeStartCh15.Text == "" | ComboBoxTypeStartCh16.Text == "")
                    {
                        MessageBox.Show("Выберите тип пуска", "Сообщение",                      // Выводим сообщение призывающее выбрать тип пуска
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1);
                        // MessageBoxOptions.ServiceNotification);

                    }
                    else
                    {                                                                           // Если текст боксы пустые выводим сообщение призывающее выбрать диапазон
                        if (DurComboBoxCh1.Text == "" | DelComboBoxCh1.Text == "" | DurComboBoxCh2.Text == "" | DelComboBoxCh2.Text == "" 
                          | DurComboBoxCh3.Text == "" | DelComboBoxCh3.Text == "" | DurComboBoxCh4.Text == "" | DelComboBoxCh4.Text == ""
                          | DurComboBoxCh5.Text == "" | DelComboBoxCh5.Text == "" | DurComboBoxCh6.Text == "" | DelComboBoxCh6.Text == ""
                          | DurComboBoxCh7.Text == "" | DelComboBoxCh7.Text == "" | DurComboBoxCh8.Text == "" | DelComboBoxCh8.Text == ""
                          | DurComboBoxCh9.Text == "" | DelComboBoxCh9.Text == "" | DurComboBoxCh10.Text == "" | DelComboBoxCh10.Text == ""
                          | DurComboBoxCh11.Text == "" | DelComboBoxCh11.Text == "" | DurComboBoxCh12.Text == "" | DelComboBoxCh12.Text == ""
                          | DurComboBoxCh13.Text == "" | DelComboBoxCh13.Text == "" | DurComboBoxCh14.Text == "" | DelComboBoxCh14.Text == ""
                          | DurComboBoxCh15.Text == "" | DelComboBoxCh15.Text == "" | DurComboBoxCh16.Text == "" | DelComboBoxCh16.Text == "")             
                        {
                            MessageBox.Show("Выберите диапазон длительности и задержки 'нс','мкс','мс','с'", "Сообщение",  
                            MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Warning,
                            MessageBoxDefaultButton.Button1);
                        }
                        else
                        {   
                            if (TypeLaunchComboBox.Text == "ПУСК с ПК")
                            {
                                DialogResult dialogResult = MessageBox.Show("Подтвердите ПУСК", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                if (dialogResult == DialogResult.Yes)
                                {
                                    Port.Write(buffer, offset, count);                                  // Осуществляем передачу байтов
                                    SerialSendButton.Click -= new System.EventHandler(this.SerialSendButton_Click);
                                    SerialSendButton.Enabled = false;
                                    Thread.Sleep(100);
                                    SerialSendButton.Enabled = true;
                                    SerialSendButton.Click += new System.EventHandler(SerialSendButton_Click);
                                }
                                else if (dialogResult == DialogResult.No)
                                {

                                }
                            }

                            else if (TypeLaunchComboBox.Text == "Внешний ПУСК")
                            {
                                Port.Write(buffer, offset, count);                                  // Осуществляем передачу байтов
                                SerialSendButton.Click -= new System.EventHandler(this.SerialSendButton_Click);
                                SerialSendButton.Enabled = false;
                                Thread.Sleep(100);
                                SerialSendButton.Enabled = true;
                                SerialSendButton.Click += new System.EventHandler(SerialSendButton_Click);
                            }   






                        }
                    }
                
                
            }
            if (Port.IsOpen == false)                                                           // Если порт закрыт (а закрыт он может быть только потому что мы его не выбрали в СОМ комбобоксе)
            {                                                                       
                MessageBox.Show("Выберите СОМ порт", "Сообщение",                               // Выводим сообщение призывающее выбрать СОМ порт
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);
                 // MessageBoxOptions.ServiceNotification);
            }
        }

        
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

////////////////////////////////////////////////////////////////////////////////////////////////////     КАНАЛ №1      //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void DurTextBoxCh1_TextChanged(object sender, EventArgs e)
        {
            if (DurTextBoxCh1.Text == "")
            {
                DurTextBoxCh1.Text = "1";
            }

            if (DurTextBoxCh1.Text == "0")
            {
                DurTextBoxCh1.Text = "1";
            }

            Checking_text_for_a_number(DurTextBoxCh1.Text, out bool res);
            if (res == true)
            {
                ranger = Convert.ToInt32(DurTextBoxCh1.Text);
                if (ranger > 65534)
                {
                    DurTextBoxCh1.Text = "65534";
                }
            }
            else 
            {
                DurTextBoxCh1.Clear();
            }

            

            


                //if (DurComboBoxCh1.Text != "*10 нс" & DurComboBoxCh1.Text != "мкс" & DurComboBoxCh1.Text != "мс")
                //{
                //    if (Convert.ToInt32(DurTextBoxCh1.Text) >= 9)                                                                     Для секунд
                //    {
                //        DurTextBoxCh1.Text = "9";
                //    }
                //}

            string buf = DurTextBoxCh1.Text;
            
            DurationPulseCH1 = Convert.ToUInt16(buf);
            DurationMassiveDataCH1 = BitConverter.GetBytes(DurationPulseCH1);
        }

        public void DelTextBoxch1_TextChanged(object sender, EventArgs e)                       
        {
            if (DelTextBoxch1.Text == "")
            {
                DelTextBoxch1.Text = "1";
            }

            

            Checking_text_for_a_number(DelTextBoxch1.Text, out bool res);                           
            if (res == true)
            {
                ranger = Convert.ToInt32(DelTextBoxch1.Text);
                if (ranger > 65534)
                {
                    DelTextBoxch1.Text = "65534";
                }
            }
            else                                                                                
            {
                DelTextBoxch1.Clear();                                                          
            }

            if (DelTextBoxch1.Text == "0")
            {
                DelTextBoxch1.Text = "1";
            }

            string buf = DelTextBoxch1.Text;
            DelBetweenPulseCH1 = Convert.ToUInt16(buf);
            DelayMassiveDataCH1 = BitConverter.GetBytes(DelBetweenPulseCH1);
        }
 
        public void DurComboBoxCh1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if  (DurComboBoxCh1.Text == "*10 нс")
            {
                DurMultiplierCH1 = 1;
            }
            else if (DurComboBoxCh1.Text == "мкс")
            {
                DurMultiplierCH1 = 2;
            }
            else //if (DurComboBoxCh1.Text == "мс")
            {
                DurMultiplierCH1 = 3;
            }
            //else 
            //{
            //    if (Convert.ToInt32(DurTextBoxCh1.Text) >= 9)
            //    {
            //        DurTextBoxCh1.Text = "9";                                                                                        Для секунд
            //    }
            //    DurMultiplierCH1 = 4;
            //}
        }

        public void DelComboBoxCh1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DelComboBoxCh1.Text == "*10 нс")
            {
                DelMultiplierCH1 = 1;
            }
            else if (DelComboBoxCh1.Text == "мкс")
            {
                DelMultiplierCH1 = 2;                                                   
            }
            else // if (DelComboBoxCh1.Text == "мс")
            {
                DelMultiplierCH1 = 3;
            }
            //else
            //{
            //     DelMultiplierCH1 = 4;                                                                                               Для секунд
            //}
        }

        public void ComboBoxTypeStartCh1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxTypeStartCh1.Text == "Общий")
            {
                TypeStartCH1 = 1;
            }
            else if (ComboBoxTypeStartCh1.Text == "От предыдущего")
            {
                TypeStartCH1 = 1;
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////     КАНАЛ №2      //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void DurTextBoxCh2_TextChanged(object sender, EventArgs e)
        {
            if (DurTextBoxCh2.Text == "")
            {
                DurTextBoxCh2.Text = "1";
            }

            if (DurTextBoxCh2.Text == "0")
            {
                DurTextBoxCh2.Text = "1";
            }



            Checking_text_for_a_number(DurTextBoxCh2.Text, out bool res);
            if (res == true)
            {
                ranger = Convert.ToInt32(DurTextBoxCh2.Text);
                if (ranger > 65534)
                {
                    DurTextBoxCh2.Text = "65534";
                }
            }
            else
            {
                DurTextBoxCh2.Clear();
            }

            if (DurTextBoxCh2.Text == "")
            {
                DurTextBoxCh2.Text = "0";
            }

            string buf = DurTextBoxCh2.Text;
            DurationPulseCH2 = Convert.ToUInt16(buf);
            DurationMassiveDataCH2 = BitConverter.GetBytes(DurationPulseCH2);
        }

        public void DelTextBoxch2_TextChanged(object sender, EventArgs e)  
        {
            if (DelTextBoxch2.Text == "")
            {
                DelTextBoxch2.Text = "1";
            }

            

            Checking_text_for_a_number(DelTextBoxch2.Text, out bool res);
            if (res == true)
            {
                ranger = Convert.ToInt32(DelTextBoxch2.Text);
                if (ranger > 65534)
                {
                    DelTextBoxch2.Text = "65534";
                }
            }
            else
            {
                DelTextBoxch2.Clear();
            }

            if (DelTextBoxch2.Text == "0")
            {
                DelTextBoxch2.Text = "1";
            }

            string buf = DelTextBoxch2.Text;
            DelBetweenPulseCH2 = Convert.ToUInt16(buf);
            DelayMassiveDataCH2 = BitConverter.GetBytes(DelBetweenPulseCH2);
        }

        public void DurComboBoxCh2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DurComboBoxCh2.Text == "*10 нс")
            {
                DurMultiplierCH2 = 1;
            }
            else if (DurComboBoxCh2.Text == "мкс")
            {
                DurMultiplierCH2 = 2;
            }
            else //if (DurComboBoxCh2.Text == "мс")
            {
                DurMultiplierCH2 = 3;
            }
            //else 
            //{
            //    DurMultiplierCH2 = 4;                                                                                                Для секунд
            //}
        }

        public void DelComboBoxCh2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DelComboBoxCh2.Text == "*10 нс")
            {
                DelMultiplierCH2 = 1;
            }
            else if(DelComboBoxCh2.Text == "мкс")
            {
                DelMultiplierCH2 = 2;
            }
            else //if(DelComboBoxCh2.Text == "мс")
            {
                DelMultiplierCH2 = 3;
            }
            //else 
            //{
            //    DelMultiplierCH2 = 4;                                                                                                Для секунд
            //}
        }

        public void ComboBoxTypeStartCh2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxTypeStartCh2.Text == "Общий")
            {
                TypeStartCH2 = 1;
            }
            else if (ComboBoxTypeStartCh2.Text == "От предыдущего")
            {
                TypeStartCH2 = 2;
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////     КАНАЛ №3      //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void DurTextBoxCh3_TextChanged(object sender, EventArgs e)
        {
            if (DurTextBoxCh3.Text == "")
            {
                DurTextBoxCh3.Text = "1";
            }

            if (DurTextBoxCh3.Text == "0")
            {
                DurTextBoxCh3.Text = "1";
            }


            Checking_text_for_a_number(DurTextBoxCh3.Text, out bool res);
            if (res == true)
            {
                ranger = Convert.ToInt32(DurTextBoxCh3.Text);
                if (ranger > 65534)
                {
                    DurTextBoxCh3.Text = "65534";
                }
            }
            else
            {
                DurTextBoxCh3.Clear();
            }

            if (DurTextBoxCh3.Text == "")
            {
                DurTextBoxCh3.Text = "1";
            }

            string buf = DurTextBoxCh3.Text;
            DurationPulseCH3 = Convert.ToUInt16(buf);
            DurationMassiveDataCH3 = BitConverter.GetBytes(DurationPulseCH3);
        }

        public void DelTextBoxch3_TextChanged(object sender, EventArgs e)
        {
            if (DelTextBoxch3.Text == "")
            {
                DelTextBoxch3.Text = "1";
            }

            
            Checking_text_for_a_number(DelTextBoxch3.Text, out bool res);
            if (res == true)
            {
                ranger = Convert.ToInt32(DelTextBoxch3.Text);
                if (ranger > 65534)
                {
                    DelTextBoxch3.Text = "65534";
                }
            }
            else
            {
                DelTextBoxch3.Clear();
            }

            if (DelTextBoxch3.Text == "0")
            {
                DelTextBoxch3.Text = "1";
            }

            string buf = DelTextBoxch3.Text;
            DelBetweenPulseCH3 = Convert.ToUInt16(buf);
            DelayMassiveDataCH3 = BitConverter.GetBytes(DelBetweenPulseCH3);
        }

        public void DurComboBoxCh3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DurComboBoxCh3.Text == "*10 нс")
            {
                DurMultiplierCH3 = 1;
            }
            else if(DurComboBoxCh3.Text == "мкс")
            {
                DurMultiplierCH3 = 2;
            }
            else if(DurComboBoxCh3.Text == "мс")
            {
                DurMultiplierCH3 = 3;
            }
            //else 
            //{
            //    DurMultiplierCH3 = 4;                                                                                                Для секунд
            //}
        }

        public void DelComboBoxCh3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DelComboBoxCh3.Text == "*10 нс")
            {
                DelMultiplierCH3 = 1;
            }
            else if(DelComboBoxCh3.Text == "мкс")
            {
                DelMultiplierCH3 = 2;
            }
            else if(DelComboBoxCh3.Text == "мс")
            {
                DelMultiplierCH3 = 3;
            }
            //else 
            //{
            //    DelMultiplierCH3 = 4;                                                                                                Для секунд
            //}
        }

        public void ComboBoxTypeStartCh3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxTypeStartCh3.Text == "Общий")
            {
                TypeStartCH3 = 1;
            }
            else if (ComboBoxTypeStartCh3.Text == "От предыдущего")
            {
                TypeStartCH3 = 2;
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////     КАНАЛ №4      //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void DurTextBoxCh4_TextChanged(object sender, EventArgs e)
        {
            if (DurTextBoxCh4.Text == "")
            {
                DurTextBoxCh4.Text = "1";
            }

            if (DurTextBoxCh4.Text == "0")
            {
                DurTextBoxCh4.Text = "1";
            }


            Checking_text_for_a_number(DurTextBoxCh4.Text, out bool res);
            if (res == true)
            {
                ranger = Convert.ToInt32(DurTextBoxCh4.Text);
                if (ranger > 65534)
                {
                    DurTextBoxCh4.Text = "65534";
                }
            }
            else
            {
                DurTextBoxCh4.Clear();
            }

            if (DurTextBoxCh4.Text == "")
            {
                DurTextBoxCh4.Text = "0";
            }

            string buf = DurTextBoxCh4.Text;
            DurationPulseCH4 = Convert.ToUInt16(buf);
            DurationMassiveDataCH4 = BitConverter.GetBytes(DurationPulseCH4);
        }

        public void DelTextBoxch4_TextChanged(object sender, EventArgs e)
        {
            if (DelTextBoxch4.Text == "")
            {
                DelTextBoxch4.Text = "1";
            }

            
            Checking_text_for_a_number(DelTextBoxch4.Text, out bool res);
            if (res == true)
            {
                ranger = Convert.ToInt32(DelTextBoxch4.Text);
                if (ranger > 65534)
                {
                    DelTextBoxch4.Text = "65534";
                }
            }
            else
            {
                DelTextBoxch4.Clear();
            }

            if (DelTextBoxch4.Text == "0")
            {
                DelTextBoxch4.Text = "1";
            }

            string buf = DelTextBoxch4.Text;
            DelBetweenPulseCH4 = Convert.ToUInt16(buf);
            DelayMassiveDataCH4 = BitConverter.GetBytes(DelBetweenPulseCH4);
        }

        public void DurComboBoxCh4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DurComboBoxCh4.Text == "*10 нс")
            {
                DurMultiplierCH4 = 1;
            }
            else if(DurComboBoxCh4.Text == "мкс")
            {
                DurMultiplierCH4 = 2;
            }
            else //if(DurComboBoxCh4.Text == "мс")
            {
                DurMultiplierCH4 = 3;
            }
            //else 
            //{
            //    DurMultiplierCH4 = 4;                                                                                                Для секунд
            //}
        }

        public void DelComboBoxCh4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DelComboBoxCh4.Text == "*10 нс")
            {
                DelMultiplierCH4 = 1;
            }
            else if(DelComboBoxCh4.Text == "мкс")
            {
                DelMultiplierCH4 = 2;
            }
            else //if(DelComboBoxCh4.Text == "мс")
            {
                DelMultiplierCH4 = 3;
            }
            //else 
            //{
            //    DelMultiplierCH4 = 4;                                                                                                Для секунд
            //}
        }

        public void ComboBoxTypeStartCh4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxTypeStartCh4.Text == "Общий")
            {
                TypeStartCH4 = 1;
            }
            else if (ComboBoxTypeStartCh4.Text == "От предыдущего")
            {
                TypeStartCH4 = 2;
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////     КАНАЛ №5      //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void DurTextBoxCh5_TextChanged(object sender, EventArgs e)
        {
            if (DurTextBoxCh5.Text == "")
            {
                DurTextBoxCh5.Text = "1";
            }

            if (DurTextBoxCh5.Text == "0")
            {
                DurTextBoxCh5.Text = "1";
            }


            Checking_text_for_a_number(DurTextBoxCh5.Text, out bool res);
            if (res == true)
            {
                ranger = Convert.ToInt32(DurTextBoxCh5.Text);
                if (ranger > 65534)
                {
                    DurTextBoxCh5.Text = "65534";
                }
            }
            else
            {
                DurTextBoxCh5.Clear();
            }

            if (DurTextBoxCh5.Text == "")
            {
                DurTextBoxCh5.Text = "0";
            }

            string buf = DurTextBoxCh5.Text;
            DurationPulseCH5 = Convert.ToUInt16(buf);
            DurationMassiveDataCH5 = BitConverter.GetBytes(DurationPulseCH5);
        }

        public void DelTextBoxch5_TextChanged(object sender, EventArgs e)
        {
            if (DelTextBoxch5.Text == "")
            {
                DelTextBoxch5.Text = "1";
            }

            
            Checking_text_for_a_number(DelTextBoxch5.Text, out bool res);
            if (res == true)
            {
                ranger = Convert.ToInt32(DelTextBoxch5.Text);
                if (ranger > 65534)
                {
                    DelTextBoxch5.Text = "65534";
                }
            }
            else
            {
                DelTextBoxch5.Clear();
            }

            if (DelTextBoxch5.Text == "0")
            {
                DelTextBoxch5.Text = "1";
            }

            string buf = DelTextBoxch5.Text;
            DelBetweenPulseCH5 = Convert.ToUInt16(buf);
            DelayMassiveDataCH5 = BitConverter.GetBytes(DelBetweenPulseCH5);
        }

        public void DurComboBoxCh5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DurComboBoxCh5.Text == "*10 нс")
            {
                DurMultiplierCH5 = 1;
            }
            else if(DurComboBoxCh5.Text == "мкс")
            {
                DurMultiplierCH5 = 2;
            }
            else //if(DurComboBoxCh5.Text == "мс")
            {
                DurMultiplierCH5 = 3;
            }
            //else 
            //{
            //    DurMultiplierCH5 = 4;                                                                                                Для секунд
            //}
        }

        public void DelComboBoxCh5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DelComboBoxCh5.Text == "*10 нс")
            {
                DelMultiplierCH5 = 1;
            }
            else if(DelComboBoxCh5.Text == "мкс")
            {
                DelMultiplierCH5 = 2;
            }
            else //if(DelComboBoxCh5.Text == "мс")
            {
                DelMultiplierCH5 = 3;
            }
            //else 
            //{
            //    DelMultiplierCH5 = 4;                                                                                                Для секунд
            //}
        }

        public void ComboBoxTypeStartCh5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxTypeStartCh5.Text == "Общий")
            {
                TypeStartCH5 = 1;
            }
            else if (ComboBoxTypeStartCh5.Text == "От предыдущего")
            {
                TypeStartCH5 = 2;
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////     КАНАЛ №6      //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void DurTextBoxCh6_TextChanged(object sender, EventArgs e)
        {
            if (DurTextBoxCh6.Text == "")
            {
                DurTextBoxCh6.Text = "1";
            }

            if (DurTextBoxCh6.Text == "0")
            {
                DurTextBoxCh6.Text = "1";
            }


            Checking_text_for_a_number(DurTextBoxCh6.Text, out bool res);
            if (res == true)
            {
                ranger = Convert.ToInt32(DurTextBoxCh6.Text);
                if (ranger > 65534)
                {
                    DurTextBoxCh6.Text = "65534";
                }
            }
            else
            {
                DurTextBoxCh6.Clear();
            }

            if (DurTextBoxCh6.Text == "")
            {
                DurTextBoxCh6.Text = "0";
            }

            string buf = DurTextBoxCh6.Text;
            DurationPulseCH6 = Convert.ToUInt16(buf);
            DurationMassiveDataCH6 = BitConverter.GetBytes(DurationPulseCH6);
        }

        public void DelTextBoxch6_TextChanged(object sender, EventArgs e)
        {
            if (DelTextBoxch6.Text == "")
            {
                DelTextBoxch6.Text = "1";
            }

            
            Checking_text_for_a_number(DelTextBoxch6.Text, out bool res);
            if (res == true)
            {
                ranger = Convert.ToInt32(DelTextBoxch6.Text);
                if (ranger > 65534)
                {
                    DelTextBoxch6.Text = "65534";
                }
            }
            else
            {
                DelTextBoxch6.Clear();
            }

            if (DelTextBoxch6.Text == "0")
            {
                DelTextBoxch6.Text = "1";
            }

            string buf = DelTextBoxch6.Text;
            DelBetweenPulseCH6 = Convert.ToUInt16(buf);
            DelayMassiveDataCH6 = BitConverter.GetBytes(DelBetweenPulseCH6);
        }

        public void DurComboBoxCh6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DurComboBoxCh6.Text == "*10 нс")
            {
                DurMultiplierCH6 = 1;
            }
            else if(DurComboBoxCh6.Text == "мкс")
            {
                DurMultiplierCH6 = 2;
            }
            else //if(DurComboBoxCh6.Text == "мс")
            {
                DurMultiplierCH6 = 3;
            }
            //else 
            //{
            //    DurMultiplierCH6 = 4;                                                                                                Для секунд
            //}
        }

        public void DelComboBoxCh6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DelComboBoxCh6.Text == "*10 нс")
            {
                DelMultiplierCH6 = 1;
            }
            else if(DelComboBoxCh6.Text == "мкс")
            {
                DelMultiplierCH6 = 2;
            }
            else //if(DelComboBoxCh6.Text == "мс")
            {
                DelMultiplierCH6 = 3;
            }
            //else 
            //{
            //    DelMultiplierCH6 = 4;                                                                                                Для секунд
            //}
        }

        public void ComboBoxTypeStartCh6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxTypeStartCh6.Text == "Общий")
            {
                TypeStartCH6 = 1;
            }
            else if (ComboBoxTypeStartCh6.Text == "От предыдущего")
            {
                TypeStartCH6 = 2;
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////     КАНАЛ №7      //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void DurTextBoxCh7_TextChanged(object sender, EventArgs e)
        {
            if (DurTextBoxCh7.Text == "")
            {
                DurTextBoxCh7.Text = "1";
            }

            if (DurTextBoxCh7.Text == "0")
            {
                DurTextBoxCh7.Text = "1";
            }


            Checking_text_for_a_number(DurTextBoxCh7.Text, out bool res);
            if (res == true)
            {
                ranger = Convert.ToInt32(DurTextBoxCh7.Text);
                if (ranger > 65534)
                {
                    DurTextBoxCh7.Text = "65534";
                }
            }
            else
            {
                DurTextBoxCh7.Clear();
            }

            if (DurTextBoxCh7.Text == "")
            {
                DurTextBoxCh7.Text = "1";
            }

            string buf = DurTextBoxCh7.Text;
            DurationPulseCH7 = Convert.ToUInt16(buf);
            DurationMassiveDataCH7 = BitConverter.GetBytes(DurationPulseCH7);
        }

        public void DelTextBoxch7_TextChanged(object sender, EventArgs e)
        {
            if (DelTextBoxch7.Text == "")
            {
                DelTextBoxch7.Text = "1";
            }

            
            Checking_text_for_a_number(DelTextBoxch7.Text, out bool res);
            if (res == true)
            {
                ranger = Convert.ToInt32(DelTextBoxch7.Text);
                if (ranger > 65534)
                {
                    DelTextBoxch7.Text = "65534";
                }
            }
            else
            {
                DelTextBoxch7.Clear();
            }

            if (DelTextBoxch7.Text == "0")
            {
                DelTextBoxch7.Text = "1";
            }

            string buf = DelTextBoxch7.Text;
            DelBetweenPulseCH7 = Convert.ToUInt16(buf);
            DelayMassiveDataCH7 = BitConverter.GetBytes(DelBetweenPulseCH7);
        }

        public void DurComboBoxCh7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DurComboBoxCh7.Text == "*10 нс")
            {
                DurMultiplierCH7 = 1;
            }
            else if(DurComboBoxCh7.Text == "мкс")
            {
                DurMultiplierCH7 = 2;
            }
            else //if(DurComboBoxCh7.Text == "мс")
            {
                DurMultiplierCH7 = 3;
            }
            //else 
            //{
            //    DurMultiplierCH7 = 4;                                                                                                Для секунд
            //}
        }

        public void DelComboBoxCh7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DelComboBoxCh7.Text == "*10 нс")
            {
                DelMultiplierCH7 = 1;
            }
            else if(DelComboBoxCh7.Text == "мкс")
            {
                DelMultiplierCH7 = 2;
            }
            else //if(DelComboBoxCh7.Text == "мс")
            {
                DelMultiplierCH7 = 3;
            }
            //else
            //{
            //    DelMultiplierCH7 = 4;                                                                                                Для секунд
            //}
        }

        public void ComboBoxTypeStartCh7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxTypeStartCh7.Text == "Общий")
            {
                TypeStartCH7 = 1;
            }
            else if (ComboBoxTypeStartCh7.Text == "От предыдущего")
            {
                TypeStartCH7 = 2;
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////     КАНАЛ №8      //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void DurTextBoxCh8_TextChanged(object sender, EventArgs e)
        {
            if (DurTextBoxCh8.Text == "")
            {
                DurTextBoxCh8.Text = "1";
            }

            if (DurTextBoxCh8.Text == "0")
            {
                DurTextBoxCh8.Text = "1";
            }


            Checking_text_for_a_number(DurTextBoxCh8.Text, out bool res);
            if (res == true)
            {
                ranger = Convert.ToInt32(DurTextBoxCh8.Text);
                if (ranger > 65534)
                {
                    DurTextBoxCh8.Text = "65534";
                }
            }
            else
            {
                DurTextBoxCh8.Clear();
            }

            if (DurTextBoxCh8.Text == "")
            {
                DurTextBoxCh8.Text = "0";
            }

            string buf = DurTextBoxCh8.Text;
            DurationPulseCH8 = Convert.ToUInt16(buf);
            DurationMassiveDataCH8 = BitConverter.GetBytes(DurationPulseCH8);
        }

        public void DelTextBoxch8_TextChanged(object sender, EventArgs e)
        {
            if (DelTextBoxch8.Text == "")
            {
                DelTextBoxch8.Text = "1";
            }

            
            Checking_text_for_a_number(DelTextBoxch8.Text, out bool res);
            if (res == true)
            {
                ranger = Convert.ToInt32(DelTextBoxch8.Text);
                if (ranger > 65534)
                {
                    DelTextBoxch8.Text = "65534";
                }
            }
            else
            {
                DelTextBoxch8.Clear();
            }

            if (DelTextBoxch8.Text == "0")
            {
                DelTextBoxch8.Text = "1";
            }

            string buf = DelTextBoxch8.Text;
            DelBetweenPulseCH8 = Convert.ToUInt16(buf);
            DelayMassiveDataCH8 = BitConverter.GetBytes(DelBetweenPulseCH8);
        }

        public void DurComboBoxCh8_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DurComboBoxCh8.Text == "*10 нс")
            {
                DurMultiplierCH8 = 1;
            }
            else if(DurComboBoxCh8.Text == "мкс")
            {
                DurMultiplierCH8 = 2;
            }
            else //if(DurComboBoxCh8.Text == "мс")
            {
                DurMultiplierCH8 = 3;
            }
            //else
            //{
            //    DurMultiplierCH8 = 4;                                                                                                Для секунд
            //}
        }

        public void DelComboBoxCh8_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DelComboBoxCh8.Text == "*10 нс")
            {
                DelMultiplierCH8 = 1;
            }
            else if(DelComboBoxCh8.Text == "мкс")
            {
                DelMultiplierCH8 = 2;
            }
            else //if(DelComboBoxCh8.Text == "мс")
            {
                DelMultiplierCH8 = 3;
            }
            //else
            //{
            //    DelMultiplierCH8 = 4;                                                                                                Для секунд
            //}
        }

        public void ComboBoxTypeStartCh8_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxTypeStartCh8.Text == "Общий")
            {
                TypeStartCH8 = 1;
            }
            else if (ComboBoxTypeStartCh8.Text == "От предыдущего")
            {
                TypeStartCH8 = 2;
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////     КАНАЛ №9      //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void DurTextBoxCh9_TextChanged(object sender, EventArgs e)
        {

            if (DurTextBoxCh9.Text == "")
            {
                DurTextBoxCh9.Text = "1";
            }

            if (DurTextBoxCh9.Text == "0")
            {
                DurTextBoxCh9.Text = "1";
            }


            Checking_text_for_a_number(DurTextBoxCh9.Text, out bool res);
            if (res == true)
            {
                ranger = Convert.ToInt32(DurTextBoxCh9.Text);
                if (ranger > 65534)
                {
                    DurTextBoxCh9.Text = "65534";
                }
            }
            else
            {
                DurTextBoxCh9.Clear();
            }

            if (DurTextBoxCh9.Text == "")
            {
                DurTextBoxCh9.Text = "0";
            }

            string buf = DurTextBoxCh9.Text;
            DurationPulseCH9 = Convert.ToUInt16(buf);
            DurationMassiveDataCH9 = BitConverter.GetBytes(DurationPulseCH9);
        }

        public void DelTextBoxch9_TextChanged(object sender, EventArgs e)
        {
            if (DelTextBoxch9.Text == "")
            {
                DelTextBoxch9.Text = "1";
            }

            
            Checking_text_for_a_number(DelTextBoxch9.Text, out bool res);
            if (res == true)
            {
                ranger = Convert.ToInt32(DelTextBoxch9.Text);
                if (ranger > 65534)
                {
                    DelTextBoxch9.Text = "65534";
                }
            }
            else
            {
                DelTextBoxch9.Clear();
            }

            if (DelTextBoxch9.Text == "0")
            {
                DelTextBoxch9.Text = "1";
            }

            string buf = DelTextBoxch9.Text;
            DelBetweenPulseCH9 = Convert.ToUInt16(buf);
            DelayMassiveDataCH9 = BitConverter.GetBytes(DelBetweenPulseCH9);
        }

        public void DurComboBoxCh9_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DurComboBoxCh9.Text == "*10 нс")
            {
                DurMultiplierCH9 = 1;
            }
            else if(DurComboBoxCh9.Text == "мкс")
            {
                DurMultiplierCH9 = 2;
            }
            else //if(DurComboBoxCh9.Text == "мс")
            {
                DurMultiplierCH9 = 3;
            }
            //else
            //{
            //    DurMultiplierCH9 = 4;                                                                                                Для секунд
            //}
        }

        public void DelComboBoxCh9_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DelComboBoxCh9.Text == "*10 нс")
            {
                DelMultiplierCH9 = 1;
            }
            else if(DelComboBoxCh9.Text == "мкс")
            {
                DelMultiplierCH9 = 2;
            }
            else //if(DelComboBoxCh9.Text == "мс")
            {
                DelMultiplierCH9 = 3;
            }
            //else
            //{
            //    DelMultiplierCH9 = 4;                                                                                                Для секунд
            //}
        }

        public void ComboBoxTypeStartCh9_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxTypeStartCh9.Text == "Общий")
            {
                TypeStartCH9 = 1;
            }
            else if (ComboBoxTypeStartCh9.Text == "От предыдущего")
            {
                TypeStartCH9 = 2;
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////     КАНАЛ №10      //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void DurTextBoxCh10_TextChanged(object sender, EventArgs e)
        {
            if (DurTextBoxCh10.Text == "")
            {
                DurTextBoxCh10.Text = "1";
            }

            if (DurTextBoxCh10.Text == "0")
            {
                DurTextBoxCh10.Text = "1";
            }


            Checking_text_for_a_number(DurTextBoxCh10.Text, out bool res);
            if (res == true)
            {
                ranger = Convert.ToInt32(DurTextBoxCh10.Text);
                if (ranger > 65534)
                {
                    DurTextBoxCh10.Text = "65534";
                }
            }
            else
            {
                DurTextBoxCh10.Clear();
            }

            if (DurTextBoxCh10.Text == "")
            {
                DurTextBoxCh10.Text = "0";
            }

            string buf = DurTextBoxCh10.Text;
            DurationPulseCH10 = Convert.ToUInt16(buf);
            DurationMassiveDataCH10 = BitConverter.GetBytes(DurationPulseCH10);
        }

        public void DelTextBoxch10_TextChanged(object sender, EventArgs e)
        {
            if (DelTextBoxch10.Text == "")
            {
                DelTextBoxch10.Text = "1";
            }

            
            Checking_text_for_a_number(DelTextBoxch10.Text, out bool res);
            if (res == true)
            {
                ranger = Convert.ToInt32(DelTextBoxch10.Text);
                if (ranger > 65534)
                {
                    DelTextBoxch10.Text = "65534";
                }
            }
            else
            {
                DelTextBoxch10.Clear();
            }

            if (DelTextBoxch10.Text == "0")
            {
                DelTextBoxch10.Text = "1";
            }

            string buf = DelTextBoxch10.Text;
            DelBetweenPulseCH10 = Convert.ToUInt16(buf);
            DelayMassiveDataCH10 = BitConverter.GetBytes(DelBetweenPulseCH10);
        }

        public void DurComboBoxCh10_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DurComboBoxCh10.Text == "*10 нс")
            {
                DurMultiplierCH10 = 1;
            }
            else if(DurComboBoxCh10.Text == "мкс")
            {
                DurMultiplierCH10 = 2;
            }
            else //if(DurComboBoxCh10.Text == "мс")
            {
                DurMultiplierCH10 = 3;
            }
            //else
            //{
            //    DurMultiplierCH10 = 4;                                                                                                Для секунд
            //}
        }

        public void DelComboBoxCh10_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DelComboBoxCh10.Text == "*10 нс")
            {
                DelMultiplierCH10 = 1;
            }
            else if(DelComboBoxCh10.Text == "мкс")
            {
                DelMultiplierCH10 = 2;
            }
            else //if(DelComboBoxCh10.Text == "мс")
            {
                DelMultiplierCH10 = 3;
            }
            //else
            //{
            //    DelMultiplierCH10 = 4;                                                                                                Для секунд
            //}
        }

        public void ComboBoxTypeStartCh10_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxTypeStartCh10.Text == "Общий")
            {
                TypeStartCH10 = 1;
            }
            else if (ComboBoxTypeStartCh10.Text == "От предыдущего")
            {
                TypeStartCH10 = 2;
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////     КАНАЛ №11      //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void DurTextBoxCh11_TextChanged(object sender, EventArgs e)
        {
            if (DurTextBoxCh11.Text == "")
            {
                DurTextBoxCh11.Text = "1";
            }

            if (DurTextBoxCh11.Text == "0")
            {
                DurTextBoxCh11.Text = "1";
            }


            Checking_text_for_a_number(DurTextBoxCh11.Text, out bool res);
            if (res == true)
            {
                ranger = Convert.ToInt32(DurTextBoxCh11.Text);
                if (ranger > 65534)
                {
                    DurTextBoxCh11.Text = "65534";
                }
            }
            else
            {
                DurTextBoxCh11.Clear();
            }

            if (DurTextBoxCh11.Text == "")
            {
                DurTextBoxCh11.Text = "0";
            }

            string buf = DurTextBoxCh11.Text;
            DurationPulseCH11 = Convert.ToUInt16(buf);
            DurationMassiveDataCH11 = BitConverter.GetBytes(DurationPulseCH11);
        }

        public void DelTextBoxch11_TextChanged(object sender, EventArgs e)
        {
            if (DelTextBoxch11.Text == "")
            {
                DelTextBoxch11.Text = "1";
            }

            
            Checking_text_for_a_number(DelTextBoxch11.Text, out bool res);
            if (res == true)
            {
                ranger = Convert.ToInt32(DelTextBoxch11.Text);
                if (ranger > 65534)
                {
                    DelTextBoxch11.Text = "65534";
                }
            }
            else
            {
                DelTextBoxch11.Clear();
            }

            if (DelTextBoxch11.Text == "0")
            {
                DelTextBoxch11.Text = "1";
            }

            string buf = DelTextBoxch11.Text;
            DelBetweenPulseCH11 = Convert.ToUInt16(buf);
            DelayMassiveDataCH11 = BitConverter.GetBytes(DelBetweenPulseCH11);
        }

        public void DurComboBoxCh11_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DurComboBoxCh11.Text == "*10 нс")
            {
                DurMultiplierCH11 = 1;
            }
            else if(DurComboBoxCh11.Text == "мкс")
            {
                DurMultiplierCH11 = 2;
            }
            else //if(DurComboBoxCh11.Text == "мс")
            {
                DurMultiplierCH11 = 3;
            }
            //else
            //{
            //    DurMultiplierCH11 = 4;                                                                                                Для секунд
            //}
        }

        public void DelComboBoxCh11_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DelComboBoxCh11.Text == "*10 нс")
            {
                DelMultiplierCH11 = 1;
            }
            else if(DelComboBoxCh11.Text == "мкс")
            {
                DelMultiplierCH11 = 2;
            }
            else //if(DelComboBoxCh11.Text == "мс")
            {
                DelMultiplierCH11 = 3;
            }
            //else
            //{
            //    DelMultiplierCH11 = 4;                                                                                                Для секунд
            //}
        }

        public void ComboBoxTypeStartCh11_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxTypeStartCh11.Text == "Общий")
            {
                TypeStartCH11 = 1;
            }
            else if (ComboBoxTypeStartCh11.Text == "От предыдущего")
            {
                TypeStartCH11 = 2;
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////     КАНАЛ №12      //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void DurTextBoxCh12_TextChanged(object sender, EventArgs e)
        {
            if (DurTextBoxCh12.Text == "")
            {
                DurTextBoxCh12.Text = "1";
            }

            if (DurTextBoxCh12.Text == "0")
            {
                DurTextBoxCh12.Text = "1";
            }


            Checking_text_for_a_number(DurTextBoxCh12.Text, out bool res);
            if (res == true)
            {
                ranger = Convert.ToInt32(DurTextBoxCh12.Text);
                if (ranger > 65534)
                {
                    DurTextBoxCh12.Text = "65534";
                }
            }
            else
            {
                DurTextBoxCh12.Clear();
            }

            if (DurTextBoxCh12.Text == "")
            {
                DurTextBoxCh12.Text = "0";
            }

            string buf = DurTextBoxCh12.Text;
            DurationPulseCH12 = Convert.ToUInt16(buf);
            DurationMassiveDataCH12 = BitConverter.GetBytes(DurationPulseCH12);
        }

        public void DelTextBoxch12_TextChanged(object sender, EventArgs e)
        {
            if (DelTextBoxch12.Text == "")
            {
                DelTextBoxch12.Text = "1";
            }

            
            Checking_text_for_a_number(DelTextBoxch12.Text, out bool res);
            if (res == true)
            {
                ranger = Convert.ToInt32(DelTextBoxch12.Text);
                if (ranger > 65534)
                {
                    DelTextBoxch12.Text = "65534";
                }
            }
            else
            {
                DelTextBoxch12.Clear();
            }

            if (DelTextBoxch12.Text == "0")
            {
                DelTextBoxch12.Text = "1";
            }

            string buf = DelTextBoxch12.Text;
            DelBetweenPulseCH12 = Convert.ToUInt16(buf);
            DelayMassiveDataCH12 = BitConverter.GetBytes(DelBetweenPulseCH12);
        }

        public void DurComboBoxCh12_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DurComboBoxCh12.Text == "*10 нс")
            {
                DurMultiplierCH12 = 1;
            }
            else if(DurComboBoxCh12.Text == "мкс")
            {
                DurMultiplierCH12 = 2;
            }
            else //if(DurComboBoxCh12.Text == "мс")
            {
                DurMultiplierCH12 = 3;
            }
            //else
            //{
            //    DurMultiplierCH12 = 4;                                                                                                Для секунд
            //}
        }

        public void DelComboBoxCh12_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DelComboBoxCh12.Text == "*10 нс")
            {
                DelMultiplierCH12 = 1;
            }
            else if(DelComboBoxCh12.Text == "мкс")
            {
                DelMultiplierCH12 = 2;
            }
            else //if(DelComboBoxCh12.Text == "мс")
            {
                DelMultiplierCH12 = 3;
            }
            //else
            //{
            //    DelMultiplierCH12 = 4;                                                                                                Для секунд
            //}
        }

        public void ComboBoxTypeStartCh12_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxTypeStartCh12.Text == "Общий")
            {
                TypeStartCH12 = 1;
            }
            else if (ComboBoxTypeStartCh12.Text == "От предыдущего")
            {
                TypeStartCH12 = 2;
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////     КАНАЛ №13      //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void DurTextBoxCh13_TextChanged(object sender, EventArgs e)
        {
            if (DurTextBoxCh13.Text == "")
            {
                DurTextBoxCh13.Text = "1";
            }

            if (DurTextBoxCh13.Text == "0")
            {
                DurTextBoxCh13.Text = "1";
            }


            Checking_text_for_a_number(DurTextBoxCh13.Text, out bool res);
            if (res == true)
            {
                ranger = Convert.ToInt32(DurTextBoxCh13.Text);
                if (ranger > 65534)
                {
                    DurTextBoxCh13.Text = "65534";
                }
            }
            else
            {
                DurTextBoxCh13.Clear();
            }

            if (DurTextBoxCh13.Text == "")
            {
                DurTextBoxCh13.Text = "0";
            }

            string buf = DurTextBoxCh13.Text;
            DurationPulseCH13 = Convert.ToUInt16(buf);
            DurationMassiveDataCH13 = BitConverter.GetBytes(DurationPulseCH13);
        }

        public void DelTextBoxch13_TextChanged(object sender, EventArgs e)
        {
            if (DelTextBoxch13.Text == "")
            {
                DelTextBoxch13.Text = "1";
            }

            
            Checking_text_for_a_number(DelTextBoxch13.Text, out bool res);
            if (res == true)
            {
                ranger = Convert.ToInt32(DelTextBoxch13.Text);
                if (ranger > 65534)
                {
                    DelTextBoxch13.Text = "65534";
                }
            }
            else
            {
                DelTextBoxch13.Clear();
            }

            if (DelTextBoxch13.Text == "0")
            {
                DelTextBoxch13.Text = "1";
            }

            string buf = DelTextBoxch13.Text;
            DelBetweenPulseCH13 = Convert.ToUInt16(buf);
            DelayMassiveDataCH13 = BitConverter.GetBytes(DelBetweenPulseCH13);
        }

        public void DurComboBoxCh13_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DurComboBoxCh13.Text == "*10 нс")
            {
                DurMultiplierCH13 = 1;
            }
            else if(DurComboBoxCh13.Text == "мкс")
            {
                DurMultiplierCH13 = 2;
            }
            else //if(DurComboBoxCh13.Text == "мс")
            {
                DurMultiplierCH13 = 3;
            }
            //else
            //{
            //    DurMultiplierCH13 = 4;                                                                                                Для секунд
            //}
        }

        public void DelComboBoxCh13_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DelComboBoxCh13.Text == "*10 нс")
            {
                DelMultiplierCH13 = 1;
            }
            else if(DelComboBoxCh13.Text == "мкс")
            {
                DelMultiplierCH13 = 2;
            }
            else //if(DelComboBoxCh13.Text == "мс")
            {
                DelMultiplierCH13 = 3;
            }
            //else
            //{
            //    DelMultiplierCH13 = 4;                                                                                                Для секунд
            //}
        }

        public void ComboBoxTypeStartCh13_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxTypeStartCh13.Text == "Общий")
            {
                TypeStartCH13 = 1;
            }
            else if (ComboBoxTypeStartCh13.Text == "От предыдущего")
            {
                TypeStartCH13 = 2;
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////        
        ///////////////////////////////////////////////////////////////////////////////////////////////////////     КАНАЛ №14      //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void DurTextBoxCh14_TextChanged(object sender, EventArgs e)
        {
            if (DurTextBoxCh14.Text == "")
            {
                DurTextBoxCh14.Text = "1";
            }

            if (DurTextBoxCh14.Text == "0")
            {
                DurTextBoxCh14.Text = "1";
            }


            Checking_text_for_a_number(DurTextBoxCh14.Text, out bool res);
            if (res == true)
            {
                ranger = Convert.ToInt32(DurTextBoxCh14.Text);
                if (ranger > 65534)
                {
                    DurTextBoxCh14.Text = "65534";
                }
            }
            else
            {
                DurTextBoxCh14.Clear();
            }

            if (DurTextBoxCh14.Text == "")
            {
                DurTextBoxCh14.Text = "0";
            }

            string buf = DurTextBoxCh14.Text;
            DurationPulseCH14 = Convert.ToUInt16(buf);
            DurationMassiveDataCH14 = BitConverter.GetBytes(DurationPulseCH14);
        }

        public void DelTextBoxch14_TextChanged(object sender, EventArgs e)
        {
            if (DelTextBoxch14.Text == "")
            {
                DelTextBoxch14.Text = "1";
            }

            
            Checking_text_for_a_number(DelTextBoxch14.Text, out bool res);
            if (res == true)
            {
                ranger = Convert.ToInt32(DelTextBoxch14.Text);
                if (ranger > 65534)
                {
                    DelTextBoxch14.Text = "65534";
                }
            }
            else
            {
                DelTextBoxch14.Clear();
            }

            if (DelTextBoxch14.Text == "0")
            {
                DelTextBoxch14.Text = "1";
            }

            string buf = DelTextBoxch14.Text;
            DelBetweenPulseCH14 = Convert.ToUInt16(buf);
            DelayMassiveDataCH14 = BitConverter.GetBytes(DelBetweenPulseCH14);
        }

        public void DurComboBoxCh14_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DurComboBoxCh14.Text == "*10 нс")
            {
                DurMultiplierCH14 = 1;
            }
            else if(DurComboBoxCh14.Text == "мкс")
            {
                DurMultiplierCH14 = 2;
            }
            else //if(DurComboBoxCh14.Text == "мс")
            {
                DurMultiplierCH14 = 3;
            }
            //else
            //{
            //    DurMultiplierCH14 = 4;                                                                                                Для секунд
            //}
        }

        public void DelComboBoxCh14_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DelComboBoxCh14.Text == "*10 нс")
            {
                DelMultiplierCH14 = 1;
            }
            else if(DelComboBoxCh14.Text == "мкс")
            {
                DelMultiplierCH14 = 2;
            }
            else //if(DelComboBoxCh14.Text == "мс")
            {
                DelMultiplierCH14 = 3;
            }
            //else
            //{
            //    DelMultiplierCH14 = 4;                                                                                                Для секунд
            //}
        }

        public void ComboBoxTypeStartCh14_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxTypeStartCh14.Text == "Общий")
            {
                TypeStartCH14 = 1;
            }
            else if (ComboBoxTypeStartCh14.Text == "От предыдущего")
            {
                TypeStartCH14 = 2;
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////     
        ///////////////////////////////////////////////////////////////////////////////////////////////////////     КАНАЛ №15      //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void DurTextBoxCh15_TextChanged(object sender, EventArgs e)
        {
            if (DurTextBoxCh15.Text == "")
            {
                DurTextBoxCh15.Text = "1";
            }

            if (DurTextBoxCh15.Text == "0")
            {
                DurTextBoxCh15.Text = "1";
            }


            Checking_text_for_a_number(DurTextBoxCh15.Text, out bool res);
            if (res == true)
            {
                ranger = Convert.ToInt32(DurTextBoxCh15.Text);
                if (ranger > 65534)
                {
                    DurTextBoxCh15.Text = "65534";
                }
            }
            else
            {
                DurTextBoxCh15.Clear();
            }

            if (DurTextBoxCh15.Text == "")
            {
                DurTextBoxCh15.Text = "0";
            }

            string buf = DurTextBoxCh15.Text;
            DurationPulseCH15 = Convert.ToUInt16(buf);
            DurationMassiveDataCH15 = BitConverter.GetBytes(DurationPulseCH15);
        }

        public void DelTextBoxch15_TextChanged(object sender, EventArgs e)
        {
            if (DelTextBoxch15.Text == "")
            {
                DelTextBoxch15.Text = "1";
            }

            
            Checking_text_for_a_number(DelTextBoxch15.Text, out bool res);
            if (res == true)
            {
                ranger = Convert.ToInt32(DelTextBoxch15.Text);
                if (ranger > 65534)
                {
                    DelTextBoxch15.Text = "65534";
                }
            }
            else
            {
                DelTextBoxch15.Clear();
            }

            if (DelTextBoxch15.Text == "0")
            {
                DelTextBoxch15.Text = "1";
            }

            string buf = DelTextBoxch15.Text;
            DelBetweenPulseCH15 = Convert.ToUInt16(buf);
            DelayMassiveDataCH15 = BitConverter.GetBytes(DelBetweenPulseCH15);
        }

        public void DurComboBoxCh15_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DurComboBoxCh15.Text == "*10 нс")
            {
                DurMultiplierCH15 = 1;
            }
            else if(DurComboBoxCh15.Text == "мкс")
            {
                DurMultiplierCH15 = 2;
            }
            else //if(DurComboBoxCh15.Text == "мс")
            {
                DurMultiplierCH15 = 3;
            }
            //else
            //{
            //    DurMultiplierCH15 = 4;                                                                                                Для секунд
            //}
        }

        public void DelComboBoxCh15_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DelComboBoxCh15.Text == "*10 нс")
            {
                DelMultiplierCH15 = 1;
            }
            else if(DelComboBoxCh15.Text == "мкс")
            {
                DelMultiplierCH15 = 2;
            }
            else //if(DelComboBoxCh15.Text == "мс")
            {
                DelMultiplierCH15 = 3;
            }
            //else
            //{
            //    DelMultiplierCH15 = 4;                                                                                                Для секунд
            //}
        }

        public void ComboBoxTypeStartCh15_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxTypeStartCh15.Text == "Общий")
            {
                TypeStartCH15 = 1;
            }
            else if (ComboBoxTypeStartCh15.Text == "От предыдущего")
            {
                TypeStartCH15 = 2;
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////       
        ///////////////////////////////////////////////////////////////////////////////////////////////////////     КАНАЛ №16      //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void DurTextBoxCh16_TextChanged(object sender, EventArgs e)
        {
            if (DurTextBoxCh16.Text == "")
            {
                DurTextBoxCh16.Text = "1";
            }

            if (DurTextBoxCh16.Text == "0")
            {
                DurTextBoxCh16.Text = "1";
            }


            Checking_text_for_a_number(DurTextBoxCh16.Text, out bool res);
            if (res == true)
            {
                ranger = Convert.ToInt32(DurTextBoxCh16.Text);
                if (ranger > 65534)
                {
                    DurTextBoxCh16.Text = "65534";
                }
            }
            else
            {
                DurTextBoxCh16.Clear();
            }

            if (DurTextBoxCh16.Text == "0")
            {
                DurTextBoxCh16.Text = "1";
            }

            string buf = DurTextBoxCh16.Text;
            DurationPulseCH16 = Convert.ToUInt16(buf);
            DurationMassiveDataCH16 = BitConverter.GetBytes(DurationPulseCH16);
        }

        public void DelTextBoxch16_TextChanged(object sender, EventArgs e)
        {
            if (DelTextBoxch16.Text == "")
            {
                DelTextBoxch16.Text = "1";
            }

            
            Checking_text_for_a_number(DelTextBoxch16.Text, out bool res);
            if (res == true)
            {
                ranger = Convert.ToInt32(DelTextBoxch16.Text);
                if (ranger > 65534)
                {
                    DelTextBoxch16.Text = "65534";
                }
            }
            else
            {
                DelTextBoxch16.Clear();
            }

            if (DelTextBoxch16.Text == "0")
            {
                DelTextBoxch16.Text = "1";
            }

            
            string buf = DelTextBoxch16.Text;
            DelBetweenPulseCH16 = Convert.ToUInt16(buf);
            DelayMassiveDataCH16 = BitConverter.GetBytes(DelBetweenPulseCH16);
        ///    DelayMassiveDataCH16[0] = 232;
        ///    DelayMassiveDataCH16[1] = 3;
        ///    DelMultiplierCH16 = 3;
        }

        public void DurComboBoxCh16_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DurComboBoxCh16.Text == "*10 нс")
            {
                DurMultiplierCH16 = 1;
            }
            else if(DurComboBoxCh16.Text == "мкс")
            {
                DurMultiplierCH16 = 2;
            }
            else //if(DurComboBoxCh16.Text == "мс")
            {
                DurMultiplierCH16 = 3;
            }
            //else
            //{
            //    DurMultiplierCH16 = 4;                                                                                                Для секунд
            //}
        }

        public void DelComboBoxCh16_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DelComboBoxCh16.Text == "*10 нс")
            {
                DelMultiplierCH16 = 1;
            }
           else if(DelComboBoxCh16.Text == "мкс")
            {
                DelMultiplierCH16 = 2;
            }
            else //if(DelComboBoxCh16.Text == "мс")
            {
                DelMultiplierCH16 = 3;
            }
            //else
            //{
            //    DelMultiplierCH16 = 4;                                                                                                Для секунд
            //}
        }

        public void ComboBoxTypeStartCh16_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxTypeStartCh16.Text == "Общий")
            {
                TypeStartCH16 = 1;
            }
            else if (ComboBoxTypeStartCh16.Text == "От предыдущего")
            {
                TypeStartCH16 = 2;
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////       
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        public bool Checking_text_for_a_number(string text, out bool res)                        // Функция проверки текста на число               
        {
            bool IsDigit = text.Length == text.Where(c => char.IsDigit(c)).Count();

            if (IsDigit == true)
            {
            }
            else
            {
                MessageBox.Show("Введите число от 0 до 65534", "Сообщение",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1);
                //MessageBoxOptions.ServiceNotification);
            }
            return res = IsDigit;
        }

        public void LoadConfFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                   
                    filePath = openFileDialog.FileName;

                    using (StreamReader sr = new StreamReader(filePath, System.Text.Encoding.Default))
                    {

                        DurTextBoxCh1.Text = sr.ReadLine();
                        DurTextBoxCh2.Text = sr.ReadLine();
                        DurTextBoxCh3.Text = sr.ReadLine();
                        DurTextBoxCh4.Text = sr.ReadLine();
                        DurTextBoxCh5.Text = sr.ReadLine();
                        DurTextBoxCh6.Text = sr.ReadLine();
                        DurTextBoxCh7.Text = sr.ReadLine();
                        DurTextBoxCh8.Text = sr.ReadLine();
                        DurTextBoxCh9.Text = sr.ReadLine();
                        DurTextBoxCh10.Text = sr.ReadLine();
                        DurTextBoxCh11.Text = sr.ReadLine();
                        DurTextBoxCh12.Text = sr.ReadLine();
                        DurTextBoxCh13.Text = sr.ReadLine();
                        DurTextBoxCh14.Text = sr.ReadLine();
                        DurTextBoxCh15.Text = sr.ReadLine();
                        DurTextBoxCh16.Text = sr.ReadLine();

                        DelTextBoxch1.Text = sr.ReadLine();
                        DelTextBoxch2.Text = sr.ReadLine();
                        DelTextBoxch3.Text = sr.ReadLine();
                        DelTextBoxch4.Text = sr.ReadLine();
                        DelTextBoxch5.Text = sr.ReadLine();
                        DelTextBoxch6.Text = sr.ReadLine();
                        DelTextBoxch7.Text = sr.ReadLine();
                        DelTextBoxch8.Text = sr.ReadLine();
                        DelTextBoxch9.Text = sr.ReadLine();
                        DelTextBoxch10.Text = sr.ReadLine();
                        DelTextBoxch11.Text = sr.ReadLine();
                        DelTextBoxch12.Text = sr.ReadLine();
                        DelTextBoxch13.Text = sr.ReadLine();
                        DelTextBoxch14.Text = sr.ReadLine();
                        DelTextBoxch15.Text = sr.ReadLine();
                        DelTextBoxch16.Text = sr.ReadLine();

                        DurComboBoxCh1.Text = sr.ReadLine();
                        DurComboBoxCh2.Text = sr.ReadLine();
                        DurComboBoxCh3.Text = sr.ReadLine();
                        DurComboBoxCh4.Text = sr.ReadLine();
                        DurComboBoxCh5.Text = sr.ReadLine();
                        DurComboBoxCh6.Text = sr.ReadLine();
                        DurComboBoxCh7.Text = sr.ReadLine();
                        DurComboBoxCh8.Text = sr.ReadLine();
                        DurComboBoxCh9.Text = sr.ReadLine();
                        DurComboBoxCh10.Text = sr.ReadLine();
                        DurComboBoxCh11.Text = sr.ReadLine();
                        DurComboBoxCh12.Text = sr.ReadLine();
                        DurComboBoxCh13.Text = sr.ReadLine();
                        DurComboBoxCh14.Text = sr.ReadLine();
                        DurComboBoxCh15.Text = sr.ReadLine();
                        DurComboBoxCh16.Text = sr.ReadLine();

                        DelComboBoxCh1.Text = sr.ReadLine();
                        DelComboBoxCh2.Text = sr.ReadLine();
                        DelComboBoxCh3.Text = sr.ReadLine();
                        DelComboBoxCh4.Text = sr.ReadLine();
                        DelComboBoxCh5.Text = sr.ReadLine();
                        DelComboBoxCh6.Text = sr.ReadLine();
                        DelComboBoxCh7.Text = sr.ReadLine();
                        DelComboBoxCh8.Text = sr.ReadLine();
                        DelComboBoxCh9.Text = sr.ReadLine();
                        DelComboBoxCh10.Text = sr.ReadLine();
                        DelComboBoxCh11.Text = sr.ReadLine();
                        DelComboBoxCh12.Text = sr.ReadLine();
                        DelComboBoxCh13.Text = sr.ReadLine();
                        DelComboBoxCh14.Text = sr.ReadLine();
                        DelComboBoxCh15.Text = sr.ReadLine();
                        DelComboBoxCh16.Text = sr.ReadLine();

                        ComboBoxTypeStartCh1.Text = sr.ReadLine();
                        ComboBoxTypeStartCh2.Text = sr.ReadLine();
                        ComboBoxTypeStartCh3.Text = sr.ReadLine();
                        ComboBoxTypeStartCh4.Text = sr.ReadLine();
                        ComboBoxTypeStartCh5.Text = sr.ReadLine();
                        ComboBoxTypeStartCh6.Text = sr.ReadLine();
                        ComboBoxTypeStartCh7.Text = sr.ReadLine();
                        ComboBoxTypeStartCh8.Text = sr.ReadLine();
                        ComboBoxTypeStartCh9.Text = sr.ReadLine();
                        ComboBoxTypeStartCh10.Text = sr.ReadLine();
                        ComboBoxTypeStartCh11.Text = sr.ReadLine();
                        ComboBoxTypeStartCh12.Text = sr.ReadLine();
                        ComboBoxTypeStartCh13.Text = sr.ReadLine();
                        ComboBoxTypeStartCh14.Text = sr.ReadLine();
                        ComboBoxTypeStartCh15.Text = sr.ReadLine();
                        ComboBoxTypeStartCh16.Text = sr.ReadLine();

                        CommentCh1.Text = sr.ReadLine();
                        CommentCh2.Text = sr.ReadLine();
                        CommentCh3.Text = sr.ReadLine();
                        CommentCh4.Text = sr.ReadLine();
                        CommentCh5.Text = sr.ReadLine();
                        CommentCh6.Text = sr.ReadLine();
                        CommentCh7.Text = sr.ReadLine();
                        CommentCh8.Text = sr.ReadLine();
                        CommentCh9.Text = sr.ReadLine();
                        CommentCh10.Text = sr.ReadLine();
                        CommentCh11.Text = sr.ReadLine();
                        CommentCh12.Text = sr.ReadLine();
                        CommentCh13.Text = sr.ReadLine();
                        CommentCh14.Text = sr.ReadLine();
                        CommentCh15.Text = sr.ReadLine();
                        CommentCh16.Text = sr.ReadLine();
                    }
                }
            }
        }

        public void SaveFIleConfig_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = "c:\\";
                saveFileDialog.Filter = "txt files (*.txt)|*.txt";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = saveFileDialog.FileName;

                    
                    using (StreamWriter sw = new StreamWriter(filePath, false, System.Text.Encoding.Default))
                    {
                        sw.WriteLine(DurTextBoxCh1.Text);
                        sw.WriteLine(DurTextBoxCh2.Text);
                        sw.WriteLine(DurTextBoxCh3.Text);
                        sw.WriteLine(DurTextBoxCh4.Text);
                        sw.WriteLine(DurTextBoxCh5.Text);
                        sw.WriteLine(DurTextBoxCh6.Text);
                        sw.WriteLine(DurTextBoxCh7.Text);
                        sw.WriteLine(DurTextBoxCh8.Text);
                        sw.WriteLine(DurTextBoxCh9.Text);
                        sw.WriteLine(DurTextBoxCh10.Text);
                        sw.WriteLine(DurTextBoxCh11.Text);
                        sw.WriteLine(DurTextBoxCh12.Text);
                        sw.WriteLine(DurTextBoxCh13.Text);
                        sw.WriteLine(DurTextBoxCh14.Text);
                        sw.WriteLine(DurTextBoxCh15.Text);
                        sw.WriteLine(DurTextBoxCh16.Text);

                        sw.WriteLine(DelTextBoxch1.Text);
                        sw.WriteLine(DelTextBoxch2.Text);
                        sw.WriteLine(DelTextBoxch3.Text);
                        sw.WriteLine(DelTextBoxch4.Text);
                        sw.WriteLine(DelTextBoxch5.Text);
                        sw.WriteLine(DelTextBoxch6.Text);
                        sw.WriteLine(DelTextBoxch7.Text);
                        sw.WriteLine(DelTextBoxch8.Text);
                        sw.WriteLine(DelTextBoxch9.Text);
                        sw.WriteLine(DelTextBoxch10.Text);
                        sw.WriteLine(DelTextBoxch11.Text);
                        sw.WriteLine(DelTextBoxch12.Text);
                        sw.WriteLine(DelTextBoxch13.Text);
                        sw.WriteLine(DelTextBoxch14.Text);
                        sw.WriteLine(DelTextBoxch15.Text);
                        sw.WriteLine(DelTextBoxch16.Text);

                        sw.WriteLine(DurComboBoxCh1.Text);
                        sw.WriteLine(DurComboBoxCh2.Text);
                        sw.WriteLine(DurComboBoxCh3.Text);
                        sw.WriteLine(DurComboBoxCh4.Text);
                        sw.WriteLine(DurComboBoxCh5.Text);
                        sw.WriteLine(DurComboBoxCh6.Text);
                        sw.WriteLine(DurComboBoxCh7.Text);
                        sw.WriteLine(DurComboBoxCh8.Text);
                        sw.WriteLine(DurComboBoxCh9.Text);
                        sw.WriteLine(DurComboBoxCh10.Text);
                        sw.WriteLine(DurComboBoxCh11.Text);
                        sw.WriteLine(DurComboBoxCh12.Text);
                        sw.WriteLine(DurComboBoxCh13.Text);
                        sw.WriteLine(DurComboBoxCh14.Text);
                        sw.WriteLine(DurComboBoxCh15.Text);
                        sw.WriteLine(DurComboBoxCh16.Text);

                        sw.WriteLine(DelComboBoxCh1.Text);
                        sw.WriteLine(DelComboBoxCh2.Text);
                        sw.WriteLine(DelComboBoxCh3.Text);
                        sw.WriteLine(DelComboBoxCh4.Text);
                        sw.WriteLine(DelComboBoxCh5.Text);
                        sw.WriteLine(DelComboBoxCh6.Text);
                        sw.WriteLine(DelComboBoxCh7.Text);
                        sw.WriteLine(DelComboBoxCh8.Text);
                        sw.WriteLine(DelComboBoxCh9.Text);
                        sw.WriteLine(DelComboBoxCh10.Text);
                        sw.WriteLine(DelComboBoxCh11.Text);
                        sw.WriteLine(DelComboBoxCh12.Text);
                        sw.WriteLine(DelComboBoxCh13.Text);
                        sw.WriteLine(DelComboBoxCh14.Text);
                        sw.WriteLine(DelComboBoxCh15.Text);
                        sw.WriteLine(DelComboBoxCh16.Text);

                        sw.WriteLine(ComboBoxTypeStartCh1.Text);
                        sw.WriteLine(ComboBoxTypeStartCh2.Text);
                        sw.WriteLine(ComboBoxTypeStartCh3.Text);
                        sw.WriteLine(ComboBoxTypeStartCh4.Text);
                        sw.WriteLine(ComboBoxTypeStartCh5.Text);
                        sw.WriteLine(ComboBoxTypeStartCh6.Text);
                        sw.WriteLine(ComboBoxTypeStartCh7.Text);
                        sw.WriteLine(ComboBoxTypeStartCh8.Text);
                        sw.WriteLine(ComboBoxTypeStartCh9.Text);
                        sw.WriteLine(ComboBoxTypeStartCh10.Text);
                        sw.WriteLine(ComboBoxTypeStartCh11.Text);
                        sw.WriteLine(ComboBoxTypeStartCh12.Text);
                        sw.WriteLine(ComboBoxTypeStartCh13.Text);
                        sw.WriteLine(ComboBoxTypeStartCh14.Text);
                        sw.WriteLine(ComboBoxTypeStartCh15.Text);
                        sw.WriteLine(ComboBoxTypeStartCh16.Text);

                        sw.WriteLine(CommentCh1.Text);
                        sw.WriteLine(CommentCh2.Text);
                        sw.WriteLine(CommentCh3.Text);
                        sw.WriteLine(CommentCh4.Text);
                        sw.WriteLine(CommentCh5.Text);
                        sw.WriteLine(CommentCh6.Text);
                        sw.WriteLine(CommentCh7.Text);
                        sw.WriteLine(CommentCh8.Text);
                        sw.WriteLine(CommentCh9.Text);
                        sw.WriteLine(CommentCh10.Text);
                        sw.WriteLine(CommentCh11.Text);
                        sw.WriteLine(CommentCh12.Text);
                        sw.WriteLine(CommentCh13.Text);
                        sw.WriteLine(CommentCh14.Text);
                        sw.WriteLine(CommentCh15.Text);
                        sw.WriteLine(CommentCh16.Text);




                    }


                }

                

            }

        }

        public void TypeLaunchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {   
            
            if (TypeLaunchComboBox.Text == "Внешний ПУСК")
            {
                START = 0;
                SerialSendButton.Text = "СОХРАНИТЬ";
            }
            else if (TypeLaunchComboBox.Text == "ПУСК с ПК")
            {
                START = 255;
                SerialSendButton.Text = "ПУСК";
            }
        }
    }


}





